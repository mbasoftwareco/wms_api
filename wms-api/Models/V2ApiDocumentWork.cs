using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2ApiDocumentWork
    {
        public int Rowid { get; set; }
        public string Source { get; set; }
        public string DocType { get; set; }
        public string Site { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int StatusId { get; set; }
        public string JsonData1 { get; set; }
        public string JsonData2 { get; set; }
        public string InternalId { get; set; }
        public string ItemId { get; set; }
        public string Upc { get; set; }
        public DateTime Credate { get; set; }
        public string Creuser { get; set; }
        public DateTime? Moddate { get; set; }
        public string Moduser { get; set; }
        public string Tags { get; set; }
        public DateTime? ProcessReadedOn { get; set; }
        public DateTime? ProcessCompletedOn { get; set; }
        public string StatusNotes { get; set; }
    }
}
