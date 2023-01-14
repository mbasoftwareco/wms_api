using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeDocumentLog
    {
        public int Rowid { get; set; }
        public string Process { get; set; }
        public string Action { get; set; }
        public string Site { get; set; }
        public string Docnumber { get; set; }
        public string Confirmdoc { get; set; }
        public string Username { get; set; }
        public DateTime Regdate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Error { get; set; }
    }
}
