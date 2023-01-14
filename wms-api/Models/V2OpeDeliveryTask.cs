using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeDeliveryTask
    {
        public V2OpeDeliveryTask()
        {
            V2OpeDeliveryTaskDetails = new HashSet<V2OpeDeliveryTaskDetail>();
        }

        public int Rowid { get; set; }
        public string Guid { get; set; }
        public int RowidUserDriver { get; set; }
        public int RowidVehicle { get; set; }
        public int TotalPackages { get; set; }
        public int IdEstado { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public DateTime? Deliverystarton { get; set; }
        public string Deliverystartby { get; set; }
        public DateTime? Completedon { get; set; }
        public string Completedby { get; set; }

        public virtual V2MasterVehicle RowidVehicleNavigation { get; set; }
        public virtual ICollection<V2OpeDeliveryTaskDetail> V2OpeDeliveryTaskDetails { get; set; }
    }
}
