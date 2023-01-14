using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TBarcodePicking
    {
        public TBarcodePicking()
        {
            TBarcodePackings = new HashSet<TBarcodePacking>();
        }

        public int Rowid { get; set; }
        public long Barcode { get; set; }
        public string Company { get; set; }
        public string Site { get; set; }
        public string Bincode { get; set; }
        public string Item { get; set; }
        public string Lot { get; set; }
        public double Quantity { get; set; }
        public string Uom { get; set; }
        public string Erpdoc { get; set; }
        public int Erpdocline { get; set; }
        public string Confirmdoc { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Completedby { get; set; }
        public DateTime? Completedon { get; set; }
        public string Postedby { get; set; }
        public DateTime? Postedon { get; set; }
        public double? QtyRemoved { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }
        public string Sessionid { get; set; }
        public string Cancelby { get; set; }
        public DateTime? Cancelon { get; set; }
        public string TmpGuid { get; set; }
        public string Notes { get; set; }
        public DateTime? Releaseon { get; set; }
        public string Releaseby { get; set; }

        public virtual ICollection<TBarcodePacking> TBarcodePackings { get; set; }
    }
}
