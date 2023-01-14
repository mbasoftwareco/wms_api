using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2WmsDeliveryCompany
    {
        public int Rowid { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string CountryCode { get; set; }
        public short IndPackingConsolidated { get; set; }
        public short IndPackinglist { get; set; }
        public short IndPkglabels { get; set; }
        public string QuoteEndpoint { get; set; }
        public string QuoteEndpoint2 { get; set; }
        public string GuideEndpoint { get; set; }
        public string LabelsEndpoint { get; set; }
        public string TrackingEndpoint { get; set; }
        public string AccountUsername { get; set; }
        public string AccountPassword { get; set; }
        public string AccountCode { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public short? IndActivo { get; set; }
        public short? IndManual { get; set; }
    }
}
