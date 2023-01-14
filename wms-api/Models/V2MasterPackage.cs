using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2MasterPackage
    {
        public int Rowid { get; set; }
        public string PackageName { get; set; }
        public double MaxWeight { get; set; }
        public double DimHeight { get; set; }
        public double DimWidth { get; set; }
        public double DimLength { get; set; }
        public double DimVolume { get; set; }
        public short IndAllowChilds { get; set; }
        public short IndAllowEdit { get; set; }
        public short? IndActive { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedby { get; set; }
    }
}
