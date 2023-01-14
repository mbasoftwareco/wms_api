using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class PrydeVwShippingErpDocsLine
    {
        public string Company { get; set; }
        public string Site { get; set; }
        public string OriDoc { get; set; }
        public string Docnumber { get; set; }
        public string Docid { get; set; }
        public string Docdate { get; set; }
        public string Itemcode { get; set; }
        public string Upc { get; set; }
        public string Itemid { get; set; }
        public string Itemname { get; set; }
        public string Unitid { get; set; }
        public int Lineid { get; set; }
        public decimal? Qtyorder { get; set; }
        public double Qtyonprocess { get; set; }
        public decimal? Qtyshipped { get; set; }
        public decimal? Qtypending { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int? Rowid { get; set; }
        public string RequireLotno { get; set; }
        public decimal? LineWeight { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Doctype { get; set; }
        public int ItemType { get; set; }
        public int HasStock { get; set; }
        public decimal QtyPerUom { get; set; }
    }
}
