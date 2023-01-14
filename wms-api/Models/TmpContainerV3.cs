using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TmpContainerV3
    {
        public int RowId { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Xuid { get; set; }
        public short Status { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C5 { get; set; }
        public string C6 { get; set; }
        public string C7 { get; set; }
        public string C8 { get; set; }
        public string C9 { get; set; }
        public string C10 { get; set; }
        public string C11 { get; set; }
        public string C12 { get; set; }
        public string C13 { get; set; }
        public string C14 { get; set; }
        public string C15 { get; set; }
        public string C16 { get; set; }
        public string C17 { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int QtyOriginal { get; set; }
        public int QtyNav { get; set; }
        public int QtyRcvd { get; set; }
        public int QtyPending { get; set; }
        public string AlertNotes { get; set; }
        public string AlertType { get; set; }
        public DateTime? ViewProcess { get; set; }
        public string LineAction { get; set; }
        public string Container { get; set; }
        public int QtyOnPo { get; set; }
    }
}
