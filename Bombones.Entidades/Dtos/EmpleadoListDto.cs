﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Entidades.Dtos
{
    public class EmpleadoListDto
    {

        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? FechaContratacion { get; set; }
        public string? Direccion { get; set; }

    }
}
