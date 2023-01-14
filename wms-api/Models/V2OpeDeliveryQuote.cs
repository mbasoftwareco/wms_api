using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeDeliveryQuote
    {
        public int Rowid { get; set; }
        public string Docnumber { get; set; }
        public string CompanyCode { get; set; }
        public string ServiceCode { get; set; }
        public double FreightValue { get; set; }
        public double DeclaredValue { get; set; }
        public string Msg { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public string CodMoneda { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public bool IndError { get; set; }
    }
}
