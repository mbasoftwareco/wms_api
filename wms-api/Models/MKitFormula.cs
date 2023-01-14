using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MKitFormula
    {
        public int RowId { get; set; }
        public string ItemcodeKit { get; set; }
        public string ItemcodeComponent { get; set; }
        public string Uom { get; set; }
        public int Seq { get; set; }
        public int IndActive { get; set; }
        public double FormulaQty { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
