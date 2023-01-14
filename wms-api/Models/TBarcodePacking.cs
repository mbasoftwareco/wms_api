using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TBarcodePacking
    {
        public TBarcodePacking()
        {
            V2OpeDeliveryTaskDetails = new HashSet<V2OpeDeliveryTaskDetail>();
        }

        public int Rowid { get; set; }
        public int RowidPicking { get; set; }
        public string Erpdoc { get; set; }
        public double Qty { get; set; }
        public string Uom { get; set; }
        public string Package { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Confirmdoc { get; set; }
        public DateTime? Cancelon { get; set; }
        public string Cancelby { get; set; }
        public double? QtyRemoved { get; set; }
        public DateTime? Completedon { get; set; }
        public string Completedby { get; set; }
        public string Pickingdoc { get; set; }

        public virtual TBarcodePicking RowidPickingNavigation { get; set; }
        public virtual ICollection<V2OpeDeliveryTaskDetail> V2OpeDeliveryTaskDetails { get; set; }
    }
}
