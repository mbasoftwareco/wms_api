using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwShippingErpDocsOpen
    {
        public string OriDoc { get; set; }
        public string Docid { get; set; }
        public string Accountname { get; set; }
        public string Accountid { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptoaddress { get; set; }
        public string Docdate { get; set; }
        public int Statusid { get; set; }
        public string Site { get; set; }
        public string Customerpo { get; set; }
        public string Reqdelivery { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Addrline1 { get; set; }
        public string Addrline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Freightacc { get; set; }
        public int ProcessStatus { get; set; }
        public DateTime? Releasedate { get; set; }
        public string Country { get; set; }
        public string Agentcode { get; set; }
        public string Agentservice { get; set; }
        public string Email { get; set; }
        public string ServAgentCode { get; set; }
        public string SalesrepMail { get; set; }
    }
}
