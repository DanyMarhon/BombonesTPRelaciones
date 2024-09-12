using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using System.Data.SqlClient;
using Bombones.Datos.Repositorios;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosEmpleados : IServiciosEmpleados
    {
        private readonly IRepositorioEmpleados _repositorioEmpleados;
        private readonly string _cadena;

        public ServiciosEmpleados(
            IRepositorioEmpleados repositorioEmpleados,
            string cadena)
        {
            _repositorioEmpleados = repositorioEmpleados;
            _cadena = cadena;
        }

        public void Borrar(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(Func<EmpleadoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioEmpleados!.GetCantidad(conn, filter);
            }
        }

        public Empleado? GetEmpleadoPorId(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public List<EmpleadoListDto> GetLista(int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioEmpleados.GetLista(conn, currentPage, pageSize, filter);
            }
        }

        public void Guardar(Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}
