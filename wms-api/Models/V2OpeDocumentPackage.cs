using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeDocumentPackage
    {
        public int Rowid { get; set; }
        public string Docnumber { get; set; }
        public int RowidPackageType { get; set; }
        public int PackageNum { get; set; }
        public double Weight { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public int Pieces { get; set; }
        public double DimHeight { get; set; }
        public double? DimWidth { get; set; }
        public double? DimLength { get; set; }
        public double? DimVolume { get; set; }
        public decimal? DimVolweight { get; set; }
        public string DeliveryGuid { get; set; }
        public string Deliveryby { get; set; }
        public DateTime? Deliveryon { get; set; }
    }
}
