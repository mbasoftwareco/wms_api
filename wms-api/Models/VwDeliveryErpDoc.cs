using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwDeliveryErpDoc
    {
        public string Company { get; set; }
        public string Service { get; set; }
        public string TrackingNo { get; set; }
        public int? Numpackages { get; set; }
        public string Volweight { get; set; }
        public string Weight { get; set; }
        public string Docnumber { get; set; }
        public string Accountname { get; set; }
        public string Docdate { get; set; }
        public string Site { get; set; }
        public string Invoiceid { get; set; }
        public string Accountid { get; set; }
        public string Numlines { get; set; }
        public DateTime? Releaseon { get; set; }
        public string Releaseby { get; set; }
        public DateTime? Postedon { get; set; }
        public string Postedby { get; set; }
        public string Note { get; set; }
        public string ShippingAddress { get; set; }
        public string CityState { get; set; }
        public string ContactName { get; set; }
        public string ContactInfo { get; set; }
        public string TrackingUrl { get; set; }
        public string DeliveryPackinglist { get; set; }
        public string DeliveryLabels { get; set; }
        public DateTime? Completedon { get; set; }
        public string Completedby { get; set; }
        public DateTime? Deliveredon { get; set; }
        public string Deliveredby { get; set; }
        public double FreightValue { get; set; }
    }
}
