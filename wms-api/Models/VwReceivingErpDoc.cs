using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwReceivingErpDoc
    {
        public string Company { get; set; }
        public string Docid { get; set; }
        public string Docnumber { get; set; }
        public string Accountid { get; set; }
        public string Accountname { get; set; }
        public string Docdate { get; set; }
        public int Statusid { get; set; }
        public string StatusName { get; set; }
        public DateTime Eta { get; set; }
        public string Note { get; set; }
        public string Createdby { get; set; }
        public string Site { get; set; }
        public int? Lines { get; set; }
        public int? LinesPending { get; set; }
        public DateTime? ArrivedOn { get; set; }
        public string Doctype { get; set; }
        public string Wmscustom { get; set; }
        public int NavStatus { get; set; }
        public int NumOrd { get; set; }
    }
}
