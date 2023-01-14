using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MBin
    {
        public int Rowid { get; set; }
        public string Company { get; set; }
        public string Site { get; set; }
        public string Bincode { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public double? Sequence { get; set; }
        public string AisleNo { get; set; }
        public string SectionNo { get; set; }
        public string LevelNo { get; set; }
        public string StatusCode { get; set; }
        public string StatusNotes { get; set; }
        public string LastCountSchedule { get; set; }
        public string LastCountTask { get; set; }
        public DateTime? LastCountDate { get; set; }
    }
}
