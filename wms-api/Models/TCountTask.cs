using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TCountTask
    {
        public TCountTask()
        {
            TCountTaskCurrstocks = new HashSet<TCountTaskCurrstock>();
            TCountTaskItems = new HashSet<TCountTaskItem>();
            TCountTaskPosteds = new HashSet<TCountTaskPosted>();
            TCountTaskRuntimes = new HashSet<TCountTaskRuntime>();
        }

        public int Rowid { get; set; }
        public string Site { get; set; }
        public string Tasknumber { get; set; }
        public int Statusid { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Confirmedby { get; set; }
        public DateTime? Confirmedon { get; set; }
        public string Postedby { get; set; }
        public DateTime? Postedon { get; set; }
        public string Note { get; set; }
        public short AllItems { get; set; }
        public string CountType { get; set; }
        public string Schedule { get; set; }
        public DateTime? DaySchedule { get; set; }
        public string ProcessStatus { get; set; }
        public DateTime? PostedonWms { get; set; }
        public string PostedbyWms { get; set; }
        public DateTime? PostedonErp { get; set; }
        public string PostedbyErp { get; set; }

        public virtual MEstado Status { get; set; }
        public virtual ICollection<TCountTaskCurrstock> TCountTaskCurrstocks { get; set; }
        public virtual ICollection<TCountTaskItem> TCountTaskItems { get; set; }
        public virtual ICollection<TCountTaskPosted> TCountTaskPosteds { get; set; }
        public virtual ICollection<TCountTaskRuntime> TCountTaskRuntimes { get; set; }
    }
}
