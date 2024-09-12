using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosEmpleados
    {
        void Borrar(int empleadoId);
        //bool EstaRelacionado(int clienteId);
        bool Existe(Empleado empleado);
        List<EmpleadoListDto> GetLista(int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null);
        void Guardar(Empleado empleado);
        Empleado? GetEmpleadoPorId(int empleadoId);
        int GetCantidad();
    }
}
