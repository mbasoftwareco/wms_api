using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwShippingErpDocsTime
    {
        public string Docnumber { get; set; }
        public DateTime? DocDate { get; set; }
        public string Printedon { get; set; }
        public string AssignedTo { get; set; }
        public string Completedon { get; set; }
        public string Completedby { get; set; }
        public string Packedon { get; set; }
        public string Packedby { get; set; }
        public string Postedon { get; set; }
        public string Postedby { get; set; }
        public string Deliveredon { get; set; }
        public string Deliveredby { get; set; }
    }
}
