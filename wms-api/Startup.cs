using wms_api.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using wms_api.Models;
using System.Text.Json.Serialization;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using wms_api.Helpers;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Linq;

namespace wms_api
{
    public class Startup
    {

        private readonly IConfiguration _configuration;
        private const string _anyCors = "_anyCors";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /*
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
        */

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseRouting();

            // global cors policy
            app.UseCors(_anyCors);

            app.UseAuthentication(); //Debe ir antes de Authorization (en orden)
            app.UseAuthorization();

            try
            {
                app.UseStaticFiles();
                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(
                    Path.Combine(env.ContentRootPath, "PRINT")),
                    RequestPath = "/PRINT"
                });
            }
            catch (Exception ex) { }
            

            app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "wms_api v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

        }




        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddCors(options =>
            {
                /*
                options.AddDefaultPolicy(policy =>
                    policy
                        .WithOrigins("http://localhost:8080", "http://192.168.254.138:9090", "*")
                        //.AllowAnyOrigin()
                        .AllowCredentials()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .SetPreflightMaxAge(TimeSpan.FromSeconds(86400))
                );
                */

                options.AddPolicy(name: _anyCors, builder =>
                    builder
                        //.WithOrigins("http://localhost:8080", "http://192.168.254.138:9090", "https://impormedical.wmsligero.com/", "*")
                        .AllowAnyOrigin()
                        //.AllowCredentials()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .SetPreflightMaxAge(TimeSpan.FromSeconds(86400))
                );
            });

            services.AddEntityFrameworkSqlServer().AddDbContext<WMS_LIGERO_LIVEContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // configure basic authentication 
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddHealthChecks();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WMS Ligero - API", Version = "v1" });
                c.ResolveConflictingActions(x => x.First());
            });


            services.AddControllersWithViews();
            services.AddRazorPages();

            // configure DI for application services
            services.AddScoped<IUserService, UserService>();
        }




    }
}
