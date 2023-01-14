using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MImage
    {
        public int Rowid { get; set; }
        public string Class { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageBinary { get; set; }
        public byte[] ImageBinary1 { get; set; }
        public byte[] ImageBinary2 { get; set; }
    }
}
