using Bombones.Datos.Interfaces;
using Bombones.Datos.Repositorios;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosProveedores : IServiciosProveedores
    {
        private readonly IRepositorioProveedores _repositorioProveedores;
        private readonly string _cadena;

        public ServiciosProveedores(
            IRepositorioProveedores repositorioProveedores,
            string cadena)
        {
            _repositorioProveedores = repositorioProveedores;
            _cadena = cadena;
        }
        public void Borrar(int proveedorId)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(Func<ProveedorListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioProveedores!.GetCantidad(conn, filter);
            }
        }

        public List<ProveedorListDto> GetLista(int currentPage, int pageSize, Func<ProveedorListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioProveedores.GetLista(conn, currentPage, pageSize, filter);
            }
        }

        public Proveedor? GetProveedorPorId(int proveedorId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                var proveedor = _repositorioProveedores.GetProveedorPorId(proveedorId, conn);
                return proveedor;
            }
        }

        public void Guardar(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
    }
}
