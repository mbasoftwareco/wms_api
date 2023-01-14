using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Globalization;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Helpers
{
    public class SyncHelper
    {

        // private WMS_LIGERO_LIVEContext db = new WMS_LIGERO_LIVEContext();

        private IConfiguration Configuration;

        WMS_LIGERO_LIVEContext _db;

        public SyncHelper()  { }

        public SyncHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }

        public dynamic SyncAction(SyncRequest payload)
        {
            switch (payload.entity)
            {
                case "DOCUMENT":
                    SaveDocument(payload);
                    break;

                case "STOCK":
                    SaveStock(payload);
                    break;
            }

            return null;
        }


        public void SaveDocument(SyncRequest payload)
        {
            //Grabar el Objeto v2_api_document_work

            V2ApiDocumentWork curReg = new V2ApiDocumentWork();

            string docDate = (payload.document_date.Length > 10) ? payload.document_date.Remove(10) : payload.document_date;

            curReg.DocDate = DateTime.ParseExact(docDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            curReg.DocType = payload.document_type;
            curReg.DocNumber = payload.document_number;
            curReg.InternalId = payload.Id;
            curReg.JsonData1 = payload.document_info  == null ? JsonConvert.SerializeObject(payload) :  JsonConvert.SerializeObject(payload.document_info);
            curReg.JsonData2 = "";
            curReg.Site = (payload.site == null) ? "" : payload.site;
            curReg.Source = payload.source;
            curReg.StatusId = 0;  //0 Pending
            curReg.Tags = payload.tags;

            _db.Add(curReg);
            
            _db.SaveChanges();
        }

        public void SaveStock(SyncRequest payload)
        {
            //Grabar el Objeto v2_api_document_work

            V2ApiStock curReg = new V2ApiStock();

            curReg.Site = payload.site;
            curReg.Item = payload.document_number;
            curReg.LoteSn = payload.Id;
            curReg.Qty = (int)payload.qty;

            _db.Add(curReg);

            _db.SaveChanges();
        }


        public void SaveStock_OLD(SyncRequest payload)
        {
           
            //Grabar el Objeto v2_api_document_work

            V2ApiDocumentWork curReg = new V2ApiDocumentWork();

            DataTable myDataTable  = JsonConvert.DeserializeObject<DataTable>(payload.document_info);

            /*
            "ItemCode": "3023-0021-03",
            "MdAbsEntry": 1962,
            "MnfSerial": "10 - IMP338",
            "Quantity": 1.0,
            "WhsCode": "B32"
            */

            string connectionString = "";

            //save datatable to SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach (DataColumn c in myDataTable.Columns)
                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    bulkCopy.DestinationTableName = payload.document_type; //myDataTable.TableName;

                    try
                    {
                        bulkCopy.WriteToServer(myDataTable);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }
    }
}
