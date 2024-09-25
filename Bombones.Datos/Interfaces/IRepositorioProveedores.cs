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
    public interface IRepositorioProveedores
    {
        void Borrar(int proveedorId, SqlConnection conn, SqlTransaction? tran = null);

        void Agregar(Proveedor proveedor, SqlConnection conn, SqlTransaction? tran = null);

        bool Existe(Proveedor proveedor, SqlConnection conn, SqlTransaction? tran = null);

        void Editar(Proveedor proveedor, SqlConnection conn, SqlTransaction? tran = null);
        Proveedor? GetProveedorPorId(int proveedorId, SqlConnection conn);
        List<ProveedorListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<ProveedorListDto, bool>? filter = null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<ProveedorListDto, bool>? filter = null, SqlTransaction? tran = null);
    }
}
