using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeDeviceSession
    {
        public int Rowid { get; set; }
        public string DeviceId { get; set; }
        public string SessionId { get; set; }
        public string ProcessId { get; set; }
        public string Docnumber { get; set; }
        public DateTime Credate { get; set; }
        public DateTime? Lastread { get; set; }
    }
}
