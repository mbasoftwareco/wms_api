using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TPackingPallet
    {
        public int Rowid { get; set; }
        public string Packingdoc { get; set; }
        public string PalletNumber { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double NumberPieces { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime? Cancelon { get; set; }
        public string Cancelby { get; set; }
    }
}
