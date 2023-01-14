//using wms_api.Models;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Text;
using wms_api.Models;

namespace wms_api.Utils
{
    public class _WEB
    {

        public WMS_LIGERO_LIVEContext db = new WMS_LIGERO_LIVEContext();
        private readonly IConfiguration _configuration;


        public string _db_cnn { get; set; }

        public _WEB()
        {

            db = new WMS_LIGERO_LIVEContext();

            string conString = db.Database.GetConnectionString();

            _db_cnn = conString;

        }


        public _WEB(IConfiguration configuration)
        {
            _configuration = configuration;

            db = new WMS_LIGERO_LIVEContext();

            string conString = _configuration.GetConnectionString("DefaultConnection");

            _db_cnn = conString;

        }

        public DataSet sp_Auth(string ACTION, SUsuario curUser)
        {
            string queryCmd = String.Format("EXEC v2_AUTH @ACTION='{0}', @USERNAME='{1}', @ROWIDUSER = {2}",
                  new object[] { ACTION, curUser.NombreUsuario, curUser.Rowid });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }


        public DataSet sp_Shipping(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_SHIPPING @ACTION='{0}', @SESSION_ID='{1}', @SITE='{2}', @DOCUMENT='{3}', @USERNAME='{4}', @DATA_CAPTURED = '{5}',  @STEP = {6}",
                  new object[] { ACTION,  whObj.SESSION_ID,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME, whObj.DATA_CAPTURED, whObj.STEP  });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }


        public DataSet sp_Receiving(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_RECEIVING @ACTION='{0}', @SESSION_ID='{1}', @SITE='{2}', @DOCUMENT='{3}', @USERNAME='{4}', @DATA_CAPTURED = '{5}',  @STEP = {6}",
                  new object[] { ACTION,  whObj.SESSION_ID,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME, whObj.DATA_CAPTURED, whObj.STEP  });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }

        public string sp_executeReader(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_SHIPPING @ACTION='{0}', @SESSION_ID='{1}', @SITE='{2}', @DOCUMENT='{3}', @USERNAME='{4}', @DATA_CAPTURED = '{5}',  @STEP = {6}",
                  new object[] { ACTION,  whObj.SESSION_ID,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME, whObj.DATA_CAPTURED, whObj.STEP  });


            SqlConnection sqCnn = new SqlConnection(_db_cnn);

            var cmd = new SqlCommand(queryCmd, sqCnn);
            var jsonResult = new StringBuilder();

            sqCnn.Open();

            var reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                jsonResult.Append("[]");
            }
            else
            {
                while (reader.Read())
                {
                    jsonResult.Append(reader.GetValue(0).ToString());
                }
            }

            sqCnn.Close();

            return jsonResult.ToString();

            //DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            //return dsResult;


        }


        public DataSet sp_Delivery(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_DELIVERY @ACTION='{0}', @SITE='{1}', @DOCUMENT='{2}', @USERNAME='{3}'",
                  new object[] {  ACTION,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }


        public DataSet sp_DeliveryLocal(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_DELIVERY_LOCAL @ACTION='{0}', @SITE='{1}', @DOCUMENT='{2}', @USERNAME='{3}', @SESSION_ID='{4}'",
                  new object[] { ACTION, whObj.SITE, whObj.DOCUMENT, whObj.USERNAME, whObj.SESSION_ID });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }


        public DataSet sp_Report(string ACTION, WH_Obj whObj)
        {
            string queryCmd = "";

            if (whObj.SESSION_ID == "CUSTOM")
            {
                queryCmd = String.Format("EXEC v2_{0} @OPTION='{1}', @SITE='{2}', @DATA_CAPTURED='{3}', @USERNAME='{4}'",
                  new object[] { whObj.DOCUMENT,  ACTION, whObj.SITE, whObj.DATA_CAPTURED,
                      whObj.USERNAME });
            }
            else
                queryCmd = String.Format("EXEC v2_REPORTS @ACTION='{0}', @SITE='{1}', @REPORT_ID='{2}', @USERNAME='{3}'",
                  new object[] {  ACTION,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }

        public DataSet sp_InventoryBinChange(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_INVENTORY_BIN_CHANGE @ACTION='{0}', @DOCUMENT='{1}',  @USERNAME='{2}',  @SESSION_ID='{3}', @DATA_CAPTURED = '{4}',  @STEP = {5},  @SITE = '{6}'   ",
                  new object[] { ACTION, whObj.DOCUMENT, whObj.USERNAME, whObj.SESSION_ID, whObj.DATA_CAPTURED, whObj.STEP, whObj.SITE });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }


        public DataSet sp_DataCapture(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_DATA_CAPTURE @ACTION='{0}', @SITE='{1}',  @DOCUMENT='{2}',  @USERNAME='{3}',  @SESSION_ID='{4}',  @ID_PROCESO ='{5}',  @DATA_CAPTURED = '{6}',  @STEP = {7}  ",
                  new object[] {  ACTION,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME, whObj.SESSION_ID ,   whObj.ID_PROCESS, whObj.DATA_CAPTURED, whObj.STEP, whObj.OPTION});

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }


        public DataSet sp_Master(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_MASTER @ACTION='{0}', @SITE='{1}',  @DOCUMENT='{2}',  @USERNAME='{3}',  @SESSION_ID='{4}',  @DATA_CAPTURED = '{5}'  ",
                  new object[] {  ACTION,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME, whObj.SESSION_ID ,  whObj.DATA_CAPTURED}); ;

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }

        public DataSet sp_Integration(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_INTEGRATION @ACTION='{0}', @SESSION_ID='{1}', @SITE='{2}', @DOCUMENT='{3}', @USERNAME='{4}', @DATA_CAPTURED = '{5}',  @STEP = {6}",
                  new object[] { ACTION,  whObj.SESSION_ID,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME, whObj.DATA_CAPTURED, whObj.STEP  });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }

        public DataSet sp_UTIL_Notification(string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC UTIL_Notification @option='{0}', @Email='{1}', @Guid='{2}', @Extra_Data1='{3}', @Extra_Data2='{4}'",
                  new object[] { ACTION, whObj.USERNAME, whObj.SESSION_ID, whObj.DOCUMENT, whObj.DATA_CAPTURED });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }

        public DataSet sp_Default(string PROCEDURE, string ACTION, WH_Obj whObj)
        {
            string queryCmd = String.Format("EXEC v2_{0} @ACTION='{1}', @SESSION_ID='{2}', @SITE='{3}', @DOCUMENT='{4}', @USERNAME='{5}', @DATA_CAPTURED = '{6}',  @STEP = {7}",
                  new object[] { PROCEDURE, ACTION,  whObj.SESSION_ID,  whObj.SITE, whObj.DOCUMENT,
                      whObj.USERNAME, whObj.DATA_CAPTURED, whObj.STEP  });

            DataSet dsResult = SQLBase.ReturnDataSet(queryCmd, new SqlConnection(_db_cnn));

            return dsResult;
        }
    }
}
