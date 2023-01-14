using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class ZShippingErpDoc
    {
        public string Company { get; set; }
        public string OriDoc { get; set; }
        public string Docid { get; set; }
        public string Docnumber { get; set; }
        public string Accountname { get; set; }
        public string Accountid { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptoaddress { get; set; }
        public string Docdate { get; set; }
        public string Createdby { get; set; }
        public int Statusid { get; set; }
        public string StatusName { get; set; }
        public string Site { get; set; }
        public string Note { get; set; }
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
        public string Contact { get; set; }
        public string Doctype { get; set; }
        public string BillingType { get; set; }
        public string Backorder { get; set; }
        public string Emailcontact { get; set; }
        public string ServAgentCode { get; set; }
        public string SalesrepMail { get; set; }
        public string Createuser { get; set; }
        public decimal Totalprice { get; set; }
        public string Payterm { get; set; }
        public string Paymethod { get; set; }
        public int SignatureReq { get; set; }
        public int Addresstype { get; set; }
        public int InsideDeliv { get; set; }
        public int LiftDeliv { get; set; }
        public int Oversize { get; set; }
        public DateTime? Promiseddate { get; set; }
        public string Wbroker { get; set; }
        public string ImpName { get; set; }
        public string ImpAddress { get; set; }
        public string ImpCity { get; set; }
        public string ImpState { get; set; }
        public string ImpCountry { get; set; }
        public string ImpZip { get; set; }
        public string ImpPhone { get; set; }
    }
}
