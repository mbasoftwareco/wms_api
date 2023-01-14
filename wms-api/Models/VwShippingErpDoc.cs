using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwShippingErpDoc
    {
        public string Company { get; set; }
        public string OriDoc { get; set; }
        public string Docid { get; set; }
        public string Docnumber { get; set; }
        public string Accountid { get; set; }
        public string Accountname { get; set; }
        public DateTime Docdate { get; set; }
        public string Createdby { get; set; }
        public int Statusid { get; set; }
        public string StatusName { get; set; }
        public string Site { get; set; }
        public string Note { get; set; }
        public string Customerpo { get; set; }
        public string Reqdelivery { get; set; }
        public string Shiptoname { get; set; }
        public string Addrline1 { get; set; }
        public string Addrline2 { get; set; }
        public string Addrline3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Freightacc { get; set; }
        public string ProcessStatus { get; set; }
        public DateTime Releasedate { get; set; }
        public string Agentcode { get; set; }
        public string Agentservice { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Doctype { get; set; }
        public string BillingType { get; set; }
        public string Backorder { get; set; }
        public string Emailcontact { get; set; }
        public string ServAgentCode { get; set; }
        public string SalesrepMail { get; set; }
        public int Totalprice { get; set; }
        public DateTime? Completedon { get; set; }
        public string Completedby { get; set; }
        public string Picker { get; set; }
        public DateTime? Packedon { get; set; }
        public string Packedby { get; set; }
        public string Packer { get; set; }
        public string Numlines { get; set; }
        public int? Numpending { get; set; }
        public decimal? Progress { get; set; }
        public int ProgressPacking { get; set; }
        public string Payterm { get; set; }
        public string Paymethod { get; set; }
        public string SignatureReq { get; set; }
        public string Addresstype { get; set; }
        public string InsideDeliv { get; set; }
        public string LiftDeliv { get; set; }
        public string Oversize { get; set; }
        public int? Promiseddate { get; set; }
        public string Wbroker { get; set; }
        public string ImpName { get; set; }
        public string ImpAddress { get; set; }
        public string ImpCity { get; set; }
        public string ImpState { get; set; }
        public string ImpCountry { get; set; }
        public string ImpZip { get; set; }
        public string ImpPhone { get; set; }
        public string Invoiceid { get; set; }
        public string Docsubtype { get; set; }
        public int IndPacking { get; set; }
        public int IndRollbackPacking { get; set; }
        public int IndRollbackPicking { get; set; }
        public int IndConfirm { get; set; }
        public int IndRollbackConfirm { get; set; }
        public int IndErp { get; set; }
        public int IndRollbackErp { get; set; }
        public int IndPicking { get; set; }
        public int? IndPriority { get; set; }
        public string Tags { get; set; }
        public string CompletedonText { get; set; }
        public string PackedonText { get; set; }
        public string Docentry { get; set; }
        public string Docentry2 { get; set; }
        public int StatusId1 { get; set; }
        public DateTime? Deliveredon { get; set; }
        public string Deliveredby { get; set; }
        public string AlternSite { get; set; }
        public int IndCancel { get; set; }
    }
}
