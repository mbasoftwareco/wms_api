using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class ZReceivingErpDocsLine
    {
        public string Company { get; set; }
        public string Site { get; set; }
        public string Docnumber { get; set; }
        public string Docid { get; set; }
        public string Accountname { get; set; }
        public string Accountid { get; set; }
        public string Docdate { get; set; }
        public string Itemcode { get; set; }
        public string Itemid { get; set; }
        public string Itemname { get; set; }
        public string Unitid { get; set; }
        public string Lineid { get; set; }
        public decimal? Qtyorder { get; set; }
        public decimal? Qtyreceived { get; set; }
        public double Qtyonprocess { get; set; }
        public double QtyToErp { get; set; }
        public decimal? Qtypending { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string RequireLotno { get; set; }
        public string Upc { get; set; }
        public int? Rowid { get; set; }
        public string Createdby { get; set; }
        public int Doctypeid { get; set; }
        public decimal? QtyOutstanding { get; set; }
        public decimal? QtyToReceive { get; set; }
    }
}
