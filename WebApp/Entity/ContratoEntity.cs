using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ContratoEntity
    {
        public ContratoEntity()
        {
            Empleado = Empleado ?? new OrdenEntity();
        }

        public int? IdContrato { get; set; }
        public int? IdEmpleado { get; set; }
        public virtual OrdenEntity Empleado { get; set; }
        public string TipoContrato { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFin { get; set; } = DateTime.Now;
    }
}
