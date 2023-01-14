using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TSetupShipcut
    {
        public int Rowid { get; set; }
        public string Notes { get; set; }
        public string CutCode { get; set; }
        public string CutOperator { get; set; }
        public int CutTime { get; set; }
        public int AddDays { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
    }
}
