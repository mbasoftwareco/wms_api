using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace wms_api.Models
{
    public partial class WMS_LIGERO_LIVEContext : DbContext
    {
        public WMS_LIGERO_LIVEContext()
        {
        }

        public WMS_LIGERO_LIVEContext(DbContextOptions<WMS_LIGERO_LIVEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Import20dic2022Lote> Import20dic2022Lotes { get; set; }
        public virtual DbSet<Import20dic2022Seriale> Import20dic2022Seriales { get; set; }
        public virtual DbSet<Import23Dic2022Lote> Import23Dic2022Lotes { get; set; }
        public virtual DbSet<Import23Dic2022Seriale> Import23Dic2022Seriales { get; set; }
        public virtual DbSet<LLogError> LLogErrors { get; set; }
        public virtual DbSet<MBin> MBins { get; set; }
        public virtual DbSet<MEmpresa> MEmpresas { get; set; }
        public virtual DbSet<MEmpresasConfig> MEmpresasConfigs { get; set; }
        public virtual DbSet<MEstado> MEstados { get; set; }
        public virtual DbSet<MHelpStep> MHelpSteps { get; set; }
        public virtual DbSet<MImage> MImages { get; set; }
        public virtual DbSet<MInquiryConfig> MInquiryConfigs { get; set; }
        public virtual DbSet<MItem> MItems { get; set; }
        public virtual DbSet<MKitDocument> MKitDocuments { get; set; }
        public virtual DbSet<MKitDocumentLine> MKitDocumentLines { get; set; }
        public virtual DbSet<MKitDocumentToPick> MKitDocumentToPicks { get; set; }
        public virtual DbSet<MKitFormula> MKitFormulas { get; set; }
        public virtual DbSet<MMetaMaster> MMetaMasters { get; set; }
        public virtual DbSet<MPrintTemplate> MPrintTemplates { get; set; }
        public virtual DbSet<MResource> MResources { get; set; }
        public virtual DbSet<MResourcesRuntime> MResourcesRuntimes { get; set; }
        public virtual DbSet<MSite> MSites { get; set; }
        public virtual DbSet<PropertiesContainerV3> PropertiesContainerV3s { get; set; }
        public virtual DbSet<PrydeVwItem> PrydeVwItems { get; set; }
        public virtual DbSet<PrydeVwShippingErpDoc> PrydeVwShippingErpDocs { get; set; }
        public virtual DbSet<PrydeVwShippingErpDocsLine> PrydeVwShippingErpDocsLines { get; set; }
        public virtual DbSet<PrydeVwStockAvailableByItem> PrydeVwStockAvailableByItems { get; set; }
        public virtual DbSet<PrydeVwStockAvailableByItemLot> PrydeVwStockAvailableByItemLots { get; set; }
        public virtual DbSet<RtpWmsNavDifference> RtpWmsNavDifferences { get; set; }
        public virtual DbSet<SLangKey> SLangKeys { get; set; }
        public virtual DbSet<SNotification> SNotifications { get; set; }
        public virtual DbSet<SOpcionmenu> SOpcionmenus { get; set; }
        public virtual DbSet<SParametro> SParametros { get; set; }
        public virtual DbSet<SRole> SRoles { get; set; }
        public virtual DbSet<SRolesOpcionmenu> SRolesOpcionmenus { get; set; }
        public virtual DbSet<SRolesUsuario> SRolesUsuarios { get; set; }
        public virtual DbSet<SUsuario> SUsuarios { get; set; }
        public virtual DbSet<SUsuariosEntidade> SUsuariosEntidades { get; set; }
        public virtual DbSet<TBarcode> TBarcodes { get; set; }
        public virtual DbSet<TBarcodeContainer> TBarcodeContainers { get; set; }
        public virtual DbSet<TBarcodeHistory> TBarcodeHistories { get; set; }
        public virtual DbSet<TBarcodeInitial> TBarcodeInitials { get; set; }
        public virtual DbSet<TBarcodePacking> TBarcodePackings { get; set; }
        public virtual DbSet<TBarcodePicking> TBarcodePickings { get; set; }
        public virtual DbSet<TBarcodePickingToErp> TBarcodePickingToErps { get; set; }
        public virtual DbSet<TBarcodeTrack> TBarcodeTracks { get; set; }
        public virtual DbSet<TConfirmationSeq> TConfirmationSeqs { get; set; }
        public virtual DbSet<TConsolidateOrder> TConsolidateOrders { get; set; }
        public virtual DbSet<TContainer> TContainers { get; set; }
        public virtual DbSet<TContainerPo> TContainerPos { get; set; }
        public virtual DbSet<TContainerPoAssign> TContainerPoAssigns { get; set; }
        public virtual DbSet<TContainerRuntime> TContainerRuntimes { get; set; }
        public virtual DbSet<TContainerUploadfile> TContainerUploadfiles { get; set; }
        public virtual DbSet<TCountSchedule> TCountSchedules { get; set; }
        public virtual DbSet<TCountScheduleDay> TCountScheduleDays { get; set; }
        public virtual DbSet<TCountTask> TCountTasks { get; set; }
        public virtual DbSet<TCountTaskCurrstock> TCountTaskCurrstocks { get; set; }
        public virtual DbSet<TCountTaskItem> TCountTaskItems { get; set; }
        public virtual DbSet<TCountTaskPosted> TCountTaskPosteds { get; set; }
        public virtual DbSet<TCountTaskRuntime> TCountTaskRuntimes { get; set; }
        public virtual DbSet<TEnviomail> TEnviomails { get; set; }
        public virtual DbSet<TErpdocHistory> TErpdocHistories { get; set; }
        public virtual DbSet<TErpdocProcessed> TErpdocProcesseds { get; set; }
        public virtual DbSet<TErpdocRuntime> TErpdocRuntimes { get; set; }
        public virtual DbSet<TInventoryTrack> TInventoryTracks { get; set; }
        public virtual DbSet<TPackingPallet> TPackingPallets { get; set; }
        public virtual DbSet<TSetupItem> TSetupItems { get; set; }
        public virtual DbSet<TSetupShipcut> TSetupShipcuts { get; set; }
        public virtual DbSet<TSetupShipcutShipvium> TSetupShipcutShipvia { get; set; }
        public virtual DbSet<TTaskAssign> TTaskAssigns { get; set; }
        public virtual DbSet<TTaskAssignSkip> TTaskAssignSkips { get; set; }
        public virtual DbSet<TTransfer> TTransfers { get; set; }
        public virtual DbSet<TTransfersItem> TTransfersItems { get; set; }
        public virtual DbSet<TemporaryFileUpload> TemporaryFileUploads { get; set; }
        public virtual DbSet<TmpContainerV3> TmpContainerV3s { get; set; }
        public virtual DbSet<TmpContainerV3Distribution> TmpContainerV3Distributions { get; set; }
        public virtual DbSet<TmpErpdocStock> TmpErpdocStocks { get; set; }
        public virtual DbSet<TmpErpdocStockItem> TmpErpdocStockItems { get; set; }
        public virtual DbSet<V2ApiDocumentWork> V2ApiDocumentWorks { get; set; }
        public virtual DbSet<V2ApiIntegrationControl> V2ApiIntegrationControls { get; set; }
        public virtual DbSet<V2ApiSiesaConector> V2ApiSiesaConectors { get; set; }
        public virtual DbSet<V2ApiStock> V2ApiStocks { get; set; }
        public virtual DbSet<V2MasterConfig> V2MasterConfigs { get; set; }
        public virtual DbSet<V2MasterConnection> V2MasterConnections { get; set; }
        public virtual DbSet<V2MasterDeliveryCity> V2MasterDeliveryCities { get; set; }
        public virtual DbSet<V2MasterDeliveryService> V2MasterDeliveryServices { get; set; }
        public virtual DbSet<V2MasterMetalist> V2MasterMetalists { get; set; }
        public virtual DbSet<V2MasterPackage> V2MasterPackages { get; set; }
        public virtual DbSet<V2MasterVehicle> V2MasterVehicles { get; set; }
        public virtual DbSet<V2NotificacionesAutomatica> V2NotificacionesAutomaticas { get; set; }
        public virtual DbSet<V2OpeDeliveryQuote> V2OpeDeliveryQuotes { get; set; }
        public virtual DbSet<V2OpeDeliveryTask> V2OpeDeliveryTasks { get; set; }
        public virtual DbSet<V2OpeDeliveryTaskDetail> V2OpeDeliveryTaskDetails { get; set; }
        public virtual DbSet<V2OpeDeviceSession> V2OpeDeviceSessions { get; set; }
        public virtual DbSet<V2OpeDocument> V2OpeDocuments { get; set; }
        public virtual DbSet<V2OpeDocumentLog> V2OpeDocumentLogs { get; set; }
        public virtual DbSet<V2OpeDocumentPackage> V2OpeDocumentPackages { get; set; }
        public virtual DbSet<V2OpeResource> V2OpeResources { get; set; }
        public virtual DbSet<V2WmsConfig> V2WmsConfigs { get; set; }
        public virtual DbSet<V2WmsDeliveryCompany> V2WmsDeliveryCompanies { get; set; }
        public virtual DbSet<V2WmsManualDeliveryCompany> V2WmsManualDeliveryCompanies { get; set; }
        public virtual DbSet<VwContainerFileLine> VwContainerFileLines { get; set; }
        public virtual DbSet<VwDeliveryErpDoc> VwDeliveryErpDocs { get; set; }
        public virtual DbSet<VwItem> VwItems { get; set; }
        public virtual DbSet<VwItemUom> VwItemUoms { get; set; }
        public virtual DbSet<VwKitLinePending> VwKitLinePendings { get; set; }
        public virtual DbSet<VwReceivingErpDoc> VwReceivingErpDocs { get; set; }
        public virtual DbSet<VwReceivingErpDocsLine> VwReceivingErpDocsLines { get; set; }
        public virtual DbSet<VwShippingErpCommentLine> VwShippingErpCommentLines { get; set; }
        public virtual DbSet<VwShippingErpDoc> VwShippingErpDocs { get; set; }
        public virtual DbSet<VwShippingErpDocsBackorder> VwShippingErpDocsBackorders { get; set; }
        public virtual DbSet<VwShippingErpDocsLine> VwShippingErpDocsLines { get; set; }
        public virtual DbSet<VwShippingErpDocsLinesStock> VwShippingErpDocsLinesStocks { get; set; }
        public virtual DbSet<VwShippingErpDocsOpen> VwShippingErpDocsOpens { get; set; }
        public virtual DbSet<VwShippingErpDocsStarship> VwShippingErpDocsStarships { get; set; }
        public virtual DbSet<VwShippingErpDocsTime> VwShippingErpDocsTimes { get; set; }
        public virtual DbSet<VwShippingErpInvoice> VwShippingErpInvoices { get; set; }
        public virtual DbSet<VwSite> VwSites { get; set; }
        public virtual DbSet<VwStockAvailableByItemBarcode> VwStockAvailableByItemBarcodes { get; set; }
        public virtual DbSet<VwStockAvailableByItemLot> VwStockAvailableByItemLots { get; set; }
        public virtual DbSet<VwStockAvailableByItemWm> VwStockAvailableByItemWms { get; set; }
        public virtual DbSet<VwStockAvailableByItemWmsBin> VwStockAvailableByItemWmsBins { get; set; }
        public virtual DbSet<VwTaskAssignOpen> VwTaskAssignOpens { get; set; }
        public virtual DbSet<VwUserByRol> VwUserByRols { get; set; }
        public virtual DbSet<VwWmsBinReference> VwWmsBinReferences { get; set; }
        public virtual DbSet<VwWmsNavComparison> VwWmsNavComparisons { get; set; }
        public virtual DbSet<VwWmsPackingBalance> VwWmsPackingBalances { get; set; }
        public virtual DbSet<VwWmsPackingBalanceNotPacked> VwWmsPackingBalanceNotPackeds { get; set; }
        public virtual DbSet<VwWmsPackingBalanceWeb> VwWmsPackingBalanceWebs { get; set; }
        public virtual DbSet<VwWmsPackingConsolidate> VwWmsPackingConsolidates { get; set; }
        public virtual DbSet<VwWmsShipviaCuttime> VwWmsShipviaCuttimes { get; set; }
        public virtual DbSet<WfProceso> WfProcesos { get; set; }
        public virtual DbSet<WfProcesoRuntime> WfProcesoRuntimes { get; set; }
        public virtual DbSet<WfProcesoStep> WfProcesoSteps { get; set; }
        public virtual DbSet<ZItem> ZItems { get; set; }
        public virtual DbSet<ZItemUom> ZItemUoms { get; set; }
        public virtual DbSet<ZReceivingErpDoc> ZReceivingErpDocs { get; set; }
        public virtual DbSet<ZReceivingErpDocsLine> ZReceivingErpDocsLines { get; set; }
        public virtual DbSet<ZShippingErpDoc> ZShippingErpDocs { get; set; }
        public virtual DbSet<ZShippingErpDocsLine> ZShippingErpDocsLines { get; set; }
        public virtual DbSet<ZSite> ZSites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Import20dic2022Lote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_import_20dic2022_lotes");

                entity.Property(e => e.CódigoDeAlmacén)
                    .HasMaxLength(255)
                    .HasColumnName("Código de almacén");

                entity.Property(e => e.NúmeroDeArtículo)
                    .HasMaxLength(255)
                    .HasColumnName("Número de artículo");

                entity.Property(e => e.NúmeroDeLote)
                    .HasMaxLength(255)
                    .HasColumnName("Número de lote");

                entity.Property(e => e._).HasColumnName("#");
            });

            modelBuilder.Entity<Import20dic2022Seriale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_import_20dic2022_seriales");

                entity.Property(e => e.CódigoDeAlmacén)
                    .HasMaxLength(255)
                    .HasColumnName("Código de almacén");

                entity.Property(e => e.MdAbsEntry).HasColumnName("MD Abs Entry");

                entity.Property(e => e.NúmeroDeArtículo)
                    .HasMaxLength(255)
                    .HasColumnName("Número de artículo");

                entity.Property(e => e.NúmeroDeSerieDelFabricante)
                    .HasMaxLength(255)
                    .HasColumnName("Número de serie del fabricante");

                entity.Property(e => e._).HasColumnName("#");
            });

            modelBuilder.Entity<Import23Dic2022Lote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_import23DIC2022_lotes");

                entity.Property(e => e.CódigoDeAlmacén)
                    .HasMaxLength(255)
                    .HasColumnName("Código de almacén");

                entity.Property(e => e.NúmeroDeArtículo)
                    .HasMaxLength(255)
                    .HasColumnName("Número de artículo");

                entity.Property(e => e.NúmeroDeLote)
                    .HasMaxLength(255)
                    .HasColumnName("Número de lote");

                entity.Property(e => e._).HasColumnName("#");
            });

            modelBuilder.Entity<Import23Dic2022Seriale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_import23DIC2022_seriales");

                entity.Property(e => e.CódigoDeAlmacén)
                    .HasMaxLength(255)
                    .HasColumnName("Código de almacén");

                entity.Property(e => e.MdAbsEntry).HasColumnName("MD Abs Entry");

                entity.Property(e => e.NúmeroDeArtículo)
                    .HasMaxLength(255)
                    .HasColumnName("Número de artículo");

                entity.Property(e => e.NúmeroDeSerieDelFabricante)
                    .HasMaxLength(255)
                    .HasColumnName("Número de serie del fabricante");

                entity.Property(e => e._).HasColumnName("#");
            });

            modelBuilder.Entity<LLogError>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("L_LOG_ERROR");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogClass)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LOG_CLASS");

                entity.Property(e => e.LogMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("LOG_MESSAGE");

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");
            });

            modelBuilder.Entity<MBin>(entity =>
            {
                entity.HasKey(e => new { e.Site, e.Bincode });

                entity.ToTable("M_BIN");

                entity.HasIndex(e => e.Sequence, "IX_M_BIN");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.AisleNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AISLE_NO");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY")
                    .HasDefaultValueSql("('IMPORMEDICAL')");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY")
                    .HasDefaultValueSql("('AG3')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastCountDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_COUNT_DATE");

                entity.Property(e => e.LastCountSchedule)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LAST_COUNT_SCHEDULE");

                entity.Property(e => e.LastCountTask)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LAST_COUNT_TASK");

                entity.Property(e => e.LevelNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LEVEL_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rowid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWID");

                entity.Property(e => e.SectionNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SECTION_NO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.StatusNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NOTES");
            });

            modelBuilder.Entity<MEmpresa>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_t001_empresas");

                entity.ToTable("m_empresas");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod_postal");

                entity.Property(e => e.Direccion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion1");

                entity.Property(e => e.Direccion2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion2");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.IdTipoErp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_tipo_erp");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("identificacion");

                entity.Property(e => e.IndActivo).HasColumnName("ind_activo");

                entity.Property(e => e.Logo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("logo");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Razonsocial)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("razonsocial");

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono1");

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono2");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");
            });

            modelBuilder.Entity<MEmpresasConfig>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("m_empresas_config");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTipoErp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_tipo_erp");

                entity.Property(e => e.IndActivo)
                    .HasColumnName("ind_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Parametros)
                    .HasColumnType("text")
                    .HasColumnName("parametros");

                entity.Property(e => e.RowidEmpresa).HasColumnName("rowid_empresa");

                entity.Property(e => e.Secuencia).HasColumnName("secuencia");

                entity.Property(e => e.Step)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("step");

                entity.Property(e => e.Tiporeg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tiporeg");

                entity.HasOne(d => d.RowidEmpresaNavigation)
                    .WithMany(p => p.MEmpresasConfigs)
                    .HasForeignKey(d => d.RowidEmpresa)
                    .HasConstraintName("FK_m_empresas_config_m_empresas");
            });

            modelBuilder.Entity<MEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("m_estados");

                entity.Property(e => e.IdEstado)
                    .ValueGeneratedNever()
                    .HasColumnName("id_estado");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_estado");

                entity.Property(e => e.TipoEstado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipo_estado");
            });

            modelBuilder.Entity<MHelpStep>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("M_HELP_STEP");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.Image)
                    .HasColumnType("text")
                    .HasColumnName("IMAGE");

                entity.Property(e => e.IndActivo)
                    .HasColumnName("IND_ACTIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Process)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");

                entity.Property(e => e.Step).HasColumnName("STEP");

                entity.Property(e => e.TextEn)
                    .HasColumnType("text")
                    .HasColumnName("TEXT_EN");

                entity.Property(e => e.TextEs)
                    .HasColumnType("text")
                    .HasColumnName("TEXT_ES");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TYPE")
                    .HasDefaultValueSql("('W')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MImage>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("M_IMAGES");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASS");

                entity.Property(e => e.ImageBinary).HasColumnName("IMAGE_BINARY");

                entity.Property(e => e.ImageBinary1).HasColumnName("IMAGE_BINARY_1");

                entity.Property(e => e.ImageBinary2).HasColumnName("IMAGE_BINARY_2");

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IMAGE_NAME");
            });

            modelBuilder.Entity<MInquiryConfig>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_INQUIRY_CONFIG");

                entity.ToTable("M_INQUIRY_CONFIG");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Align)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALIGN");

                entity.Property(e => e.Columns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COLUMNS");

                entity.Property(e => e.Width)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WIDTH");
            });

            modelBuilder.Entity<MItem>(entity =>
            {
                entity.HasKey(e => e.Itemcode)
                    .HasName("PK_M_ITEMS");

                entity.ToTable("M_ITEM");

                entity.HasIndex(e => e.Upc, "IX_M_ITEMS");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.IsKit).HasColumnName("IS_KIT");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("regdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.RequireSn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_SN");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.Vendorid)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VENDORID");
            });

            modelBuilder.Entity<MKitDocument>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("M_KIT_DOCUMENT");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Docid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docstatus)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DOCSTATUS")
                    .HasDefaultValueSql("('OPEN')");

                entity.Property(e => e.ItemcodeKit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_KIT");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<MKitDocumentLine>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("M_KIT_DOCUMENT_LINE");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Docid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.FormulaQty).HasColumnName("FORMULA_QTY");

                entity.Property(e => e.ItemcodeComponent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_COMPONENT");

                entity.Property(e => e.ItemcodeKit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_KIT");

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.Property(e => e.ToPick).HasColumnName("TO_PICK");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<MKitDocumentToPick>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("M_KIT_DOCUMENT_TO_PICK");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Docid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docline).HasColumnName("DOCLINE");

                entity.Property(e => e.ItemcodeComponent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_COMPONENT");

                entity.Property(e => e.ItemcodeKit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_KIT");

                entity.Property(e => e.ToPick).HasColumnName("TO_PICK");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<MKitFormula>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK__KIT_FORM__FFEE7451C03A84E4");

                entity.ToTable("M_KIT_FORMULA");

                entity.HasIndex(e => new { e.ItemcodeKit, e.ItemcodeComponent }, "IX_M_KIT_FORMULA")
                    .IsUnique();

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FormulaQty).HasColumnName("FORMULA_QTY");

                entity.Property(e => e.IndActive).HasColumnName("IND_ACTIVE");

                entity.Property(e => e.ItemcodeComponent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_COMPONENT");

                entity.Property(e => e.ItemcodeKit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_KIT");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<MMetaMaster>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("M_META_MASTER");

                entity.HasIndex(e => e.Seq, "IX_M_META_MASTER");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.ClassCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASS_CODE");

                entity.Property(e => e.MasterCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_CODE");

                entity.Property(e => e.MasterName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_NAME");

                entity.Property(e => e.Seq).HasColumnName("SEQ");
            });

            modelBuilder.Entity<MPrintTemplate>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK__LabelTemplate__7737525A");

                entity.ToTable("m_print_template");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Header).HasMaxLength(2500);

                entity.Property(e => e.IsPl).HasColumnName("IsPL");

                entity.Property(e => e.IsUnique).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumCopies).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pldetail)
                    .HasColumnType("text")
                    .HasColumnName("PLDetail");

                entity.Property(e => e.Pltemplate)
                    .IsUnicode(false)
                    .HasColumnName("PLTemplate");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MResource>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("m_resources");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("resource_address");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resource_name");

                entity.Property(e => e.ResourceType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("resource_type");

                entity.Property(e => e.Selected).HasColumnName("selected");

                entity.Property(e => e.Site)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<MResourcesRuntime>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("m_resources_runtime");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerRowid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OWNER_ROWID");

                entity.Property(e => e.OwnerType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("owner_type");

                entity.Property(e => e.RowidResource).HasColumnName("rowid_resource");

                entity.Property(e => e.TempleteCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEMPLETE_CODE");

                entity.HasOne(d => d.RowidResourceNavigation)
                    .WithMany(p => p.MResourcesRuntimes)
                    .HasForeignKey(d => d.RowidResource)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_resources_runtime_m_resources");
            });

            modelBuilder.Entity<MSite>(entity =>
            {
                entity.HasKey(e => e.Site);

                entity.ToTable("M_SITE");

                entity.Property(e => e.Site)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE_NAME");
            });

            modelBuilder.Entity<PropertiesContainerV3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROPERTIES_CONTAINER_V3");

                entity.Property(e => e.ColumName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Properties)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrydeVwItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("__PRYDE__vw_ITEM");

                entity.Property(e => e.IsKit).HasColumnName("IS_KIT");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UOM");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UPC");

                entity.Property(e => e.Vendorid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VENDORID")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<PrydeVwShippingErpDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("__PRYDE__vw_SHIPPING_ERP_DOCS");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address1)
                    .HasMaxLength(101)
                    .HasColumnName("ADDRESS1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address2)
                    .HasMaxLength(84)
                    .HasColumnName("ADDRESS2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addresstype).HasColumnName("ADDRESSTYPE");

                entity.Property(e => e.Addrline1)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addrline2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AGENTCODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentservice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AGENTSERVICE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Backorder)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BACKORDER");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_TYPE");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("CITY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("COUNTRY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createuser)
                    .HasMaxLength(4000)
                    .HasColumnName("CREATEUSER")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Customerpo)
                    .HasMaxLength(4000)
                    .HasColumnName("CUSTOMERPO")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(31)
                    .HasColumnName("DOCNUMBER")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("EMAIL")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Emailcontact)
                    .HasMaxLength(150)
                    .HasColumnName("EMAILCONTACT")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Freightacc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("FREIGHTACC")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpAddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("IMP_ADDRESS")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpCity)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("IMP_CITY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("IMP_COUNTRY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("IMP_NAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IMP_PHONE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpState)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IMP_STATE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpZip)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IMP_ZIP")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.InsideDeliv).HasColumnName("INSIDE_DELIV");

                entity.Property(e => e.LiftDeliv).HasColumnName("LIFT_DELIV");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Oversize).HasColumnName("OVERSIZE");

                entity.Property(e => e.Paymethod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PAYMETHOD")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Payterm)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PAYTERM")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ProcessStatus).HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.Promiseddate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROMISEDDATE");

                entity.Property(e => e.Releasedate)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEDATE");

                entity.Property(e => e.Reqdelivery)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQDELIVERY");

                entity.Property(e => e.SalesrepMail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SALESREP_MAIL")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ServAgentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SERV_AGENT_CODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoaddress)
                    .HasMaxLength(50)
                    .HasColumnName("SHIPTOADDRESS")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoname)
                    .HasMaxLength(4000)
                    .HasColumnName("SHIPTONAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.SignatureReq).HasColumnName("SIGNATURE_REQ");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .HasColumnName("STATE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Totalprice)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("TOTALPRICE");

                entity.Property(e => e.Wbroker)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("WBROKER")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .HasColumnName("ZIP")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<PrydeVwShippingErpDocsLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("__PRYDE__vw_SHIPPING_ERP_DOCS_LINES");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(31)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.HasStock).HasColumnName("HAS_STOCK");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.LineWeight)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("LINE_WEIGHT");

                entity.Property(e => e.Lineid).HasColumnName("LINEID");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC");

                entity.Property(e => e.QtyPerUom)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("QTY_PER_UOM");

                entity.Property(e => e.Qtyonprocess).HasColumnName("QTYONPROCESS");

                entity.Property(e => e.Qtyorder)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYORDER");

                entity.Property(e => e.Qtypending)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYPENDING");

                entity.Property(e => e.Qtyshipped)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYSHIPPED");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("UNIT_PRICE");

                entity.Property(e => e.Unitid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UNITID");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<PrydeVwStockAvailableByItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("__PRYDE__vw_STOCK_AVAILABLE_BY_ITEM");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.QtyAvailable)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_AVAILABLE");

                entity.Property(e => e.QtyOnPick)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_ON_PICK");

                entity.Property(e => e.QtyShipReserved).HasColumnName("QTY_SHIP_RESERVED");

                entity.Property(e => e.Site)
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.StockQty)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("STOCK_QTY");
            });

            modelBuilder.Entity<PrydeVwStockAvailableByItemLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("__PRYDE__vw_STOCK_AVAILABLE_BY_ITEM_LOT");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Lotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LOTNO");

                entity.Property(e => e.QtyAvailable)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_AVAILABLE");

                entity.Property(e => e.QtyOnPick)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_ON_PICK");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.StockQty)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("STOCK_QTY");
            });

            modelBuilder.Entity<RtpWmsNavDifference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RTP_WMS_NAV_DIFFERENCE");

                entity.Property(e => e.DiffOnhand).HasColumnName("DIFF_ONHAND");

                entity.Property(e => e.DiffWithNoPosted).HasColumnName("DIFF_WITH_NO_POSTED");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.NavOnhand)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("NAV_ONHAND");

                entity.Property(e => e.NavToReceive)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("NAV_TO_RECEIVE");

                entity.Property(e => e.NavToShip)
                    .HasColumnType("numeric(26, 0)")
                    .HasColumnName("NAV_TO_SHIP");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.WmsOnhand).HasColumnName("WMS_ONHAND");

                entity.Property(e => e.WmsPicked).HasColumnName("WMS_PICKED");
            });

            modelBuilder.Entity<SLangKey>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("s_lang_keys");

                entity.HasIndex(e => new { e.Module, e.Key, e.Lang }, "IX_s_lang_keys")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Controller).HasColumnName("controller");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndActivo)
                    .HasColumnName("ind_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("key");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lang");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("module");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<SNotification>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("S_NOTIFICATION");

                entity.HasIndex(e => new { e.IdProceso, e.IdTask }, "IX_S_NOTIFICATION")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Frequency).HasColumnName("FREQUENCY");

                entity.Property(e => e.IdProceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_PROCESO");

                entity.Property(e => e.IdTask)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_TASK");

                entity.Property(e => e.IndActive)
                    .HasColumnName("IND_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastSent)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_SENT");

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_TO");

                entity.Property(e => e.NextSend)
                    .HasColumnType("datetime")
                    .HasColumnName("NEXT_SEND");

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");
            });

            modelBuilder.Entity<SOpcionmenu>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_s_menuopciones");

                entity.ToTable("s_opcionmenu");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.Icono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("icono");

                entity.Property(e => e.IndActivo).HasColumnName("ind_activo");

                entity.Property(e => e.ModuloProceso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modulo_proceso");

                entity.Property(e => e.NombreOpcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_opcion");

                entity.Property(e => e.Numorden).HasColumnName("numorden");

                entity.Property(e => e.RowidOpcionpadre).HasColumnName("rowid_opcionpadre");

                entity.Property(e => e.TextoAyuda)
                    .HasColumnType("text")
                    .HasColumnName("texto_ayuda");

                entity.Property(e => e.TipoOpcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipo_opcion")
                    .IsFixedLength(true)
                    .HasComment("A-App,D-Device,R-Reports");

                entity.Property(e => e.UrlLink)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("url_link");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");

                entity.HasOne(d => d.RowidOpcionpadreNavigation)
                    .WithMany(p => p.InverseRowidOpcionpadreNavigation)
                    .HasForeignKey(d => d.RowidOpcionpadre)
                    .HasConstraintName("FK_s_opcionmenu_s_opcionmenu");
            });

            modelBuilder.Entity<SParametro>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("s_parametros");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CodParametro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod_parametro");

                entity.Property(e => e.NombreParametro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_parametro");

                entity.Property(e => e.RowidEmpresa).HasColumnName("rowid_empresa");

                entity.Property(e => e.Tiporeg)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tiporeg");

                entity.Property(e => e.ValorParametro)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("valor_parametro");
            });

            modelBuilder.Entity<SRole>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("s_roles");

                entity.HasIndex(e => e.IdRol, "IX_s_roles")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.IdRol)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_rol");

                entity.Property(e => e.IndControltotal).HasColumnName("ind_controltotal");

                entity.Property(e => e.IndManejaTareas).HasColumnName("ind_maneja_tareas");

                entity.Property(e => e.IndTodasLasBodegas).HasColumnName("ind_todas_las_bodegas");

                entity.Property(e => e.IndTodosLosClientes).HasColumnName("ind_todos_los_clientes");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_rol");

                entity.Property(e => e.RowidTercero)
                    .HasColumnType("money")
                    .HasColumnName("rowid_tercero")
                    .HasComment("En caso de que sea un rol para un tercero especifico");

                entity.Property(e => e.Selected).HasColumnName("selected");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");
            });

            modelBuilder.Entity<SRolesOpcionmenu>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("s_roles_opcionmenu");

                entity.HasIndex(e => new { e.RowidRol, e.RowidMenuopcion }, "IX_s_roles_opcionmenu")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.IndActivo).HasColumnName("ind_activo");

                entity.Property(e => e.RowidEmpresa).HasColumnName("rowid_empresa");

                entity.Property(e => e.RowidMenuopcion).HasColumnName("rowid_menuopcion");

                entity.Property(e => e.RowidRol).HasColumnName("rowid_rol");

                entity.Property(e => e.Usuariocreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");

                entity.HasOne(d => d.RowidEmpresaNavigation)
                    .WithMany(p => p.SRolesOpcionmenus)
                    .HasForeignKey(d => d.RowidEmpresa)
                    .HasConstraintName("FK_s_roles_opcionmenu_m_empresas");

                entity.HasOne(d => d.RowidMenuopcionNavigation)
                    .WithMany(p => p.SRolesOpcionmenus)
                    .HasForeignKey(d => d.RowidMenuopcion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_roles_opcionmenu_s_menuopciones");

                entity.HasOne(d => d.RowidRolNavigation)
                    .WithMany(p => p.SRolesOpcionmenus)
                    .HasForeignKey(d => d.RowidRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_roles_opcionmenu_s_roles");
            });

            modelBuilder.Entity<SRolesUsuario>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("s_roles_usuarios");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.RowidEmpresa).HasColumnName("rowid_empresa");

                entity.Property(e => e.RowidRol).HasColumnName("rowid_rol");

                entity.Property(e => e.RowidUsuario).HasColumnName("rowid_usuario");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");

                entity.HasOne(d => d.RowidEmpresaNavigation)
                    .WithMany(p => p.SRolesUsuarios)
                    .HasForeignKey(d => d.RowidEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_roles_usuarios_m_empresas");

                entity.HasOne(d => d.RowidRolNavigation)
                    .WithMany(p => p.SRolesUsuarios)
                    .HasForeignKey(d => d.RowidRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_roles_usuarios_s_roles");

                entity.HasOne(d => d.RowidUsuarioNavigation)
                    .WithMany(p => p.SRolesUsuarios)
                    .HasForeignKey(d => d.RowidUsuario)
                    .HasConstraintName("FK_s_roles_usuarios_s_usuarios");
            });

            modelBuilder.Entity<SUsuario>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("s_usuarios");

                entity.HasIndex(e => e.NombreUsuario, "IX_s_usuarios")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.AceptoCondiciones)
                    .HasColumnType("datetime")
                    .HasColumnName("acepto_condiciones");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.ErpCodigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("erp_codigo");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.IdCia).HasColumnName("id_cia");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("identificacion");

                entity.Property(e => e.Idioma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idioma");

                entity.Property(e => e.IndActivo)
                    .HasColumnName("ind_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IndCambiarclave).HasColumnName("ind_cambiarclave");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_usuario");

                entity.Property(e => e.ResetToken)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reset_token");

                entity.Property(e => e.RowidEmpresa)
                    .HasColumnName("rowid_empresa")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.UrlAvatar)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_avatar");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");
            });

            modelBuilder.Entity<SUsuariosEntidade>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_s_usuario_permisos");

                entity.ToTable("s_usuarios_entidades");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.ErpIdCia).HasColumnName("erp_id_cia");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.IdTipoEntidad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_tipo_entidad")
                    .HasComment("Entidad del permiso, bodega, centro de operacion, sucursal etc.");

                entity.Property(e => e.IndPrincipal).HasColumnName("ind_principal");

                entity.Property(e => e.RowidEmpresa)
                    .HasColumnName("rowid_empresa")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.RowidUsuario).HasColumnName("rowid_usuario");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");

                entity.Property(e => e.ValorEntidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("valor_entidad");

                entity.HasOne(d => d.RowidEmpresaNavigation)
                    .WithMany(p => p.SUsuariosEntidades)
                    .HasForeignKey(d => d.RowidEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_usuarios_entidades_m_empresas");

                entity.HasOne(d => d.RowidUsuarioNavigation)
                    .WithMany(p => p.SUsuariosEntidades)
                    .HasForeignKey(d => d.RowidUsuario)
                    .HasConstraintName("FK_s_usuarios_entidades_s_usuarios");
            });

            modelBuilder.Entity<TBarcode>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_BARCODE");

                entity.HasIndex(e => e.Barcode, "IX_T_BARCODE");

                entity.HasIndex(e => e.PrintGuid, "IX_T_BARCODE_PGUID");

                entity.HasIndex(e => e.Erpdocline, "IX_T_ERPLINE");

                entity.HasIndex(e => e.Item, "IX_T_ITEM");

                entity.HasIndex(e => e.Receiptdoc, "IX_T_RECEIPTDOC");

                entity.HasIndex(e => e.Bincode, "IX_T_SITE_BIN");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Disabled).HasColumnName("DISABLED");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Expdate)
                    .HasColumnType("date")
                    .HasColumnName("EXPDATE");

                entity.Property(e => e.FactorBase)
                    .HasColumnName("factor_base")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.LastBincode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_BINCODE");

                entity.Property(e => e.LotSn)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT_SN");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.PrintGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_GUID");

                entity.Property(e => e.Printed).HasColumnName("PRINTED");

                entity.Property(e => e.QuantityOriginal).HasColumnName("QUANTITY_ORIGINAL");

                entity.Property(e => e.QuantityRemaining).HasColumnName("QUANTITY_REMAINING");

                entity.Property(e => e.Receiptdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RECEIPTDOC");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Um)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("um")
                    .HasDefaultValueSql("('UND')");
            });

            modelBuilder.Entity<TBarcodeContainer>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_BARCODE_CONTAINER");

                entity.HasIndex(e => e.ContainerNo, "IX_T_BARCODE_CONTAINER_NO");

                entity.HasIndex(e => e.Createdon, "IX_T_BARCODE_CREATEDON");

                entity.HasIndex(e => e.Erpdoc, "IX_T_BARCODE_ERPDOC");

                entity.HasIndex(e => new { e.Erpdoc, e.Item, e.Erpdocline }, "IX_T_BARCODE_ERPDOCLINES");

                entity.HasIndex(e => e.Erpdocline, "IX_T_BARCODE_ERPLINE");

                entity.HasIndex(e => e.Item, "IX_T_BARCODE_ITEM");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.ContainerNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_NO");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.PrintGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_GUID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Receiptdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RECEIPTDOC");

                entity.Property(e => e.Seq)
                    .HasColumnName("SEQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.HasOne(d => d.ContainerNoNavigation)
                    .WithMany(p => p.TBarcodeContainers)
                    .HasPrincipalKey(p => p.ContainerNo)
                    .HasForeignKey(d => d.ContainerNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_BARCODE_CONTAINER_T_CONTAINER");
            });

            modelBuilder.Entity<TBarcodeHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_BARCODE_HISTORY");

                entity.HasIndex(e => e.RecordDate, "IX_T_BARCODE_HISTORY");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Disabled).HasColumnName("DISABLED");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.LastBincode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_BINCODE");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.PrintGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_GUID");

                entity.Property(e => e.Printed).HasColumnName("PRINTED");

                entity.Property(e => e.QuantityOriginal).HasColumnName("QUANTITY_ORIGINAL");

                entity.Property(e => e.QuantityRemaining).HasColumnName("QUANTITY_REMAINING");

                entity.Property(e => e.Receiptdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RECEIPTDOC");

                entity.Property(e => e.RecordDate)
                    .HasColumnType("date")
                    .HasColumnName("RECORD_DATE");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<TBarcodeInitial>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_BARCODE_XX");

                entity.ToTable("T_BARCODE_INITIAL");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Disabled).HasColumnName("DISABLED");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.LastBincode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_BINCODE");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.PrintGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_GUID");

                entity.Property(e => e.Printed).HasColumnName("PRINTED");

                entity.Property(e => e.QuantityOriginal).HasColumnName("QUANTITY_ORIGINAL");

                entity.Property(e => e.QuantityRemaining).HasColumnName("QUANTITY_REMAINING");

                entity.Property(e => e.Receiptdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RECEIPTDOC");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<TBarcodePacking>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_BARCODE_PACKING");

                entity.HasIndex(e => e.Confirmdoc, "IX_T_BARCODE_CONFIRMDOC");

                entity.HasIndex(e => e.Erpdoc, "IX_T_BARCODE_ERPDOC");

                entity.HasIndex(e => e.Pickingdoc, "IX_T_BARCODE_POCKINGDOC");

                entity.HasIndex(e => e.RowidPicking, "IX_T_BARCODE_ROWIDPICK");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDBY");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("COMPLETEDON");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Package)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKAGE");

                entity.Property(e => e.Pickingdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PICKINGDOC");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.QtyRemoved).HasColumnName("QTY_REMOVED");

                entity.Property(e => e.RowidPicking).HasColumnName("ROWID_PICKING");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("UOM")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.RowidPickingNavigation)
                    .WithMany(p => p.TBarcodePackings)
                    .HasForeignKey(d => d.RowidPicking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_BARCODE_PACKING_T_BARCODE_PICKING");
            });

            modelBuilder.Entity<TBarcodePicking>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_PICKING");

                entity.ToTable("T_BARCODE_PICKING");

                entity.HasIndex(e => e.Barcode, "IX_T_BARCODE_PICK_BAR");

                entity.HasIndex(e => e.Confirmdoc, "IX_T_BARCODE_PICK_CONFIRM");

                entity.HasIndex(e => e.Erpdoc, "IX_T_BARCODE_PICK_ERPDOC");

                entity.HasIndex(e => e.Erpdocline, "IX_T_BARCODE_PICK_ERPLINE");

                entity.HasIndex(e => e.Item, "IX_T_BARCODE_PICK_ITEM");

                entity.HasIndex(e => e.TmpGuid, "IX_T_BARCODE_TMPGUID");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDBY");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("COMPLETEDON");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.QtyRemoved)
                    .HasColumnName("QTY_REMOVED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Releaseby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELEASEBY");

                entity.Property(e => e.Releaseon)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEON");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.TmpGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TMP_GUID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("UOM")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TBarcodePickingToErp>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_BARCODE_PICKING_TO_ERP");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpline).HasColumnName("ERPLINE");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.LotSn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOT_SN");

                entity.Property(e => e.LotSnTrack)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LOT_SN_TRACK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.UserCustom1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_custom_1");
            });

            modelBuilder.Entity<TBarcodeTrack>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_BARCODE_TRACK");

                entity.HasIndex(e => e.Barcode, "IX_T_BARCODE_BAR");

                entity.HasIndex(e => e.Itemcode, "IX_T_BARCODE_ITEM");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACTION");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE1");

                entity.Property(e => e.Bincode2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE2");

                entity.Property(e => e.Casepack).HasColumnName("CASEPACK");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Erpdoc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.LotSn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOT_SN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Uom)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<TConfirmationSeq>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_CONFIRMATION_SEQUENCE");

                entity.ToTable("T_CONFIRMATION_SEQ");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Nextseq).HasColumnName("NEXTSEQ");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Process)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");
            });

            modelBuilder.Entity<TConsolidateOrder>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_t");

                entity.ToTable("T_CONSOLIDATE_ORDERS");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Accountid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.ConsolidateNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONSOLIDATE_NO");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.IndPrincipal).HasColumnName("IND_PRINCIPAL");

                entity.Property(e => e.Packingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKINGDATE");

                entity.Property(e => e.Packingdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKINGDOC");

                entity.Property(e => e.Pickingdoc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PICKINGDOC");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Sessionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<TContainer>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_CONTAINER");

                entity.HasIndex(e => e.ContainerNo, "IX_T_CONTAINER")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.ContainerNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_NO");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lock).HasColumnName("LOCK");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERENCE");

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VENDOR_ID");
            });

            modelBuilder.Entity<TContainerPo>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_CONTAINER_PO");

                entity.HasIndex(e => new { e.ContainerNo, e.Erpdoc }, "IX_T_CONTAINER_CONT")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.ContainerNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_NO");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Lock).HasColumnName("LOCK");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.HasOne(d => d.ContainerNoNavigation)
                    .WithMany(p => p.TContainerPos)
                    .HasPrincipalKey(p => p.ContainerNo)
                    .HasForeignKey(d => d.ContainerNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_CONTAINER_PO_T_CONTAINER");
            });

            modelBuilder.Entity<TContainerPoAssign>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_CONTAINER_O_ASSIGN");

                entity.ToTable("T_CONTAINER_PO_ASSIGN");

                entity.HasIndex(e => new { e.ContainerNo, e.Po, e.Lineid, e.Item }, "IX_T_CONTAINER_PO_ASSIGN");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.ContainerNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_NO");

                entity.Property(e => e.ErpProcess)
                    .HasColumnType("datetime")
                    .HasColumnName("ERP_Process");

                entity.Property(e => e.ErpUid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ERP_UID");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Lineid).HasColumnName("LINEID");

                entity.Property(e => e.Po)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TContainerRuntime>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_CONTAINER_RUNTIME");

                entity.HasIndex(e => e.Createdon, "IX_T_CONTAINER_RUNT_CRE");

                entity.HasIndex(e => e.Erpdocline, "IX_T_CONTAINER_RUNT_ERPLINE");

                entity.HasIndex(e => e.Ponumber, "IX_T_CONTAINER_RUNT_PO");

                entity.HasIndex(e => e.Container, "IX_T_CONTAINER_RUN_CONT");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.Alert)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ALERT");

                entity.Property(e => e.AlertSelected)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ALERT_SELECTED");

                entity.Property(e => e.Container)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INVOICE");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Lineid).HasColumnName("LINEID");

                entity.Property(e => e.Linenum).HasColumnName("LINENUM");

                entity.Property(e => e.Lock).HasColumnName("LOCK");

                entity.Property(e => e.PoStatus).HasColumnName("PO_STATUS");

                entity.Property(e => e.Ponumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PONUMBER");

                entity.Property(e => e.Processedon)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESSEDON");

                entity.Property(e => e.Qtydiff).HasColumnName("QTYDIFF");

                entity.Property(e => e.Qtyorder).HasColumnName("QTYORDER");

                entity.Property(e => e.Qtyother).HasColumnName("QTYOTHER");

                entity.Property(e => e.Qtypending).HasColumnName("QTYPENDING");

                entity.Property(e => e.Qtypo).HasColumnName("QTYPO");

                entity.Property(e => e.Qtypost).HasColumnName("QTYPOST");

                entity.Property(e => e.Qtyrecvd).HasColumnName("QTYRECVD");

                entity.Property(e => e.Qtytransit).HasColumnName("QTYTRANSIT");

                entity.Property(e => e.ResultMsg)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("RESULT_MSG");

                entity.Property(e => e.ResultStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RESULT_STATUS");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Unitid)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("UNITID");

                entity.HasOne(d => d.ContainerNavigation)
                    .WithMany(p => p.TContainerRuntimes)
                    .HasPrincipalKey(p => p.ContainerNo)
                    .HasForeignKey(d => d.Container)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_CONTAINER_RUNTIME_T_CONTAINER");
            });

            modelBuilder.Entity<TContainerUploadfile>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_CONTAINER_UPLOADFILE");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Container)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustID");

                entity.Property(e => e.CustomerRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Eancode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EANCode");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicePeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Po)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShipNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedVia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sonumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SONumber");

                entity.Property(e => e.StyleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("styleNo");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Xuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("xuid");
            });

            modelBuilder.Entity<TCountSchedule>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_COUNT_SCHEDULE");

                entity.HasIndex(e => e.Docid, "IX_T_COUNT_SCHEDULE")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.CountMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNT_METHOD");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Docid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.StarDate)
                    .HasColumnType("datetime")
                    .HasColumnName("STAR_DATE");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");
            });

            modelBuilder.Entity<TCountScheduleDay>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_COUNT_SCHEDULE_DAYS");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.CloseCyclePeriod).HasColumnName("CLOSE_CYCLE_PERIOD");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Day)
                    .HasColumnType("datetime")
                    .HasColumnName("DAY");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.ScheduleNavigation)
                    .WithMany(p => p.TCountScheduleDays)
                    .HasPrincipalKey(p => p.Docid)
                    .HasForeignKey(d => d.Schedule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_COUNT_SCHEDULE_DAYS_T_COUNT_SCHEDULE");
            });

            modelBuilder.Entity<TCountTask>(entity =>
            {
                entity.HasKey(e => e.Tasknumber);

                entity.ToTable("T_COUNT_TASK");

                entity.Property(e => e.Tasknumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TASKNUMBER");

                entity.Property(e => e.AllItems).HasColumnName("ALL_ITEMS");

                entity.Property(e => e.Confirmedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMEDBY");

                entity.Property(e => e.Confirmedon)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMEDON");

                entity.Property(e => e.CountType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNT_TYPE");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.DaySchedule)
                    .HasColumnType("datetime")
                    .HasColumnName("DAY_SCHEDULE");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.PostedbyErp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY_ERP");

                entity.Property(e => e.PostedbyWms)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY_WMS");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.PostedonErp)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON_ERP");

                entity.Property(e => e.PostedonWms)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON_WMS");

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.Rowid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWID");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TCountTasks)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_COUNT_TASK_m_estados");
            });

            modelBuilder.Entity<TCountTaskCurrstock>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_COUNT_TASK_CURRENTSTOCK");

                entity.ToTable("T_COUNT_TASK_CURRSTOCK");

                entity.HasIndex(e => e.Itemcode, "IX_T_COUNT_TASK_CURRSTOCK");

                entity.HasIndex(e => e.Tasknumber, "IX_T_COUNT_TASK_CURRSTOCK_1");

                entity.HasIndex(e => e.Bincode, "IX_T_COUNT_TASK_CURRSTOCK_2");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Bincode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Qtystock).HasColumnName("QTYSTOCK");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Tasknumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TASKNUMBER");

                entity.HasOne(d => d.TasknumberNavigation)
                    .WithMany(p => p.TCountTaskCurrstocks)
                    .HasForeignKey(d => d.Tasknumber)
                    .HasConstraintName("FK_T_COUNT_TASK_CURRSTOCK_T_COUNT_TASK");
            });

            modelBuilder.Entity<TCountTaskItem>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_COUNT_TASK_ITEM");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ITEMDESC");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Tasknumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TASKNUMBER");

                entity.HasOne(d => d.TasknumberNavigation)
                    .WithMany(p => p.TCountTaskItems)
                    .HasForeignKey(d => d.Tasknumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_COUNT_TASK_ITEM_T_COUNT_TASK");
            });

            modelBuilder.Entity<TCountTaskPosted>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_COUNT_TASK_ADJ");

                entity.ToTable("T_COUNT_TASK_POSTED");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.AdjType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ADJ_TYPE");

                entity.Property(e => e.Bincode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemdesc)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ITEMDESC");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.QtyCount).HasColumnName("QTY_COUNT");

                entity.Property(e => e.QtyErp).HasColumnName("QTY_ERP");

                entity.Property(e => e.QtyWms).HasColumnName("QTY_WMS");

                entity.Property(e => e.Qtyadj).HasColumnName("QTYADJ");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Tasknumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TASKNUMBER");

                entity.HasOne(d => d.TasknumberNavigation)
                    .WithMany(p => p.TCountTaskPosteds)
                    .HasForeignKey(d => d.Tasknumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_COUNT_TASK_POSTED_T_COUNT_TASK");
            });

            modelBuilder.Entity<TCountTaskRuntime>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_COUNT_TASK_RUNTIME");

                entity.HasIndex(e => new { e.Tasknumber, e.Bincode, e.Itemcode }, "IX_T_COUNT_TASK_RUNTIME");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.QtyCount).HasColumnName("QTY_COUNT");

                entity.Property(e => e.QtyExpected).HasColumnName("QTY_EXPECTED");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Tasknumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TASKNUMBER");

                entity.HasOne(d => d.TasknumberNavigation)
                    .WithMany(p => p.TCountTaskRuntimes)
                    .HasForeignKey(d => d.Tasknumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_COUNT_TASK_RUNTIME_T_COUNT_TASK");
            });

            modelBuilder.Entity<TEnviomail>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("t_enviomail");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("attachment");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechaenviado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaenviado");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Mfrom)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mfrom");

                entity.Property(e => e.Mto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mto");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.RowidEmpresa).HasColumnName("rowid_empresa");

                entity.Property(e => e.Sent)
                    .HasColumnName("sent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subject");

                entity.Property(e => e.UseBcc).HasColumnName("use_bcc");

                entity.Property(e => e.Usuariocreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");
            });

            modelBuilder.Entity<TErpdocHistory>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_ERPDOC_HISTORY");

                entity.HasIndex(e => e.Confirmdoc, "IX_T_ERPDOC_HIST_CONFIRM");

                entity.HasIndex(e => e.Regdate, "IX_T_ERPDOC_HIS_DATE");

                entity.HasIndex(e => e.Erpdoc, "IX_T_ERPDOC_HIS_ERPDOC");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpsite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ERPSITE");

                entity.Property(e => e.Error)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ERROR");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Process)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TErpdocProcessed>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_ERPDOC_QTY_ON_PROCESSED");

                entity.ToTable("T_ERPDOC_PROCESSED");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpdocline).HasColumnName("ERPDOCLINE");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Lot)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Qtyonbase).HasColumnName("QTYONBASE");

                entity.Property(e => e.Receiptdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RECEIPTDOC");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<TErpdocRuntime>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_ERPDOC_RUNTIME");

                entity.HasIndex(e => e.Erpdoc, "IX_T_ERPDOC_RUNTIME");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDBY");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("COMPLETEDON");

                entity.Property(e => e.ConfirmPickingDoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRM_PICKING_DOC");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Erpsite)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ERPSITE");

                entity.Property(e => e.Mailsent)
                    .HasColumnType("datetime")
                    .HasColumnName("MAILSENT");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Packedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKEDBY");

                entity.Property(e => e.Packedon)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKEDON");

                entity.Property(e => e.PackingBoxes)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKING_BOXES")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PackingNotes)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("PACKING_NOTES");

                entity.Property(e => e.PackingPallets)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKING_PALLETS")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PackingWeight).HasColumnName("PACKING_WEIGHT");

                entity.Property(e => e.Packingdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKINGDOC");

                entity.Property(e => e.Packstartby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKSTARTBY");

                entity.Property(e => e.Packstarton)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKSTARTON");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.Printedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINTEDBY");

                entity.Property(e => e.Printedon)
                    .HasColumnType("datetime")
                    .HasColumnName("PRINTEDON");

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");

                entity.Property(e => e.Processby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSBY");

                entity.Property(e => e.Processon)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESSON");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Releaseby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELEASEBY");

                entity.Property(e => e.Releaseon)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEON");

                entity.Property(e => e.ShippingCharges).HasColumnName("SHIPPING_CHARGES");

                entity.Property(e => e.ShippingChargesProcessed)
                    .HasColumnType("datetime")
                    .HasColumnName("SHIPPING_CHARGES_PROCESSED");

                entity.Property(e => e.TotalAmount).HasColumnName("TOTAL_AMOUNT");

                entity.Property(e => e.Trackingnumber)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TRACKINGNUMBER");
            });

            modelBuilder.Entity<TInventoryTrack>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_INVENTORY_TRACK");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Barcode).HasColumnName("BARCODE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Lot)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.Process)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");

                entity.Property(e => e.QtyRemovedby).HasColumnName("QTY_REMOVEDBY");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REASON_CODE");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.StockErpAvailable).HasColumnName("STOCK_ERP_AVAILABLE");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<TPackingPallet>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_PACKING_PALLET");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depth).HasColumnName("DEPTH");

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.NumberPieces).HasColumnName("NUMBER_PIECES");

                entity.Property(e => e.Packingdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKINGDOC");

                entity.Property(e => e.PalletNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PALLET_NUMBER");

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");

                entity.Property(e => e.Width).HasColumnName("WIDTH");
            });

            modelBuilder.Entity<TSetupItem>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_SETUP_ITEM");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.BinAssigned)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BIN_ASSIGNED");

                entity.Property(e => e.CountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COUNT_TYPE")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.LastCount)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_COUNT");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<TSetupShipcut>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_SETUP_SHIPVIA");

                entity.ToTable("T_SETUP_SHIPCUT");

                entity.HasIndex(e => new { e.CutOperator, e.CutTime, e.AddDays }, "IX_T_SETUP_SHIPCUT")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.AddDays).HasColumnName("ADD_DAYS");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.CutCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CUT_CODE")
                    .HasDefaultValueSql("('GROUND')");

                entity.Property(e => e.CutOperator)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CUT_OPERATOR");

                entity.Property(e => e.CutTime).HasColumnName("CUT_TIME");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");
            });

            modelBuilder.Entity<TSetupShipcutShipvium>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_SHIPVIA_SC");

                entity.ToTable("T_SETUP_SHIPCUT_SHIPVIA");

                entity.HasIndex(e => e.ShipviaCode, "IX_T_SETUP_SHIPCUT_SHIPVIA")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.ShipcutCode).HasColumnName("SHIPCUT_CODE");

                entity.Property(e => e.ShipviaCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SHIPVIA_CODE");
            });

            modelBuilder.Entity<TTaskAssign>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_T_PICKER_TASK");

                entity.ToTable("T_TASK_ASSIGN");

                entity.HasIndex(e => new { e.Process, e.Docid }, "IX_T_PICKER_TASK");

                entity.HasIndex(e => e.Picker, "IX_T_PICKER_TASK_1");

                entity.HasIndex(e => e.Createdon, "IX_T_TASK_ASSIGN");

                entity.HasIndex(e => e.Guid, "IX_T_TASK_ASSIGN_1");

                entity.HasIndex(e => e.Completedon, "IX_T_TASK_ASSIGN_2");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDBY");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("COMPLETEDON");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Docid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUID");

                entity.Property(e => e.Picker)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PICKER");

                entity.Property(e => e.Process)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.ReopenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REOPEN_DATE");

                entity.Property(e => e.ReopenOrder).HasColumnName("REOPEN_ORDER");

                entity.Property(e => e.SeqDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SEQ_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.TaskAccountid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TASK_ACCOUNTID");

                entity.Property(e => e.TaskAccountname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TASK_ACCOUNTNAME");
            });

            modelBuilder.Entity<TTaskAssignSkip>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_TASK_ASSIGN_SKIP");

                entity.HasIndex(e => new { e.Docid, e.Item }, "IX_T_TASK_ASSIGN_SKIP");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Docid)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_UPDATE");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Skip).HasColumnName("SKIP");
            });

            modelBuilder.Entity<TTransfer>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_TRANSFERS");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Docid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Sessionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.SiteDest)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE_DEST");

                entity.Property(e => e.SiteOri)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ORI");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");
            });

            modelBuilder.Entity<TTransfersItem>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("T_TRANSFERS_ITEMS");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Docid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Lot)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.QuantityRemoved).HasColumnName("QUANTITY_REMOVED");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Removedon)
                    .HasColumnType("datetime")
                    .HasColumnName("REMOVEDON");

                entity.Property(e => e.Sessionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.SiteDest)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE_DEST");

                entity.Property(e => e.SiteOri)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ORI");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<TemporaryFileUpload>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("TEMPORARY_FILE_UPLOAD");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.C1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C10)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C11)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C12)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C13)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C14)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C15)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C16)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C17)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C18)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C19)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C20)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C21)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C22)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C23)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C24)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C25)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C26)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C27)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C28)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C29)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C30)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C7)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C8)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C9)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErpDocument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ERP_Document");

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Xuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("xuid");
            });

            modelBuilder.Entity<TmpContainerV3>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("TMP_CONTAINER_V3");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.AlertNotes)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AlertType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.C1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C10)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C11)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C12)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C13)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C14)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C15)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C16)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C17)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C7)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C8)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C9)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Container)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CreatedBY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineAction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.QtyNav).HasColumnName("QtyNAV");

                entity.Property(e => e.QtyOnPo).HasColumnName("QtyOnPO");

                entity.Property(e => e.ViewProcess).HasColumnType("datetime");

                entity.Property(e => e.Xuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpContainerV3Distribution>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("TMP_CONTAINER_V3_DISTRIBUTION");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.ExcelRowId).HasColumnName("Excel_RowID");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Po)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("regdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Step)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Xuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpErpdocStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_ERPDOC_STOCK");

                entity.HasIndex(e => e.Erpdoc, "IX_TMP_ERPDOC_STOCK_POINTS");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stock).HasColumnName("STOCK");
            });

            modelBuilder.Entity<TmpErpdocStockItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_ERPDOC_STOCK_ITEM");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stock).HasColumnName("STOCK");
            });

            modelBuilder.Entity<V2ApiDocumentWork>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_z_api_document_work");

                entity.ToTable("v2_api_document_work");

                entity.HasIndex(e => e.DocNumber, "IX_v2_api_docnumber");

                entity.HasIndex(e => e.Credate, "IX_v2_api_document_credate");

                entity.HasIndex(e => e.ItemId, "IX_v2_api_document_work");

                entity.HasIndex(e => e.Upc, "IX_v2_api_document_work_1");

                entity.HasIndex(e => new { e.DocNumber, e.InternalId }, "IX_v2_api_erp_unique")
                    .IsUnique();

                entity.HasIndex(e => e.InternalId, "IX_v2_api_internalid");

                entity.HasIndex(e => e.DocNumber, "IX_v2_doc_id");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Credate)
                    .HasColumnType("datetime")
                    .HasColumnName("credate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creuser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("creuser")
                    .HasDefaultValueSql("('SYNC')");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doc_number");

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doc_type");

                entity.Property(e => e.InternalId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("internal_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JsonData1)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("json_data1");

                entity.Property(e => e.JsonData2)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("json_data2");

                entity.Property(e => e.Moddate)
                    .HasColumnType("datetime")
                    .HasColumnName("moddate");

                entity.Property(e => e.Moduser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("moduser");

                entity.Property(e => e.ProcessCompletedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("process_completed_on");

                entity.Property(e => e.ProcessReadedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("process_readed_on");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("site")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("source")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusNotes)
                    .IsUnicode(false)
                    .HasColumnName("status_notes");

                entity.Property(e => e.Tags)
                    .IsUnicode(false)
                    .HasColumnName("tags");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("upc")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<V2ApiIntegrationControl>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_api_integration_control");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("action");

                entity.Property(e => e.AllowResend).HasColumnName("allow_resend");

                entity.Property(e => e.AllowReversion).HasColumnName("allow_reversion");

                entity.Property(e => e.BatchGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch_guid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("direction");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.IntegrationType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("integration_type");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedon");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.Process)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("process");

                entity.Property(e => e.Refnumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("refnumber");

                entity.Property(e => e.RequestData)
                    .HasColumnType("text")
                    .HasColumnName("request_data");

                entity.Property(e => e.ResponseData)
                    .HasColumnType("text")
                    .HasColumnName("response_data");

                entity.Property(e => e.SetupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_code");

                entity.Property(e => e.Site)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<V2ApiSiesaConector>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_ws_conector_unoee");

                entity.ToTable("v2_api_siesa_conector");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.Inicio).HasColumnName("inicio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Obligatorio)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("obligatorio");

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasColumnName("observaciones");

                entity.Property(e => e.Subtipo).HasColumnName("subtipo");

                entity.Property(e => e.Tamano).HasColumnName("tamano");

                entity.Property(e => e.Tipodato)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipodato");

                entity.Property(e => e.Tiporeg).HasColumnName("tiporeg");

                entity.Property(e => e.ValorFijo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("valor_fijo");

                entity.Property(e => e.ValorVariable)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("valor_variable");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<V2ApiStock>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_api_stock");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.LoteSn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lote_sn");

                entity.Property(e => e.Processdate)
                    .HasColumnType("datetime")
                    .HasColumnName("processdate");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("regdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("site");
            });

            modelBuilder.Entity<V2MasterConfig>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_master_config");

                entity.HasIndex(e => e.SetupCode, "IX_v2_master_config")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.ConfigClass)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("config_class")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Params)
                    .IsUnicode(false)
                    .HasColumnName("params");

                entity.Property(e => e.SetupCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_code");

                entity.Property(e => e.Site)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UiControlList)
                    .IsUnicode(false)
                    .HasColumnName("ui_control_list");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("value")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<V2MasterConnection>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_master_connection");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Cnnstring)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("cnnstring");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Site)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<V2MasterDeliveryCity>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_master_delivery_city");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CodeDane)
                    .HasMaxLength(10)
                    .HasColumnName("code_dane")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeTcc)
                    .HasMaxLength(10)
                    .HasColumnName("code_tcc")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeTransprensa)
                    .HasMaxLength(10)
                    .HasColumnName("code_transprensa")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<V2MasterDeliveryService>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_master_delivery_service");

                entity.HasIndex(e => new { e.CompanyCode, e.ServiceCode }, "IX_v2_master_delivery_service")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("company_code");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IndActive)
                    .HasColumnName("ind_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IndPackingConsolidated).HasColumnName("ind_packing_consolidated");

                entity.Property(e => e.IndPackinglist).HasColumnName("ind_packinglist");

                entity.Property(e => e.IndPkglabels).HasColumnName("ind_pkglabels");

                entity.Property(e => e.RowidPrinterPackinglist).HasColumnName("rowid_printer_packinglist");

                entity.Property(e => e.RowidPrinterPkglabels).HasColumnName("rowid_printer_pkglabels");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("service_code");

                entity.Property(e => e.SetupAttibutesScheme)
                    .IsUnicode(false)
                    .HasColumnName("setup_attibutes_scheme")
                    .HasComment("JSON with attributes value");

                entity.Property(e => e.SetupAttibutesValue)
                    .IsUnicode(false)
                    .HasColumnName("setup_attibutes_value")
                    .HasComment("JSON with attributes value");

                entity.Property(e => e.SetupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_name");

                entity.HasOne(d => d.RowidPrinterPackinglistNavigation)
                    .WithMany(p => p.V2MasterDeliveryServiceRowidPrinterPackinglistNavigations)
                    .HasForeignKey(d => d.RowidPrinterPackinglist)
                    .HasConstraintName("FK_v2_master_delivery_service_v2_master_connection");

                entity.HasOne(d => d.RowidPrinterPkglabelsNavigation)
                    .WithMany(p => p.V2MasterDeliveryServiceRowidPrinterPkglabelsNavigations)
                    .HasForeignKey(d => d.RowidPrinterPkglabels)
                    .HasConstraintName("FK_v2_master_delivery_service_v2_master_connection1");
            });

            modelBuilder.Entity<V2MasterMetalist>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_v2_master_meta");

                entity.ToTable("v2_master_metalist");

                entity.HasIndex(e => new { e.ClassCode, e.MasterKey }, "IX_v2_master_metalist")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.ClassCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("class_code");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MasterKey)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("master_key");

                entity.Property(e => e.MasterValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("master_value");

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<V2MasterPackage>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_master_package");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DimHeight).HasColumnName("dim_height");

                entity.Property(e => e.DimLength).HasColumnName("dim_length");

                entity.Property(e => e.DimVolume).HasColumnName("dim_volume");

                entity.Property(e => e.DimWidth).HasColumnName("dim_width");

                entity.Property(e => e.IndActive)
                    .HasColumnName("ind_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IndAllowChilds).HasColumnName("ind_allow_childs");

                entity.Property(e => e.IndAllowEdit).HasColumnName("ind_allow_edit");

                entity.Property(e => e.MaxWeight).HasColumnName("max_weight");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedon");

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("package_name");
            });

            modelBuilder.Entity<V2MasterVehicle>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_master_vehicle");

                entity.HasIndex(e => e.Tag, "IX_v2_master_vehicle")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("modifiedby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("tag");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("type_code");
            });

            modelBuilder.Entity<V2NotificacionesAutomatica>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_v2_l_notificaciones_automaticas");

                entity.ToTable("v2_notificaciones_automaticas");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CodNotificacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod_notificacion");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.IndActivo)
                    .HasColumnName("ind_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastExec)
                    .HasColumnType("datetime")
                    .HasColumnName("last_exec");

                entity.Property(e => e.MinutosFreq).HasColumnName("minutos_freq");

                entity.Property(e => e.Mto)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("mto");

                entity.Property(e => e.NextExec)
                    .HasColumnType("datetime")
                    .HasColumnName("next_exec");

                entity.Property(e => e.Procedimiento)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("procedimiento");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion")
                    .HasDefaultValueSql("('AG3')");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");
            });

            modelBuilder.Entity<V2OpeDeliveryQuote>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_v2_ope_delivery_qoute");

                entity.ToTable("v2_ope_delivery_quote");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CodMoneda)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_moneda");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("company_code");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeclaredValue).HasColumnName("declared_value");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.FreightValue).HasColumnName("freight_value");

                entity.Property(e => e.IndError).HasColumnName("ind_error");

                entity.Property(e => e.Msg)
                    .HasColumnType("text")
                    .HasColumnName("msg");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("service_code");
            });

            modelBuilder.Entity<V2OpeDeliveryTask>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_ope_delivery_task");

                entity.HasIndex(e => e.Guid, "IX_v2_ope_delivery_task")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("completedby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("completedon");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deliverystartby)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("deliverystartby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Deliverystarton)
                    .HasColumnType("datetime")
                    .HasColumnName("deliverystarton");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("guid");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.RowidUserDriver).HasColumnName("rowid_user_driver");

                entity.Property(e => e.RowidVehicle).HasColumnName("rowid_vehicle");

                entity.Property(e => e.TotalPackages).HasColumnName("total_packages");

                entity.HasOne(d => d.RowidVehicleNavigation)
                    .WithMany(p => p.V2OpeDeliveryTasks)
                    .HasForeignKey(d => d.RowidVehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_v2_ope_delivery_task_v2_master_vehicle");
            });

            modelBuilder.Entity<V2OpeDeliveryTaskDetail>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_ope_delivery_task_detail");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("completedby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("completedon");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.ReceivedSupport)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("received_support");

                entity.Property(e => e.Receivedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("receivedby");

                entity.Property(e => e.RowidDeliveryTask).HasColumnName("rowid_delivery_task");

                entity.Property(e => e.RowidPacking).HasColumnName("rowid_packing");

                entity.HasOne(d => d.RowidDeliveryTaskNavigation)
                    .WithMany(p => p.V2OpeDeliveryTaskDetails)
                    .HasForeignKey(d => d.RowidDeliveryTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_v2_ope_delivery_task_detail_v2_ope_delivery_task");

                entity.HasOne(d => d.RowidPackingNavigation)
                    .WithMany(p => p.V2OpeDeliveryTaskDetails)
                    .HasForeignKey(d => d.RowidPacking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_v2_ope_delivery_task_detail_T_BARCODE_PACKING");
            });

            modelBuilder.Entity<V2OpeDeviceSession>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_v2_device_session");

                entity.ToTable("v2_ope_device_session");

                entity.HasIndex(e => new { e.ProcessId, e.DeviceId }, "IX_v2_ope_device_session")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Credate)
                    .HasColumnType("datetime")
                    .HasColumnName("credate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("device_id");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.Lastread)
                    .HasColumnType("datetime")
                    .HasColumnName("lastread");

                entity.Property(e => e.ProcessId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("process_id");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("session_id");
            });

            modelBuilder.Entity<V2OpeDocument>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK__v2_docum__97BD02EB719DE814");

                entity.ToTable("v2_ope_document");

                entity.HasIndex(e => e.Docnumber, "IX_v2_ope_document")
                    .IsUnique();

                entity.HasIndex(e => e.AssignedTo, "IX_v2_ope_document_1");

                entity.HasIndex(e => e.Deliveredon, "IX_v2_ope_document_2");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assigned_to");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDBY");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("COMPLETEDON");

                entity.Property(e => e.ConfirmPickingDoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRM_PICKING_DOC");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Deliveredby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVEREDBY");

                entity.Property(e => e.Deliveredon)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVEREDON");

                entity.Property(e => e.DeliveryCurrentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("delivery_current_status");

                entity.Property(e => e.DeliveryLabels)
                    .HasColumnType("text")
                    .HasColumnName("delivery_labels");

                entity.Property(e => e.DeliveryPackinglist)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("delivery_packinglist");

                entity.Property(e => e.DeliveryResponse)
                    .HasColumnType("text")
                    .HasColumnName("delivery_response");

                entity.Property(e => e.DeliveryRowidService).HasColumnName("delivery_rowid_service");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.IndActive)
                    .HasColumnName("ind_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IndEngage)
                    .HasColumnName("ind_engage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IndLock)
                    .HasColumnName("ind_lock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IndPriority).HasColumnName("ind_priority");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("invoice");

                entity.Property(e => e.Mailsent)
                    .HasColumnType("datetime")
                    .HasColumnName("MAILSENT");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Packedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKEDBY");

                entity.Property(e => e.Packedon)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKEDON");

                entity.Property(e => e.PackingBoxes)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKING_BOXES")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PackingNotes)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("PACKING_NOTES");

                entity.Property(e => e.PackingPallets)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKING_PALLETS")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PackingWeight).HasColumnName("PACKING_WEIGHT");

                entity.Property(e => e.Packingdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKINGDOC");

                entity.Property(e => e.Packstartby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKSTARTBY");

                entity.Property(e => e.Packstarton)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKSTARTON");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.Printedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINTEDBY");

                entity.Property(e => e.Printedon)
                    .HasColumnType("datetime")
                    .HasColumnName("PRINTEDON");

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");

                entity.Property(e => e.Processby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSBY");

                entity.Property(e => e.Processon)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESSON");

                entity.Property(e => e.ReasonEngage)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("reason_engage");

                entity.Property(e => e.ReasonLock)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("reason_lock");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Releaseby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELEASEBY");

                entity.Property(e => e.Releaseon)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEON");

                entity.Property(e => e.ShippingCharges).HasColumnName("SHIPPING_CHARGES");

                entity.Property(e => e.ShippingChargesProcessed)
                    .HasColumnType("datetime")
                    .HasColumnName("SHIPPING_CHARGES_PROCESSED");

                entity.Property(e => e.Site)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusNotes)
                    .HasColumnType("text")
                    .HasColumnName("status_notes");

                entity.Property(e => e.TotalAmount).HasColumnName("TOTAL_AMOUNT");

                entity.Property(e => e.Trackingnumber)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TRACKINGNUMBER");

                entity.HasOne(d => d.DeliveryRowidServiceNavigation)
                    .WithMany(p => p.V2OpeDocuments)
                    .HasForeignKey(d => d.DeliveryRowidService)
                    .HasConstraintName("FK_v2_ope_document_v2_master_delivery_service");
            });

            modelBuilder.Entity<V2OpeDocumentLog>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK__v2_docum__97BD02EBEAB557DD");

                entity.ToTable("v2_ope_document_log");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTION");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.Error)
                    .HasColumnType("text")
                    .HasColumnName("ERROR");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("NOTES");

                entity.Property(e => e.Process)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<V2OpeDocumentPackage>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_ope_document_package");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryGuid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("delivery_guid");

                entity.Property(e => e.Deliveryby)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("deliveryby");

                entity.Property(e => e.Deliveryon)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryon");

                entity.Property(e => e.DimHeight).HasColumnName("dim_height");

                entity.Property(e => e.DimLength).HasColumnName("dim_length");

                entity.Property(e => e.DimVolume).HasColumnName("dim_volume");

                entity.Property(e => e.DimVolweight)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("dim_volweight");

                entity.Property(e => e.DimWidth).HasColumnName("dim_width");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.PackageNum).HasColumnName("package_num");

                entity.Property(e => e.Pieces).HasColumnName("pieces");

                entity.Property(e => e.RowidPackageType).HasColumnName("rowid_package_type");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<V2OpeResource>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_ope_resources");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.EntityRowid)
                    .HasMaxLength(10)
                    .HasColumnName("entity_rowid")
                    .IsFixedLength(true);

                entity.Property(e => e.EntityType).HasColumnName("entity_type");

                entity.Property(e => e.ProcessId).HasColumnName("process_id");
            });

            modelBuilder.Entity<V2WmsConfig>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("v2_wms_config");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.EnSetupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("en_setup_name");

                entity.Property(e => e.EsSetupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("es_setup_name");

                entity.Property(e => e.IndCustomerLevel).HasColumnName("ind_customer_level");

                entity.Property(e => e.IndSiteLevel).HasColumnName("ind_site_level");

                entity.Property(e => e.IndUserLevel).HasColumnName("ind_user_level");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.ProcessId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("process_id");

                entity.Property(e => e.SetupCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_code");

                entity.Property(e => e.UiControl)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ui_control");
            });

            modelBuilder.Entity<V2WmsDeliveryCompany>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_v2_master_delivery_company");

                entity.ToTable("v2_wms_delivery_company");

                entity.HasIndex(e => new { e.CompanyCode, e.ServiceCode }, "IX_v2_wms_delivery_company")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_code");

                entity.Property(e => e.AccountPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_password");

                entity.Property(e => e.AccountUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_username");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("company_code");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("country_code")
                    .HasDefaultValueSql("('COL')")
                    .IsFixedLength(true);

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("('WMS')");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("createdon")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GuideEndpoint)
                    .IsUnicode(false)
                    .HasColumnName("guide_endpoint");

                entity.Property(e => e.IndActivo).HasColumnName("ind_activo");

                entity.Property(e => e.IndManual).HasColumnName("ind_manual");

                entity.Property(e => e.IndPackingConsolidated).HasColumnName("ind_packing_consolidated");

                entity.Property(e => e.IndPackinglist).HasColumnName("ind_packinglist");

                entity.Property(e => e.IndPkglabels).HasColumnName("ind_pkglabels");

                entity.Property(e => e.LabelsEndpoint)
                    .IsUnicode(false)
                    .HasColumnName("labels_endpoint");

                entity.Property(e => e.QuoteEndpoint)
                    .IsUnicode(false)
                    .HasColumnName("quote_endpoint");

                entity.Property(e => e.QuoteEndpoint2)
                    .IsUnicode(false)
                    .HasColumnName("quote_endpoint2");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("service_code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service_name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TrackingEndpoint)
                    .IsUnicode(false)
                    .HasColumnName("tracking_endpoint");
            });

            modelBuilder.Entity<V2WmsManualDeliveryCompany>(entity =>
            {
                entity.HasKey(e => e.Company);

                entity.ToTable("v2_wms_manual_delivery_company");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.IndActivo)
                    .HasColumnName("ind_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowid");
            });

            modelBuilder.Entity<VwContainerFileLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CONTAINER_FILE_LINE");

                entity.Property(e => e.CustId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustID");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Invoice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Po)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.ShipNo)
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.StyleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("styleNo");
            });

            modelBuilder.Entity<VwDeliveryErpDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DELIVERY_ERP_DOCS");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.CityState)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("CITY_STATE");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("completedby");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("completedon");

                entity.Property(e => e.ContactInfo)
                    .HasMaxLength(4000)
                    .HasColumnName("CONTACT_INFO");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("CONTACT_NAME");

                entity.Property(e => e.Deliveredby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deliveredby");

                entity.Property(e => e.Deliveredon)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveredon");

                entity.Property(e => e.DeliveryLabels)
                    .HasColumnType("text")
                    .HasColumnName("delivery_labels");

                entity.Property(e => e.DeliveryPackinglist)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("delivery_packinglist");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.FreightValue).HasColumnName("freight_value");

                entity.Property(e => e.Invoiceid)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("INVOICEID");

                entity.Property(e => e.Note)
                    .HasMaxLength(4000)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Numlines)
                    .HasMaxLength(107)
                    .IsUnicode(false)
                    .HasColumnName("NUMLINES");

                entity.Property(e => e.Numpackages).HasColumnName("NUMPACKAGES");

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasColumnType("datetime")
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.Releaseby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELEASEBY");

                entity.Property(e => e.Releaseon)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEON");

                entity.Property(e => e.Service)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .HasColumnName("SHIPPING_ADDRESS");

                entity.Property(e => e.Site)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.TrackingNo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TRACKING_NO");

                entity.Property(e => e.TrackingUrl)
                    .HasMaxLength(1039)
                    .IsUnicode(false)
                    .HasColumnName("TRACKING_URL");

                entity.Property(e => e.Volweight)
                    .HasMaxLength(4000)
                    .HasColumnName("VOLWEIGHT");

                entity.Property(e => e.Weight)
                    .HasMaxLength(4000)
                    .HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<VwItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ITEM");

                entity.Property(e => e.IsKit).HasColumnName("IS_KIT");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.RequireSn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_SN");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.Vendorid)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VENDORID");
            });

            modelBuilder.Entity<VwItemUom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ITEM_UOM");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Qtybase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("QTYBASE");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UOM");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<VwKitLinePending>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KIT_LINE_PENDING");

                entity.Property(e => e.Docid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.FormulaQty).HasColumnName("FORMULA_QTY");

                entity.Property(e => e.ItemcodeComponent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_COMPONENT");

                entity.Property(e => e.ItemcodeKit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE_KIT");

                entity.Property(e => e.ItemnameComponent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME_COMPONENT");

                entity.Property(e => e.QtyInStock).HasColumnName("QTY_IN_STOCK");

                entity.Property(e => e.QtyRequired).HasColumnName("QTY_REQUIRED");

                entity.Property(e => e.QtyToPick).HasColumnName("QTY_TO_PICK");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");
            });

            modelBuilder.Entity<VwReceivingErpDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_RECEIVING_ERP_DOCS");

                entity.Property(e => e.Accountid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ArrivedOn).HasColumnType("datetime");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(20)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.NavStatus).HasColumnName("NAV_Status");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.NumOrd).HasColumnName("numOrd");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Wmscustom)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("WMSCustom")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<VwReceivingErpDocsLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_RECEIVING_ERP_DOCS_LINES");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(20)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctypeid).HasColumnName("DOCTYPEID");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemname)
                    .HasMaxLength(4000)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Lineid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("LINEID");

                entity.Property(e => e.QtyOutstanding)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_OUTSTANDING");

                entity.Property(e => e.QtyToErp).HasColumnName("QTY_TO_ERP");

                entity.Property(e => e.QtyToReceive)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_TO_RECEIVE");

                entity.Property(e => e.Qtyonprocess).HasColumnName("QTYONPROCESS");

                entity.Property(e => e.Qtyorder)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYORDER");

                entity.Property(e => e.Qtypending)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYPENDING");

                entity.Property(e => e.Qtyreceived)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYRECEIVED");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Unitid)
                    .HasMaxLength(10)
                    .HasColumnName("UNITID");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(23)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<VwShippingErpCommentLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_COMMENT_LINES");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(80)
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Docid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DOCID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Ppl).HasColumnName("PPL");

                entity.Property(e => e.Ppt).HasColumnName("PPT");
            });

            modelBuilder.Entity<VwShippingErpDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_DOCS");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname).HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.Addresstype)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESSTYPE");

                entity.Property(e => e.Addrline1).HasColumnName("ADDRLINE1");

                entity.Property(e => e.Addrline2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADDRLINE2");

                entity.Property(e => e.Addrline3)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADDRLINE3");

                entity.Property(e => e.Agentcode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AGENTCODE");

                entity.Property(e => e.Agentservice)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("AGENTSERVICE");

                entity.Property(e => e.AlternSite).HasColumnName("altern_site");

                entity.Property(e => e.Backorder)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BACKORDER");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_TYPE");

                entity.Property(e => e.City).HasColumnName("CITY");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Completedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDBY");

                entity.Property(e => e.Completedon)
                    .HasColumnType("datetime")
                    .HasColumnName("COMPLETEDON");

                entity.Property(e => e.CompletedonText)
                    .HasMaxLength(515)
                    .IsUnicode(false)
                    .HasColumnName("completedon_text");

                entity.Property(e => e.Contact).HasColumnName("CONTACT");

                entity.Property(e => e.Country).HasColumnName("COUNTRY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Customerpo)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("CUSTOMERPO");

                entity.Property(e => e.Deliveredby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVEREDBY");

                entity.Property(e => e.Deliveredon)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVEREDON");

                entity.Property(e => e.Docdate)
                    .HasColumnType("date")
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docentry)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("DOCENTRY");

                entity.Property(e => e.Docentry2)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("DOCENTRY_2");

                entity.Property(e => e.Docid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Docsubtype)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("DOCSUBTYPE");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.Emailcontact)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMAILCONTACT");

                entity.Property(e => e.Freightacc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FREIGHTACC");

                entity.Property(e => e.ImpAddress)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_ADDRESS");

                entity.Property(e => e.ImpCity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_CITY");

                entity.Property(e => e.ImpCountry)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_COUNTRY");

                entity.Property(e => e.ImpName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_NAME");

                entity.Property(e => e.ImpPhone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_PHONE");

                entity.Property(e => e.ImpState)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_STATE");

                entity.Property(e => e.ImpZip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_ZIP");

                entity.Property(e => e.IndCancel).HasColumnName("ind_cancel");

                entity.Property(e => e.IndConfirm).HasColumnName("ind_confirm");

                entity.Property(e => e.IndErp).HasColumnName("ind_erp");

                entity.Property(e => e.IndPacking).HasColumnName("ind_packing");

                entity.Property(e => e.IndPicking).HasColumnName("ind_picking");

                entity.Property(e => e.IndPriority).HasColumnName("ind_priority");

                entity.Property(e => e.IndRollbackConfirm).HasColumnName("ind_rollback_confirm");

                entity.Property(e => e.IndRollbackErp).HasColumnName("ind_rollback_erp");

                entity.Property(e => e.IndRollbackPacking).HasColumnName("ind_rollback_packing");

                entity.Property(e => e.IndRollbackPicking).HasColumnName("ind_rollback_picking");

                entity.Property(e => e.InsideDeliv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INSIDE_DELIV");

                entity.Property(e => e.Invoiceid)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("INVOICEID");

                entity.Property(e => e.LiftDeliv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LIFT_DELIV");

                entity.Property(e => e.Note)
                    .HasMaxLength(4000)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Numlines)
                    .HasMaxLength(107)
                    .IsUnicode(false)
                    .HasColumnName("NUMLINES");

                entity.Property(e => e.Numpending).HasColumnName("NUMPENDING");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORI_DOC");

                entity.Property(e => e.Oversize)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OVERSIZE");

                entity.Property(e => e.Packedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKEDBY");

                entity.Property(e => e.Packedon)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKEDON");

                entity.Property(e => e.PackedonText)
                    .HasMaxLength(515)
                    .IsUnicode(false)
                    .HasColumnName("packedon_text");

                entity.Property(e => e.Packer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKER");

                entity.Property(e => e.Paymethod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYMETHOD");

                entity.Property(e => e.Payterm)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYTERM");

                entity.Property(e => e.Phone).HasColumnName("PHONE");

                entity.Property(e => e.Picker)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PICKER");

                entity.Property(e => e.ProcessStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.Progress)
                    .HasColumnType("numeric(5, 1)")
                    .HasColumnName("PROGRESS");

                entity.Property(e => e.ProgressPacking).HasColumnName("PROGRESS_PACKING");

                entity.Property(e => e.Promiseddate).HasColumnName("PROMISEDDATE");

                entity.Property(e => e.Releasedate)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEDATE");

                entity.Property(e => e.Reqdelivery)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQDELIVERY");

                entity.Property(e => e.SalesrepMail)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SALESREP_MAIL");

                entity.Property(e => e.ServAgentCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERV_AGENT_CODE");

                entity.Property(e => e.Shiptoname).HasColumnName("SHIPTONAME");

                entity.Property(e => e.SignatureReq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIGNATURE_REQ");

                entity.Property(e => e.Site)
                    .HasMaxLength(4000)
                    .HasColumnName("SITE");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.StatusId1).HasColumnName("status_id");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Tags)
                    .IsUnicode(false)
                    .HasColumnName("tags");

                entity.Property(e => e.Totalprice).HasColumnName("TOTALPRICE");

                entity.Property(e => e.Wbroker)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WBROKER");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<VwShippingErpDocsBackorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_DOCS_BACKORDER");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.OriDoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<VwShippingErpDocsLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_DOCS_LINES");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Docdate)
                    .HasColumnType("date")
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.HasStock).HasColumnName("HAS_STOCK");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemVolume)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("ITEM_VOLUME");

                entity.Property(e => e.ItemWeight)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("ITEM_WEIGHT");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemname)
                    .HasMaxLength(4000)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.LinePrice).HasColumnName("LINE_PRICE");

                entity.Property(e => e.LineWeight)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("LINE_WEIGHT");

                entity.Property(e => e.Lineid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINEID");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORI_DOC");

                entity.Property(e => e.Qtyonprocess).HasColumnName("QTYONPROCESS");

                entity.Property(e => e.Qtyorder)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYORDER");

                entity.Property(e => e.Qtypending)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYPENDING");

                entity.Property(e => e.Qtyshipped).HasColumnName("QTYSHIPPED");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.RequireSn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_SN");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");

                entity.Property(e => e.Unitid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UNITID");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<VwShippingErpDocsLinesStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_DOCS_LINES_STOCK");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID");

                entity.Property(e => e.HasStock).HasColumnName("HAS_STOCK");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");
            });

            modelBuilder.Entity<VwShippingErpDocsOpen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_DOCS_OPEN");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address1)
                    .HasMaxLength(101)
                    .HasColumnName("ADDRESS1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address2)
                    .HasMaxLength(84)
                    .HasColumnName("ADDRESS2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addrline1)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addrline2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AGENTCODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentservice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AGENTSERVICE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("CITY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("COUNTRY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Customerpo)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("CUSTOMERPO")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("EMAIL")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Freightacc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("FREIGHTACC")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ProcessStatus).HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.Releasedate)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEDATE");

                entity.Property(e => e.Reqdelivery)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQDELIVERY");

                entity.Property(e => e.SalesrepMail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SALESREP_MAIL")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ServAgentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SERV_AGENT_CODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoaddress)
                    .HasMaxLength(50)
                    .HasColumnName("SHIPTOADDRESS")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoname)
                    .HasMaxLength(4000)
                    .HasColumnName("SHIPTONAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .HasColumnName("STATE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .HasColumnName("ZIP")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<VwShippingErpDocsStarship>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_DOCS_STARSHIP");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address1)
                    .HasMaxLength(101)
                    .HasColumnName("ADDRESS1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address2)
                    .HasMaxLength(84)
                    .HasColumnName("ADDRESS2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addresstype).HasColumnName("ADDRESSTYPE");

                entity.Property(e => e.Addrline1)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addrline2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AGENTCODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentservice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AGENTSERVICE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Backorder)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BACKORDER");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_TYPE");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("CITY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("COUNTRY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createuser)
                    .HasMaxLength(4000)
                    .HasColumnName("CREATEUSER")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Customerpo)
                    .HasMaxLength(4000)
                    .HasColumnName("CUSTOMERPO")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(31)
                    .HasColumnName("DOCNUMBER")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("EMAIL")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Emailcontact)
                    .HasMaxLength(150)
                    .HasColumnName("EMAILCONTACT")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Freightacc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("FREIGHTACC")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpAddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("IMP_ADDRESS")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpCity)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("IMP_CITY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("IMP_COUNTRY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("IMP_NAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IMP_PHONE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpState)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IMP_STATE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ImpZip)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IMP_ZIP")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.InsideDeliv).HasColumnName("INSIDE_DELIV");

                entity.Property(e => e.LiftDeliv).HasColumnName("LIFT_DELIV");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Oversize).HasColumnName("OVERSIZE");

                entity.Property(e => e.Paymethod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PAYMETHOD")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Payterm)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PAYTERM")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ProcessStatus).HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.Promiseddate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROMISEDDATE");

                entity.Property(e => e.Releasedate)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEDATE");

                entity.Property(e => e.Reqdelivery)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQDELIVERY");

                entity.Property(e => e.SalesrepMail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SALESREP_MAIL")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ServAgentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SERV_AGENT_CODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoaddress)
                    .HasMaxLength(50)
                    .HasColumnName("SHIPTOADDRESS")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoname)
                    .HasMaxLength(4000)
                    .HasColumnName("SHIPTONAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.SignatureReq).HasColumnName("SIGNATURE_REQ");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .HasColumnName("STATE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Totalprice)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("TOTALPRICE");

                entity.Property(e => e.Wbroker)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("WBROKER")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .HasColumnName("ZIP")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<VwShippingErpDocsTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_DOCS_TIMES");

                entity.Property(e => e.AssignedTo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assigned_to");

                entity.Property(e => e.Completedby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDBY");

                entity.Property(e => e.Completedon)
                    .HasMaxLength(515)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETEDON");

                entity.Property(e => e.Deliveredby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVEREDBY");

                entity.Property(e => e.Deliveredon)
                    .HasMaxLength(515)
                    .IsUnicode(false)
                    .HasColumnName("DELIVEREDON");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("docnumber");

                entity.Property(e => e.Packedby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACKEDBY");

                entity.Property(e => e.Packedon)
                    .HasMaxLength(515)
                    .IsUnicode(false)
                    .HasColumnName("PACKEDON");

                entity.Property(e => e.Postedby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDBY");

                entity.Property(e => e.Postedon)
                    .HasMaxLength(515)
                    .IsUnicode(false)
                    .HasColumnName("POSTEDON");

                entity.Property(e => e.Printedon)
                    .HasMaxLength(515)
                    .IsUnicode(false)
                    .HasColumnName("PRINTEDON");
            });

            modelBuilder.Entity<VwShippingErpInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SHIPPING_ERP_INVOICE");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address1)
                    .HasMaxLength(101)
                    .HasColumnName("ADDRESS1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Address2)
                    .HasMaxLength(84)
                    .HasColumnName("ADDRESS2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addrline1)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE1")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Addrline2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE2")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AGENTCODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentservice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AGENTSERVICE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Backorder)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BACKORDER");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_TYPE");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("CITY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("COUNTRY")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Customerpo)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("CUSTOMERPO")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(20)
                    .HasColumnName("DOCID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DOCNUMBER")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("EMAIL")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Emailcontact)
                    .HasMaxLength(150)
                    .HasColumnName("EMAILCONTACT")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Freightacc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FREIGHTACC");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.ProcessStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.Releasedate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RELEASEDATE");

                entity.Property(e => e.Reqdelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQDELIVERY");

                entity.Property(e => e.ServAgentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SERV_AGENT_CODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoaddress)
                    .HasMaxLength(50)
                    .HasColumnName("SHIPTOADDRESS")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Shiptoname)
                    .HasMaxLength(4000)
                    .HasColumnName("SHIPTONAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .HasColumnName("STATE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .HasColumnName("ZIP")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<VwSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SITES");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE_NAME");
            });

            modelBuilder.Entity<VwStockAvailableByItemBarcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_STOCK_AVAILABLE_BY_ITEM_BARCODE");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BARCODE");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.QtyAvailable)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_AVAILABLE");

                entity.Property(e => e.QtyOnPick).HasColumnName("QTY_ON_PICK");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.StockQty)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("STOCK_QTY");
            });

            modelBuilder.Entity<VwStockAvailableByItemLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_STOCK_AVAILABLE_BY_ITEM_LOT");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Lotno)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOTNO");

                entity.Property(e => e.QtyAvailable)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_AVAILABLE");

                entity.Property(e => e.QtyOnPick).HasColumnName("QTY_ON_PICK");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");

                entity.Property(e => e.StockQty)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("STOCK_QTY");
            });

            modelBuilder.Entity<VwStockAvailableByItemWm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_STOCK_AVAILABLE_BY_ITEM_WMS");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.QtyAvailable).HasColumnName("QTY_AVAILABLE");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<VwStockAvailableByItemWmsBin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_STOCK_AVAILABLE_BY_ITEM_WMS_BIN");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.QtyAvailable).HasColumnName("QTY_AVAILABLE");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<VwTaskAssignOpen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TASK_ASSIGN_OPEN");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Acctype)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACCTYPE");

                entity.Property(e => e.Agentcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AGENTCODE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Agentservice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AGENTSERVICE")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Backorder)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BACKORDER");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Doclink)
                    .HasMaxLength(68)
                    .HasColumnName("DOCLINK")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Edl)
                    .HasColumnType("datetime")
                    .HasColumnName("EDL");

                entity.Property(e => e.Esh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ESH");

                entity.Property(e => e.Expedited).HasColumnName("EXPEDITED");

                entity.Property(e => e.ExportType).HasColumnName("EXPORT_TYPE");

                entity.Property(e => e.FgAlert)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FG_ALERT");

                entity.Property(e => e.Fgcolor)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FGCOLOR");

                entity.Property(e => e.HasStock).HasColumnName("HAS_STOCK");

                entity.Property(e => e.IsBkord).HasColumnName("IS_BKORD");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Pcs)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("PCS");

                entity.Property(e => e.Ptype).HasColumnName("PTYPE");

                entity.Property(e => e.Reqdelivery)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQDELIVERY");

                entity.Property(e => e.Rls)
                    .HasColumnType("datetime")
                    .HasColumnName("RLS");

                entity.Property(e => e.Shpvia)
                    .IsRequired()
                    .HasMaxLength(61)
                    .HasColumnName("SHPVIA")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.To)
                    .HasMaxLength(94)
                    .HasColumnName("TO")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Totalprice)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("TOTALPRICE");
            });

            modelBuilder.Entity<VwUserByRol>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_USER_BY_ROL");

                entity.Property(e => e.IdRol)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_rol");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_rol");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_usuario");

                entity.Property(e => e.Rowid).HasColumnName("rowid");
            });

            modelBuilder.Entity<VwWmsBinReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WMS_BIN_REFERENCE");

                entity.Property(e => e.BinSequence).HasColumnName("BIN_SEQUENCE");

                entity.Property(e => e.Bincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BINCODE");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Receivedon)
                    .HasColumnType("datetime")
                    .HasColumnName("RECEIVEDON");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<VwWmsNavComparison>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WMS_NAV_COMPARISON");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.NavOnhand)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("NAV_ONHAND");

                entity.Property(e => e.NavToReceive)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("NAV_TO_RECEIVE");

                entity.Property(e => e.NavToShip)
                    .HasColumnType("numeric(26, 0)")
                    .HasColumnName("NAV_TO_SHIP");

                entity.Property(e => e.WmsOnhand).HasColumnName("WMS_ONHAND");

                entity.Property(e => e.WmsPicked).HasColumnName("WMS_PICKED");
            });

            modelBuilder.Entity<VwWmsPackingBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WMS_PACKING_BALANCE");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.QtyPackage).HasColumnName("QTY_PACKAGE");

                entity.Property(e => e.QtyPacked).HasColumnName("QTY_PACKED");

                entity.Property(e => e.QtyPicking).HasColumnName("QTY_PICKING");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<VwWmsPackingBalanceNotPacked>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WMS_PACKING_BALANCE_NOT_PACKED");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.QtyPackage).HasColumnName("QTY_PACKAGE");

                entity.Property(e => e.QtyPacked).HasColumnName("QTY_PACKED");

                entity.Property(e => e.QtyPicking).HasColumnName("QTY_PICKING");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<VwWmsPackingBalanceWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WMS_PACKING_BALANCE_WEB");

                entity.Property(e => e.Confirmdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMDOC");

                entity.Property(e => e.Erpdoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERPDOC");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOT");

                entity.Property(e => e.QtyPackage).HasColumnName("QTY_PACKAGE");

                entity.Property(e => e.QtyPacked).HasColumnName("QTY_PACKED");

                entity.Property(e => e.QtyPicking).HasColumnName("QTY_PICKING");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<VwWmsPackingConsolidate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WMS_PACKING_CONSOLIDATE");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Acctype)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACCTYPE");

                entity.Property(e => e.Backorder)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BACKORDER");

                entity.Property(e => e.BillTo)
                    .HasMaxLength(94)
                    .HasColumnName("BILL_TO")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Doclink)
                    .HasMaxLength(68)
                    .HasColumnName("DOCLINK")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Packedon)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKEDON");

                entity.Property(e => e.Packingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKINGDATE");

                entity.Property(e => e.Packingdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PACKINGDOC");

                entity.Property(e => e.Packstarton)
                    .HasColumnType("datetime")
                    .HasColumnName("PACKSTARTON");

                entity.Property(e => e.Pickingdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PICKINGDOC");

                entity.Property(e => e.Shpvia)
                    .IsRequired()
                    .HasMaxLength(61)
                    .HasColumnName("SHPVIA")
                    .UseCollation("Latin1_General_100_CS_AS");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(20)
                    .HasColumnName("ZIPCODE")
                    .UseCollation("Latin1_General_100_CS_AS");
            });

            modelBuilder.Entity<VwWmsShipviaCuttime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WMS_SHIPVIA_CUTTIME");

                entity.Property(e => e.AddDays).HasColumnName("ADD_DAYS");

                entity.Property(e => e.CutOperator)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CUT_OPERATOR");

                entity.Property(e => e.CutTime).HasColumnName("CUT_TIME");

                entity.Property(e => e.ShipviaCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SHIPVIA_CODE");
            });

            modelBuilder.Entity<WfProceso>(entity =>
            {
                entity.HasKey(e => e.IdProceso);

                entity.ToTable("wf_proceso");

                entity.Property(e => e.IdProceso)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_proceso");

                entity.Property(e => e.AssignType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_TYPE");

                entity.Property(e => e.BalanceConfirmAction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BALANCE_CONFIRM_ACTION");

                entity.Property(e => e.ConfirmNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRM_NO");

                entity.Property(e => e.ConfirmQuestion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRM_QUESTION");

                entity.Property(e => e.ConfirmYes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRM_YES");

                entity.Property(e => e.Credate)
                    .HasColumnType("datetime")
                    .HasColumnName("credate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.WbBalance)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WB_BALANCE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WbDocList)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WB_DOC_LIST");

                entity.Property(e => e.WbInquiry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WB_INQUIRY");

                entity.Property(e => e.WbLog)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WB_LOG")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<WfProcesoRuntime>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("wf_proceso_runtime");

                entity.HasIndex(e => e.SessionId, "IX_wf_proceso_runtime");

                entity.HasIndex(e => e.DataCaptured, "IX_wf_proceso_runtime_1");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.DataCaptured)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_captured");

                entity.Property(e => e.DataDate1)
                    .HasColumnType("date")
                    .HasColumnName("data_date1");

                entity.Property(e => e.DataKey1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_key1");

                entity.Property(e => e.DataKey2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_key2");

                entity.Property(e => e.DataKey3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data_key3");

                entity.Property(e => e.IdProceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_proceso");

                entity.Property(e => e.LogNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("log_notes");

                entity.Property(e => e.Processed)
                    .HasColumnType("datetime")
                    .HasColumnName("processed");

                entity.Property(e => e.ProcessedErp)
                    .HasColumnType("datetime")
                    .HasColumnName("processed_erp");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasColumnName("regdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("require_lotno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("session_id");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StepAttribute)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("step_attribute")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StepName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("step_name");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<WfProcesoStep>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("wf_proceso_step");

                entity.HasIndex(e => new { e.IdProceso, e.Step }, "IX_wf_proceso_step")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdProceso, e.Attribute }, "IX_wf_proceso_step_1")
                    .IsUnique();

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Attribute)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AutoInput)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("auto_input")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Control)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CONTROL");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechamod)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamod");

                entity.Property(e => e.IdProceso)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_proceso");

                entity.Property(e => e.IndActivo)
                    .HasColumnName("ind_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLastStep).HasColumnName("is_last_step");

                entity.Property(e => e.LblAfterComplete)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LBL_AFTER_COMPLETE");

                entity.Property(e => e.LblHelp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LBL_HELP");

                entity.Property(e => e.LblRequest)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LBL_REQUEST");

                entity.Property(e => e.ListOption)
                    .IsUnicode(false)
                    .HasColumnName("list_option");

                entity.Property(e => e.MultiStep).HasColumnName("multi_step");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StepEscape).HasColumnName("step_escape");

                entity.Property(e => e.StepFeatures)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("step_features")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomod");

                entity.Property(e => e.Validate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VALIDATE")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdProcesoNavigation)
                    .WithMany(p => p.WfProcesoSteps)
                    .HasForeignKey(d => d.IdProceso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_wf_proceso_step_wf_proceso");
            });

            modelBuilder.Entity<ZItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_ITEM");

                entity.Property(e => e.IsKit).HasColumnName("IS_KIT");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UOM");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UPC");

                entity.Property(e => e.Vendorid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VENDORID");
            });

            modelBuilder.Entity<ZItemUom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_ITEM_UOM");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Qtybase)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("QTYBASE");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UOM");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<ZReceivingErpDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_RECEIVING_ERP_DOCS");

                entity.Property(e => e.Accountid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.ArrivedOn).HasColumnType("datetime");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(20)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.NavStatus).HasColumnName("NAV_Status");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.NumOrd).HasColumnName("numOrd");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Wmscustom)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("WMSCustom");
            });

            modelBuilder.Entity<ZReceivingErpDocsLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_RECEIVING_ERP_DOCS_LINES");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(20)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(20)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctypeid).HasColumnName("DOCTYPEID");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemname)
                    .HasMaxLength(4000)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.Lineid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("LINEID");

                entity.Property(e => e.QtyOutstanding)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_OUTSTANDING");

                entity.Property(e => e.QtyToErp).HasColumnName("QTY_TO_ERP");

                entity.Property(e => e.QtyToReceive)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTY_TO_RECEIVE");

                entity.Property(e => e.Qtyonprocess).HasColumnName("QTYONPROCESS");

                entity.Property(e => e.Qtyorder)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYORDER");

                entity.Property(e => e.Qtypending)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYPENDING");

                entity.Property(e => e.Qtyreceived)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYRECEIVED");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Unitid)
                    .HasMaxLength(10)
                    .HasColumnName("UNITID");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(23)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<ZShippingErpDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_SHIPPING_ERP_DOCS");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(4000)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.Address1)
                    .HasMaxLength(101)
                    .HasColumnName("ADDRESS1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(84)
                    .HasColumnName("ADDRESS2");

                entity.Property(e => e.Addresstype).HasColumnName("ADDRESSTYPE");

                entity.Property(e => e.Addrline1)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE1");

                entity.Property(e => e.Addrline2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRLINE2");

                entity.Property(e => e.Agentcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AGENTCODE");

                entity.Property(e => e.Agentservice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AGENTSERVICE");

                entity.Property(e => e.Backorder)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BACKORDER");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_TYPE");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("CITY");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createuser)
                    .HasMaxLength(4000)
                    .HasColumnName("CREATEUSER");

                entity.Property(e => e.Customerpo)
                    .HasMaxLength(4000)
                    .HasColumnName("CUSTOMERPO");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(31)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Emailcontact)
                    .HasMaxLength(150)
                    .HasColumnName("EMAILCONTACT");

                entity.Property(e => e.Freightacc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("FREIGHTACC");

                entity.Property(e => e.ImpAddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("IMP_ADDRESS");

                entity.Property(e => e.ImpCity)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("IMP_CITY");

                entity.Property(e => e.ImpCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("IMP_COUNTRY");

                entity.Property(e => e.ImpName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("IMP_NAME");

                entity.Property(e => e.ImpPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IMP_PHONE");

                entity.Property(e => e.ImpState)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IMP_STATE");

                entity.Property(e => e.ImpZip)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IMP_ZIP");

                entity.Property(e => e.InsideDeliv).HasColumnName("INSIDE_DELIV");

                entity.Property(e => e.LiftDeliv).HasColumnName("LIFT_DELIV");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC");

                entity.Property(e => e.Oversize).HasColumnName("OVERSIZE");

                entity.Property(e => e.Paymethod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PAYMETHOD");

                entity.Property(e => e.Payterm)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PAYTERM");

                entity.Property(e => e.ProcessStatus).HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.Promiseddate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROMISEDDATE");

                entity.Property(e => e.Releasedate)
                    .HasColumnType("datetime")
                    .HasColumnName("RELEASEDATE");

                entity.Property(e => e.Reqdelivery)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQDELIVERY");

                entity.Property(e => e.SalesrepMail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SALESREP_MAIL");

                entity.Property(e => e.ServAgentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SERV_AGENT_CODE");

                entity.Property(e => e.Shiptoaddress)
                    .HasMaxLength(50)
                    .HasColumnName("SHIPTOADDRESS");

                entity.Property(e => e.Shiptoname)
                    .HasMaxLength(4000)
                    .HasColumnName("SHIPTONAME");

                entity.Property(e => e.SignatureReq).HasColumnName("SIGNATURE_REQ");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .HasColumnName("STATE");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Totalprice)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("TOTALPRICE");

                entity.Property(e => e.Wbroker)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("WBROKER");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<ZShippingErpDocsLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_SHIPPING_ERP_DOCS_LINES");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Docdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOCDATE");

                entity.Property(e => e.Docid)
                    .HasMaxLength(31)
                    .HasColumnName("DOCID");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(31)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE");

                entity.Property(e => e.HasStock).HasColumnName("HAS_STOCK");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITEMNAME");

                entity.Property(e => e.LineWeight)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("LINE_WEIGHT");

                entity.Property(e => e.Lineid).HasColumnName("LINEID");

                entity.Property(e => e.OriDoc)
                    .HasMaxLength(20)
                    .HasColumnName("ORI_DOC");

                entity.Property(e => e.QtyPerUom)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("QTY_PER_UOM");

                entity.Property(e => e.Qtyonprocess).HasColumnName("QTYONPROCESS");

                entity.Property(e => e.Qtyorder)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYORDER");

                entity.Property(e => e.Qtypending)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYPENDING");

                entity.Property(e => e.Qtyshipped)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("QTYSHIPPED");

                entity.Property(e => e.RequireLotno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOTNO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SITE");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(25, 2)")
                    .HasColumnName("UNIT_PRICE");

                entity.Property(e => e.Unitid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UNITID");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<ZSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_SITES");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Phone No_");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Selected).HasColumnName("selected");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
