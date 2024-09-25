using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        public void Agregar(Proveedor proveedor, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int proveedorId, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public void Editar(Proveedor proveedor, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Proveedor proveedor, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(SqlConnection conn, Func<ProveedorListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT * FROM Proveedores";
            var query = conn.Query<ProveedorListDto>(selectQuery).ToList();
            if (filter != null)
            {
                query = query.Where(filter).ToList();
            }
            return query.Count;
        }

        public Proveedor? GetProveedorPorId(int proveedorId, SqlConnection conn)
        {
            string selectQuery = @"SELECT ProveedorId, NombreProveedor, Telefono, Email, FabricaId 
                FROM Proveedores 
                WHERE ProveedorId=@ProveedorId";
            var proveedor = conn.QuerySingleOrDefault<Proveedor>(selectQuery, new { @ProveedorId = proveedorId });

            // Si el proveedor no existe, retornamos null
            if (proveedor == null)
            {
                return null;
            }
            return proveedor;
        }

        public List<ProveedorListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<ProveedorListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery =
                @"SELECT pro.ProveedorId, pro.NombreProveedor, pro.Telefono, pro.Email, 
           fa.NombreFabrica,
           ci.NombreCiudad AS Ciudad,
           pe.NombreProvinciaEstado AS ProvinciaEstado, 
           p.NombrePais AS Pais
          FROM Proveedores pro
          LEFT JOIN Fabricas fa ON pro.FabricaId = fa.FabricaId
          LEFT JOIN Paises p ON fa.PaisId = p.PaisId
          LEFT JOIN ProvinciasEstados pe ON fa.ProvinciaEstadoId = pe.ProvinciaEstadoId
          LEFT JOIN Ciudades ci ON fa.CiudadId = ci.CiudadId";

            var lista = conn.Query<ProveedorListDto, FabricaListDto, ProveedorListDto>(
                selectQuery,
                (proveedor, fabrica) =>
                {
                    // Concatenacion de los campos relacionados con la dirección
                    proveedor.Fabrica = $"{fabrica.NombreFabrica} - {fabrica.NombreCiudad} - {fabrica.NombreProvinciaEstado} - {fabrica.NombrePais}";
                    return proveedor;
                },
                splitOn: "NombreFabrica",  // Punto de split
                transaction: tran
            ).ToList();

            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }

            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}

