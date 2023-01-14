using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeDocument
    {
        public int Rowid { get; set; }
        public string Process { get; set; }
        public string Site { get; set; }
        public string Docnumber { get; set; }
        public string AssignedTo { get; set; }
        public short? IndActive { get; set; }
        public DateTime? Printedon { get; set; }
        public string Printedby { get; set; }
        public DateTime? Processon { get; set; }
        public string Processby { get; set; }
        public DateTime? Completedon { get; set; }
        public string Completedby { get; set; }
        public DateTime? Packstarton { get; set; }
        public string Packstartby { get; set; }
        public DateTime? Packedon { get; set; }
        public string Packedby { get; set; }
        public DateTime? Postedon { get; set; }
        public string Postedby { get; set; }
        public string Confirmdoc { get; set; }
        public string Trackingnumber { get; set; }
        public double? ShippingCharges { get; set; }
        public DateTime? ShippingChargesProcessed { get; set; }
        public DateTime Regdate { get; set; }
        public string ConfirmPickingDoc { get; set; }
        public string PackingNotes { get; set; }
        public string PackingPallets { get; set; }
        public string PackingBoxes { get; set; }
        public double PackingWeight { get; set; }
        public string Packingdoc { get; set; }
        public DateTime? Cancelon { get; set; }
        public string Cancelby { get; set; }
        public DateTime? Releaseon { get; set; }
        public string Releaseby { get; set; }
        public string Notes { get; set; }
        public DateTime? Mailsent { get; set; }
        public double? TotalAmount { get; set; }
        public string StatusNotes { get; set; }
        public int IndPriority { get; set; }
        public int? DeliveryRowidService { get; set; }
        public string DeliveryResponse { get; set; }
        public string DeliveryCurrentStatus { get; set; }
        public string DeliveryPackinglist { get; set; }
        public string DeliveryLabels { get; set; }
        public DateTime? Deliveredon { get; set; }
        public string Deliveredby { get; set; }
        public int? IndLock { get; set; }
        public string ReasonLock { get; set; }
        public int? IndEngage { get; set; }
        public string ReasonEngage { get; set; }
        public string Invoice { get; set; }

        public virtual V2MasterDeliveryService DeliveryRowidServiceNavigation { get; set; }
    }
}
