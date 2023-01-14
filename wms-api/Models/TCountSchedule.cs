using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TCountSchedule
    {
        public TCountSchedule()
        {
            TCountScheduleDays = new HashSet<TCountScheduleDay>();
        }

        public int Rowid { get; set; }
        public string Docid { get; set; }
        public int Statusid { get; set; }
        public string Site { get; set; }
        public string CountMethod { get; set; }
        public string Frequency { get; set; }
        public DateTime StarDate { get; set; }
        public string Period { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }

        public virtual ICollection<TCountScheduleDay> TCountScheduleDays { get; set; }
    }
}
