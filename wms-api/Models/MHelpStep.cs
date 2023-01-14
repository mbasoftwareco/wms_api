using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MHelpStep
    {
        public int Rowid { get; set; }
        public string Process { get; set; }
        public string Type { get; set; }
        public int Step { get; set; }
        public string Title { get; set; }
        public string TextEn { get; set; }
        public string TextEs { get; set; }
        public string Image { get; set; }
        public int? Height { get; set; }
        public int IndActivo { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
    }
}
