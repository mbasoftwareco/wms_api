using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using wms_api.Models;

namespace wms_api.Utils
{
    public static class PrintLabel
    {
        private static string appPath = ""; //@"C:\Projects\WMS_Ligero\WMSExpress.WebApp";
        private static string apiPath = "";
        private static string error = "";
        private static string batFile = ""; // @"C:\Projects\WMS_Ligero\WMSExpress.WebApp\PRINT.BAT";
        private static string FileKey = "";
        private static string UserPrinter = "";
        private delegate void UpdateValueDelegate(string data);


        public static Mail_Tpl_Obj PrintFromDataSet(DataSet dsResult, SUsuario user, string Modulo, string TEMPLATE_CODE,
            string outputType, string document, string site_warehouse, string useThread /*,string printer*/ )
        {
            //Directories para grabar documentos y labels
            Set_DIRECTORY_Parameters();

            //VALIDA SI la opcion de impresion en por HTML o por RDL
            //if (UtilTool.GetParameter("PRINT.MODE").Equals("RDL"))
            //    return PrintFromDataSet_RDL_MODE(dsResult, user, Modulo, TEMPLATE_CODE, outputType, document, site_warehouse, useThread);

            //else  //HTML MODE
            return PrintFromDataSet_HTML_MODE(dsResult, user, Modulo, TEMPLATE_CODE, outputType, document, site_warehouse);

        }


        private static void Set_DIRECTORY_Parameters()
        {
            batFile = UtilTool.GetParameter("BAT.FILE");
            appPath = UtilTool.GetParameter("APP.DIR");
            apiPath = UtilTool.GetParameter("URL.BASE.API");
        }


        private static Mail_Tpl_Obj PrintFromDataSet_HTML_MODE(DataSet dsResult, SUsuario user, string Modulo, string TEMPLATE_CODE, string outputType, string document, string site_wh)
        {

            _WEB _web = new _WEB();
            WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

            FileKey = document;

            MPrintTemplate template = _db.MPrintTemplates.Where(f => f.Code == TEMPLATE_CODE).First();

            //TEMPLETE HEADER
            string LabelTemplate = template.Pltemplate;

            //TEMPLATE DETAILS
            string LabelTemplateDetail = template.Pldetail;

            Mail_Tpl_Obj ArchivoLabel = Evaluate_Replace_Template_Data(template, dsResult, Modulo);

            //VER EL DOCUMENTO EN PANTALLA
            if (outputType == "MAIL")
                return ArchivoLabel;

            else if (outputType == "VIEW")
            {
                return new Mail_Tpl_Obj { MESSAGE = PRINT_CreatePrintTemporaryFile(ArchivoLabel.MESSAGE, Modulo, ".html", outputType) };
            }

            else  //PRINT DOCUMENT OR LABEL
            {
                string Printer = null;

                MResourcesRuntime MResourcesRuntime;

                //1. USER
                MResourcesRuntime = _db.MResourcesRuntimes.
                        Where(f => f.OwnerRowid == user.Rowid.ToString()
                                && f.OwnerType == "USER"
                                && f.TempleteCode == template.Code).FirstOrDefault();

                //2. MODULE
                if (MResourcesRuntime == null)
                {
                    MResourcesRuntime = _db.MResourcesRuntimes.
                            Where(f => f.OwnerRowid == Modulo
                                    && f.OwnerType == "MODULE"
                                    && f.TempleteCode == template.Code).FirstOrDefault();
                }

                //3. SITE-BODEGA
                if (MResourcesRuntime == null)
                {
                    MResourcesRuntime = _db.MResourcesRuntimes.
                                          Where(f => f.OwnerRowid == site_wh
                                                  && f.OwnerType == "SITE"
                                                  && f.TempleteCode == template.Code).FirstOrDefault();
                }



                // SE ASIGNA DIRECCION DE LA IMPRESORA DEL MAESTRO  PRINTER
                if (MResourcesRuntime == null)
                {
                    try
                    {
                        throw new Exception($"NOT PRINTER ASSIGNED/SELECTED {site_wh}, { Modulo}, {user.Rowid} , {template.Code}");
                    }
                    catch
                    {
                        throw new Exception("NOT PRINTER ASSIGNED/SELECTED");
                    }
                }


                try
                {
                    Printer = _db.MResources.Where(f => f.Rowid == MResourcesRuntime.RowidResource).First().ResourceAddress;
                }
                catch
                {
                    try
                    {
                        throw new Exception("NOT PRINTER ASSIGNED/SELECTED" + site_wh + ", " + Modulo + ", " + user.Rowid.ToString() + ", " + template.Code);
                    }
                    catch
                    {
                        throw new Exception("NOT PRINTER ASSIGNED/SELECTED");
                    }
                }

                if (TEMPLATE_CODE.Contains("LABEL"))
                {
                    PRINT_Labels_TPL(ArchivoLabel.MESSAGE, Printer, Modulo);

                    return new Mail_Tpl_Obj { MESSAGE = dsResult.Tables[0].Rows.Count.ToString() + " PROCESSED", SUBJECT = "" };
                }
                else if (TEMPLATE_CODE.Contains("DOCUMENT"))
                    PRINT_Document_HTML(ArchivoLabel.MESSAGE, Printer, Modulo);

            }

            return new Mail_Tpl_Obj { MESSAGE = "", SUBJECT = "" };
        }


        /*
        private static Mail_Tpl_Obj PrintFromDataSet_RDL_MODE(DataSet dsResult, SUsuario user, string Modulo, string TEMPLATE_CODE,
            string outputType, string document, string site_wh, string useThread)
        {


            _WEB _web = new _WEB();

            FileKey = document;

            MPrintTemplate template = _db.MPrintTemplates.Where(f => f.CODE == TEMPLATE_CODE).First();

            //VER EL DOCUMENTO EN PANTALLA
            if (outputType == "MAIL")
                return Evaluate_Replace_Template_Data(template, dsResult, Modulo);

            else if (outputType == "VIEW")
                return new Mail_Tpl_Obj { MESSAGE = RDL_UTIL.RDL_Generate_PDF_File_VIEW(dsResult, template, document), SUBJECT = "" };


            else  //PRINT DOCUMENT OR LABEL
            {
                string Printer = null;

                MResourcesRuntime MResourcesRuntime;

                //1. USER
                MResourcesRuntime = _db.MResourcesRuntimes.
                        Where(f => f.OwnerRowid == user.rowid.ToString()
                                && f.OwnerType == "USER"
                                && f.TempleteCode == template.CODE).FirstOrDefault();

                //2. MODULE
                if (MResourcesRuntime == null)
                {
                    MResourcesRuntime = _db.MResourcesRuntimes.
                            Where(f => f.OwnerRowid == Modulo
                                    && f.OwnerType == "MODULE"
                                    && f.TempleteCode == template.CODE).FirstOrDefault();
                }

                //3. SITE-BODEGA
                if (MResourcesRuntime == null)
                {
                    MResourcesRuntime = _db.MResourcesRuntimes.
                                          Where(f => f.OwnerRowid == site_wh
                                                  && f.OwnerType == "SITE"
                                                  && f.TempleteCode == template.CODE).FirstOrDefault();
                }



                // SE ASIGNA DIRECCION DE LA IMPRESORA DEL MAESTRO  PRINTER
                if (MResourcesRuntime == null)
                {
                    try
                    {
                        throw new Exception("NOT PRINTER ASSIGNED/SELECTED" + site_wh + ", " + Modulo + ", " + user.rowid.ToString() + ", " + template.CODE);
                    }
                    catch
                    {
                        throw new Exception("NOT PRINTER ASSIGNED/SELECTED");
                    }
                }

                try
                {
                    Printer = _db.MResources.Where(f => f.rowid == MResourcesRuntime.rowid_resource).First().resource_address;
                }
                catch
                {
                    try
                    {
                        throw new Exception("NOT PRINTER ASSIGNED/SELECTED" + site_wh + ", " + Modulo + ", " + user.rowid.ToString() + ", " + template.CODE);
                    }
                    catch
                    {
                        throw new Exception("NOT PRINTER ASSIGNED/SELECTED");
                    }
                }


                if (TEMPLATE_CODE.Contains("LABEL"))
                {
                    string ArchivoLabel = Evaluate_Replace_Template_Data(template, dsResult, Modulo).MESSAGE;

                    PRINT_Labels_TPL(ArchivoLabel, Printer, Modulo);

                    return new Mail_Tpl_Obj { MESSAGE = dsResult.Tables[0].Rows.Count.ToString() + " PROCESSED", SUBJECT = "" };
                }
                else if (TEMPLATE_CODE.Contains("DOCUMENT"))
                    RDL_UTIL.RDL_Generate_PDF_File_PRINT(dsResult, template, Printer, document, useThread);

            }

            return new Mail_Tpl_Obj { MESSAGE = "", SUBJECT = "" };
        }
        */

        /// <summary>
        /// Metodo que evalua el template y reemplaza los valores de las etiquetas por los valores 
        /// que vinene en el dataset
        /// </summary>
        /// <param name="template"></param>
        /// <param name="dsResult"></param>
        /// <param name="Modulo"></param>
        /// <returns></returns>
        private static Mail_Tpl_Obj Evaluate_Replace_Template_Data(MPrintTemplate template, DataSet dsResult, string Modulo)
        {
            string ArchivoLabel = "", MAIL_Subject = "";


            foreach (DataRow row in dsResult.Tables[0].Rows)
            {
                //TEMPLETE HEADER
                string LabelTemplate = template.Pltemplate;
                MAIL_Subject = template.Header;

                //TEMPLATE DETAILS
                string LabelTemplateDetail = template.Pldetail;


                #region HEADER

                foreach (DataColumn column in dsResult.Tables[0].Columns)
                {
                    try
                    {
                        if (column.ColumnName != "LOGO")
                            LabelTemplate = LabelTemplate.Replace("_" + column.ColumnName, row[column.ColumnName].ToString().Trim());

                        MAIL_Subject = MAIL_Subject.Replace("_" + column.ColumnName, row[column.ColumnName].ToString().Trim());

                        #region REPLACE ONLY IN HTML DOCUMENT

                        if (template.Code.Contains("DOCUMENT") || template.Code.Contains("MAIL"))
                        {

                            Barcode barcode = new Barcode();
                            barcode.Height = 50;

                            // Render barcode:
                            Bitmap bitmap = new Bitmap(barcode.Encode(TYPE.CODE128, row["DOCNUMBER"].ToString(), Color.Black, Color.White));
                            string baseBarcode = "\\PRINT\\" + "barcode-" + row["DOCNUMBER"].ToString() + ".gif";
                            string archivoBarcode = appPath + baseBarcode;

                            // You can also save it to file:xx
                            barcode.SaveImage(archivoBarcode, SaveTypes.GIF);

                            LabelTemplate = LabelTemplate.Replace("_BARCODE", "<img src='" + apiPath + archivoBarcode + "' alt='Barcode'/>");

                            LabelTemplate = LabelTemplate.Replace("_LOGO", "<img src='" + row["LOGO"].ToString() + "' alt='LOGO'/>");

                        }

                        #endregion


                    }
                    catch { }
                }

                #endregion

                #region HEADER_DETAILS

                if (template.Code.Contains("DOCUMENT") || template.Code.Contains("MAIL"))
                {
                    // Remplace y dibuja las lineas 
                    string LineDetail = "";

                    foreach (DataRow row2 in dsResult.Tables[1].Rows)
                    {
                        string Line = LabelTemplateDetail;

                        foreach (DataColumn column2 in dsResult.Tables[1].Columns)
                        {
                            try
                            {
                                //LabelTemplate = LabelTemplate.Replace(mapping2.DataKey, row2[mapping2.DataValue.Trim()].ToString().Trim());
                                Line = Line.Replace("_" + column2.ColumnName, row2[column2.ColumnName].ToString().Trim());

                                #region BARCODE FOR SHIPPING

                                if (Modulo == "PICKING" || Modulo == "PACKING" || Modulo == "DELIVERY")
                                {
                                    try
                                    {
                                        // Codigo De  Barra Para La Linea
                                        Barcode barcode_line = new Barcode();
                                        barcode_line.Height = 50;

                                        // Render barcode:
                                        Bitmap bitmap_line = new Bitmap(barcode_line.Encode(TYPE.CODE128, row2["LINEID"].ToString(), Color.Black, Color.White));

                                        string baseBarcode = "\\PRINT\\" + "barcode-" + row["DOCNUMBER"].ToString() + "-" + row2["LINEID"].ToString() + ".gif";
                                        string archivoBarcode_line = appPath + baseBarcode;
                                        // You can also save it to file:
                                        barcode_line.SaveImage(archivoBarcode_line, SaveTypes.GIF);

                                        Line = Line.Replace("_BARCODE_LINE", "<img src='" + apiPath + baseBarcode + "' style='height: 35px;' alt='codigo barra linea'/>");
                                    }
                                    catch { }
                                }

                                #endregion

                            }
                            catch { }
                        }

                        LineDetail += Line;
                    }

                    LabelTemplate = LabelTemplate.Replace("_DETAILS", LineDetail);

                    // Remplace la cantidad pendiente
                    try
                    {
                        foreach (DataRow row3 in dsResult.Tables[2].Rows)
                        {
                            foreach (DataColumn column3 in dsResult.Tables[2].Columns)
                            {
                                try
                                {
                                    LabelTemplate = LabelTemplate.Replace("_" + column3.ColumnName, row3[column3.ColumnName].ToString().Trim());
                                }
                                catch { }
                            }
                        }
                    }
                    catch { }
                }

                #endregion

                ArchivoLabel += LabelTemplate + "\n \n";
            }

            return new Mail_Tpl_Obj { MESSAGE = ArchivoLabel, SUBJECT = MAIL_Subject };
        }


        public static bool PRINT_Document_HTML(string labelData, string printerPort, string Modulo)
        {
            //TODO: Módulo de impresión
            bool result = false;
            string printPort = printerPort;
            string filePath = PRINT_CreatePrintTemporaryFile(labelData, Modulo, ".html", "PRINTER");

            try
            {
                if (File.Exists(filePath) == false)
                    throw new Exception("Please setup the temporary printing file.");

                // se envia archivo temporal a la impresora
                Print_HTML_Process(filePath);

            }
            catch (Exception ex)
            {
                result = true;
                throw ex;
            }
            return result;
        }


        //Envia un archivo de templates a imprimir
        public static bool PRINT_Labels_TPL(string labelData, string printerPort, string Modulo)
        {
            //TODO: Módulo de impresión
            bool result = false;

            string printPort = printerPort;

            string filePath = PRINT_CreatePrintTemporaryFile(labelData, Modulo, ".prn", "PRINTER");

            if (!File.Exists(batFile))
                throw new Exception("Setup file " + batFile + " does not exists.\n");

            try
            {
                if (File.Exists(filePath) == false)
                    throw new Exception("Please setup the temporary printing file.");

                string printCommand = "\"" + filePath + "\" \"" + printPort + "\"";
                PRINT_Label_Process(printCommand);
            }
            catch (Exception ex)
            {
                result = true;
                throw ex;
            }
            return result;
        }


        public static string PRINT_CreatePrintTemporaryFile(string labelData, string Modulo, string ext, string outputType)
        {

            string fileName = Modulo + "-" + FileKey + "-" + Guid.NewGuid().ToString().ToUpper().Remove(8);

            string tmpPrintFile = appPath + "\\PRINT\\" + fileName + ext;
            //tmpPrintFile = tmpPrintFile.Replace("\\\\", "\\");

            StreamWriter writer = new StreamWriter(tmpPrintFile);

            writer.WriteLine(labelData);
            writer.Flush();
            writer.Close();

            if (outputType == "VIEW")
                return apiPath + "/PRINT/" + fileName + ext;
            else
                return tmpPrintFile;
        }


        // Impresion por medio de archivo .BAT
        private static void PRINT_Label_Process(object printCommand)
        {

            try
            {
                //Declare and instantiate a new process component.
                Process cmdProcess = new Process();

                //Do not receive an event when the process exits.
                cmdProcess.EnableRaisingEvents = false;
                cmdProcess.StartInfo.UseShellExecute = false;
                cmdProcess.StartInfo.FileName = batFile;
                cmdProcess.StartInfo.Arguments = printCommand.ToString();
                cmdProcess.StartInfo.CreateNoWindow = true;
                cmdProcess.Start();
                cmdProcess.WaitForExit();
                cmdProcess.Close();

                //Write Test.
                //CreatePrintTemporaryFile("RECEIVING-" +ponumber+"-"+ Guid.NewGuid().ToString().Remove(8), printCommand.ToString());

            }
            catch (Exception ex)
            {
                error += "Error with: [" + printCommand.ToString() + "] " + ex.Message + "\n";
                //TODO: Salver en los logs que no se pudo hallar el file
            }


        }


        // imprime de archivos html
        public static void Print_HTML_Process(string document)
        {
            //string document = @"C:\A.HTML";
            try
            {
                using (Process printProcess = new Process())
                {
                    string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
                    printProcess.StartInfo.FileName = systemPath + @"\rundll32.exe";
                    printProcess.StartInfo.Arguments = systemPath + @"\mshtml.dll,PrintHTML """ + document + @"""";
                    printProcess.Start();
                }

                //DocumentEvent.InsertEventDocument(DocEventType.Print, FileKey, UserPrinter, "", true);
            }
            catch
            {

            }
        }

    }

}
