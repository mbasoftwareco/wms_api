using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2MasterVehicle
    {
        public V2MasterVehicle()
        {
            V2OpeDeliveryTasks = new HashSet<V2OpeDeliveryTask>();
        }

        public int Rowid { get; set; }
        public string Tag { get; set; }
        public string TypeCode { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Modifiedby { get; set; }

        public virtual ICollection<V2OpeDeliveryTask> V2OpeDeliveryTasks { get; set; }
    }
}
