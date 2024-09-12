using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {
        void Borrar(int empleadoId, SqlConnection conn, SqlTransaction? tran = null);

        void Agregar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);

        bool Existe(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);

        void Editar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        Empleado? GetEmpleadoPorId(int empleadoId, SqlConnection conn);
        List<EmpleadoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null);
    }
}
