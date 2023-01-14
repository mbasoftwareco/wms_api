using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using wms_api.Models;
using Microsoft.Data.SqlClient;


namespace wms_api.Utils
{
    public static class Notification
    {


        private static WMS_LIGERO_LIVEContext _db { get; set; }

        /// <summary>
        /// Metodo que evalua el template y reemplaza los valores de las etiquetas por los valores 
        /// que vinene en el dataset
        /// </summary>
        /// <param name="template"></param>
        /// <param name="dsResult"></param>
        /// <param name="Modulo"></param>
        /// <returns></returns>
        public static Mail_Tpl_Obj Evaluate_Replace_Template_Data(string template, string subject, DataSet dsResult)
        {

            string ArchivoLabel = "", MAIL_Subject = "";

            foreach (DataRow row in dsResult.Tables[0].Rows)
            {
                //TEMPLETE HEADER
                string LabelTemplate = template;
                MAIL_Subject = subject;

                //TEMPLATE DETAILS
                string LabelTemplateDetail = template; //template.body;


                #region HEADER

                foreach (DataColumn column in dsResult.Tables[0].Columns)
                {
                    try
                    {

                        LabelTemplate = LabelTemplate.Replace("_" + column.ColumnName, row[column.ColumnName].ToString().Trim());

                        MAIL_Subject = MAIL_Subject.Replace("_" + column.ColumnName, row[column.ColumnName].ToString().Trim());

                    }
                    catch { }
                }

                #endregion

                ArchivoLabel += LabelTemplate + "\n \n";
            }


            return new Mail_Tpl_Obj { MESSAGE = ArchivoLabel, SUBJECT = MAIL_Subject };

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        /// <param name="customerAccountId"> cuenta del administrador de documentos EJEMPLO COSMOAGRO S.A</param>
        /// <param name="Email"></param>
        /// <param name="docAccountId"> Cuenta del tercero que envia documentos</param>
        /// <returns></returns>
        public static string GetDataNotification(string option, string Email, string Guid = null)
        {
            string subject = "";

            if (Guid == null)
                Guid = UtilTool.ReturnGUID(8);

            //S01_MetaMaster MailTest = _db.S01_MetaMaster.Where(m=>m.Class.Equals("PARAM") && m.Code.Equals("TEST.EMAIL")).FirstOrDefault();

                //if (MailTest!=null)
                //    Mail = MailTest.Name;


            if (_db == null)
                _db = new WMS_LIGERO_LIVEContext();

            string query = "EXEC UTIL_Notification @option ='" + option + "', @Email='" + Email + "', @Guid='" + Guid + "'";

            string conString = _db.Database.GetConnectionString();

            string _db_cnn = conString;

            DataSet ds = SQLBase.ReturnDataSet(query, new SqlConnection(_db_cnn));

            subject = ds.Tables[1].Rows[0]["Subject"].ToString();

            string mailTemplate = ds.Tables[1].Rows[0]["Template"].ToString();

            Mail_Tpl_Obj MSG = Notification.Evaluate_Replace_Template_Data(mailTemplate, subject, ds);


            #region DATATABLE to HTML

            int z = 0;
            int cantDocs = 0;
            string html_message = "";
            foreach (DataTable dt in ds.Tables)
            {

                if (z < 2)
                {
                    z++;
                    continue;
                }

                string body = "<table cellpadding=4 cellspacing=1 border=1><thead><tr>";

                foreach (DataColumn colm in dt.Columns)
                {
                    if (colm.Caption.StartsWith("_"))
                        continue;

                    body += "<th>" + colm.Caption + "</th>";

                }

                body += "</tr></thead><tbody>";

                foreach (DataRow row in dt.Rows)
                {
                    cantDocs++;

                    body += "<tr>";

                    for (int i = 0; i < row.ItemArray.Count(); i++)
                    {
                        if (dt.Columns[i].Caption.StartsWith("_"))
                            continue;

                        try
                        {
                            //body += "<td>" + row[i].ToString() + "&nbsp;</td>";
                            body += "<td>" + row[i].ToString() + "</td>";
                        }
                        catch
                        {
                            //body += "<td>&nbsp;</td>";
                            body += "<td></td>";
                        }
                    }
                    body += "</tr>";
                }

                body += "</tbody></table><br><br>";

                html_message += body;
            }

            MSG.MESSAGE = MSG.MESSAGE.Replace("_TABLES", html_message);


            #endregion


            TEnviomail mail = new TEnviomail
            {
                Mto = Email,
                Message = MSG.MESSAGE,
                Fechacreacion = DateTime.Now,
                Usuariocreacion = Email,
                Sent = 0,
                Mfrom = "",
                Subject = MSG.SUBJECT,
                Observaciones = Guid
            };

            mail.Attachment = "";

            
            /*
             * try { mail.MBcc = ds.Tables[1].Rows[0]["MBcc"].ToString(); } catch { }
            */
            _db.TEnviomails.Add(mail);

            _db.SaveChanges();


            MailSender.EnviarEmails();

            return "";
        }

    }

}
