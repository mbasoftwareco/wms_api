using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeDeliveryTaskDetail
    {
        public int Rowid { get; set; }
        public int RowidDeliveryTask { get; set; }
        public int RowidPacking { get; set; }
        public string Docnumber { get; set; }
        public int IdEstado { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public DateTime? Completedon { get; set; }
        public string Completedby { get; set; }
        public string Receivedby { get; set; }
        public string ReceivedSupport { get; set; }

        public virtual V2OpeDeliveryTask RowidDeliveryTaskNavigation { get; set; }
        public virtual TBarcodePacking RowidPackingNavigation { get; set; }
    }
}
