using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwShippingErpDocsLinesStock
    {
        public int? Rowid { get; set; }
        public string Docid { get; set; }
        public string Itemcode { get; set; }
        public int HasStock { get; set; }
    }
}
