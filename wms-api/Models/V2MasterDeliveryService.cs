using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2MasterDeliveryService
    {
        public V2MasterDeliveryService()
        {
            V2OpeDocuments = new HashSet<V2OpeDocument>();
        }

        public int Rowid { get; set; }
        public string CompanyCode { get; set; }
        public string ServiceCode { get; set; }
        public string SetupName { get; set; }
        public string SetupAttibutesScheme { get; set; }
        public string SetupAttibutesValue { get; set; }
        public short IndActive { get; set; }
        public short IndPackingConsolidated { get; set; }
        public short IndPackinglist { get; set; }
        public short IndPkglabels { get; set; }
        public int? RowidPrinterPackinglist { get; set; }
        public int? RowidPrinterPkglabels { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }

        public virtual V2MasterConnection RowidPrinterPackinglistNavigation { get; set; }
        public virtual V2MasterConnection RowidPrinterPkglabelsNavigation { get; set; }
        public virtual ICollection<V2OpeDocument> V2OpeDocuments { get; set; }
    }
}
