using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwWmsPackingConsolidate
    {
        public string Docid { get; set; }
        public string Doctype { get; set; }
        public string Accountname { get; set; }
        public string Accountid { get; set; }
        public string Note { get; set; }
        public string Acctype { get; set; }
        public string Doclink { get; set; }
        public string Shpvia { get; set; }
        public string BillTo { get; set; }
        public string Backorder { get; set; }
        public string Zipcode { get; set; }
        public string Pickingdoc { get; set; }
        public string Packingdoc { get; set; }
        public DateTime? Packingdate { get; set; }
        public DateTime? Packstarton { get; set; }
        public DateTime? Packedon { get; set; }
        public string Type { get; set; }
    }
}
