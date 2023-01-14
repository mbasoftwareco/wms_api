using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MKitDocumentToPick
    {
        public int Rowid { get; set; }
        public string Docid { get; set; }
        public int Docline { get; set; }
        public string ItemcodeKit { get; set; }
        public string ItemcodeComponent { get; set; }
        public string Uom { get; set; }
        public double ToPick { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
    }
}
