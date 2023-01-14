using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SNotification
    {
        public int Rowid { get; set; }
        public string IdProceso { get; set; }
        public string IdTask { get; set; }
        public string Site { get; set; }
        public string MailTo { get; set; }
        public string Subject { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime? NextSend { get; set; }
        public DateTime? LastSent { get; set; }
        public int? Frequency { get; set; }
        public short? IndActive { get; set; }
    }
}
