using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TContainerRuntime
    {
        public int Rowid { get; set; }
        public string Container { get; set; }
        public string Ponumber { get; set; }
        public int Lineid { get; set; }
        public int Linenum { get; set; }
        public int Erpdocline { get; set; }
        public string Site { get; set; }
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Unitid { get; set; }
        public double Qtyorder { get; set; }
        public double Qtyrecvd { get; set; }
        public double Qtypending { get; set; }
        public double Qtypost { get; set; }
        public bool Lock { get; set; }
        public double Qtydiff { get; set; }
        public string Accountid { get; set; }
        public string Accountname { get; set; }
        public string Alert { get; set; }
        public string AlertSelected { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public DateTime? Processedon { get; set; }
        public string ResultMsg { get; set; }
        public string ResultStatus { get; set; }
        public int? PoStatus { get; set; }
        public double Qtyother { get; set; }
        public int? Sequence { get; set; }
        public double Qtypo { get; set; }
        public double Qtytransit { get; set; }
        public string Invoice { get; set; }

        public virtual TContainer ContainerNavigation { get; set; }
    }
}
