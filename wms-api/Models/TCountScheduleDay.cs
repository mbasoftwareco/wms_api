using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TCountScheduleDay
    {
        public int Rowid { get; set; }
        public string Schedule { get; set; }
        public DateTime Day { get; set; }
        public int Statusid { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public int CloseCyclePeriod { get; set; }

        public virtual TCountSchedule ScheduleNavigation { get; set; }
    }
}
