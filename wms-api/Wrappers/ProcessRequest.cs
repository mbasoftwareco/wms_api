using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wms_api.Wrappers
{
    public class ProcessRequest
    {
        public string process { get; set; }
        public string action { get; set; }
        public string site { get; set; }
        public string document { get; set; }
        public string username { get; set; }
        public string session_id { get; set; }
        public int step { get; set; }
        public string data_captured { get; set; }
        public dynamic parameters { get; set; } // ENTIDAD DINAMICA PARA RECIBIR PARMS DE TODOS LOS PROCESOS, SE DEBE HACER EL CAST A CADA CLASE DEL REQUEST QUE CORRESPONDA ProcessShippingRequest
        public string id_process { get; set; }
    }

    public class SyncRequest
    {
        public string Id { get; set; }
        public string source { get; set; }
        public string entity { get; set; }
        public string site { get; set; }
        public string document_type { get; set; }
        public string document_number { get; set; }
        public string document_date { get; set; }
        public dynamic document_info { get; set; }
        public dynamic tags { get; set; }
        public float qty { get; set; }
    }


    public class LoginRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string action { get; set; }
    }


    public class MasterRequest
    {
        public string process { get; set; }
        public string action { get; set; }
        public string site { get; set; }
        public string id { get; set; }
        public dynamic data { get; set; }
        public string username { get; set; }
        public string data_captured { get; set; }
        public string session_id { get; set; }
    }

    public class SyncBatch
    {
        public string guid { get; set; }
        public string username { get; set; }
    }
}