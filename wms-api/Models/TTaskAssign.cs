using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TTaskAssign
    {
        public int Rowid { get; set; }
        public string Picker { get; set; }
        public string Process { get; set; }
        public string Site { get; set; }
        public string Docid { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }
        public string StatusId { get; set; }
        public DateTime SeqDate { get; set; }
        public string Guid { get; set; }
        public string Completedby { get; set; }
        public DateTime? Completedon { get; set; }
        public string TaskAccountid { get; set; }
        public string TaskAccountname { get; set; }
        public int ReopenOrder { get; set; }
        public DateTime? ReopenDate { get; set; }
    }
}
