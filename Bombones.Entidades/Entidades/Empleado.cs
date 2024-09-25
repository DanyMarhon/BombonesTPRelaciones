using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Entidades.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public DateTime FechaContratacion { get; set; }

        // Relacion
        public Direccion? Direccion { get; set; }

    }
}
