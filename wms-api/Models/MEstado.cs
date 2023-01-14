using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MEstado
    {
        public MEstado()
        {
            TCountTasks = new HashSet<TCountTask>();
        }

        public int IdEstado { get; set; }
        public string TipoEstado { get; set; }
        public string NombreEstado { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<TCountTask> TCountTasks { get; set; }
    }
}
