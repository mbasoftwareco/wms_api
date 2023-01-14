using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwTaskAssignOpen
    {
        public string Doctype { get; set; }
        public string Site { get; set; }
        public string Docid { get; set; }
        public string Accountname { get; set; }
        public string Accountid { get; set; }
        public string Docdate { get; set; }
        public string Note { get; set; }
        public string Fgcolor { get; set; }
        public DateTime? Rls { get; set; }
        public string Pcs { get; set; }
        public string Shpvia { get; set; }
        public string Agentservice { get; set; }
        public string To { get; set; }
        public int ExportType { get; set; }
        public string Acctype { get; set; }
        public string Agentcode { get; set; }
        public string Doclink { get; set; }
        public string Esh { get; set; }
        public DateTime? Edl { get; set; }
        public string FgAlert { get; set; }
        public string Backorder { get; set; }
        public int IsBkord { get; set; }
        public int Ptype { get; set; }
        public int HasStock { get; set; }
        public int Expedited { get; set; }
        public string Reqdelivery { get; set; }
        public decimal Totalprice { get; set; }
    }
}
