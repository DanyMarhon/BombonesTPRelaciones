using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Entidades.Dtos
{
    public class ProveedorListDto
    {
        public int ProveedorId { get; set; }
        public string? NombreProveedor { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Fabrica { get; set; }
    }
}
