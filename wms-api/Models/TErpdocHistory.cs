using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TErpdocHistory
    {
        public int Rowid { get; set; }
        public string Process { get; set; }
        public string Erpsite { get; set; }
        public string Erpdoc { get; set; }
        public string Confirmdoc { get; set; }
        public string Username { get; set; }
        public DateTime Regdate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Error { get; set; }
    }
}
