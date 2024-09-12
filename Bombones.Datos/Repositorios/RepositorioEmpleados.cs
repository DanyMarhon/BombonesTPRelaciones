using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        public void Agregar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int empleadoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public void Editar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(SqlConnection conn, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = "SELECT COUNT(*) FROM Empleados";
            List<string> conditions = new List<string>();

            return conn.ExecuteScalar<int>(selectQuery);
        }

        public Empleado? GetEmpleadoPorId(int empleadoId, SqlConnection conn)
        {
            string selectQuery = @"SELECT EmpleadoId, Nombre, Apellido, FechaContratacion, DireccionId 
                FROM Empleados 
                WHERE EmpleadoId=@EmpleadoId";
            var empleado = conn.QuerySingleOrDefault<Empleado>(selectQuery, new { @EmpleadoId = empleadoId });

            // Si el cliente no existe, retornamos null
            if (empleado == null)
            {
                return null;
            }
            return empleado;
        }

        public List<EmpleadoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery =

                @"SELECT e.EmpleadoId, e.Nombre, e.Apellido, e.FechaContratacion, e.DireccionId,
                           d.Calle, 
                           d.Altura, 
                           ci.NombreCiudad AS Ciudad,
                           pe.NombreProvinciaEstado AS ProvinciaEstado, 
                           p.NombrePais AS Pais
                           FROM Empleados e
                           LEFT JOIN Direcciones d ON e.DireccionId = d.DireccionId
                           LEFT JOIN Paises p ON d.PaisId = p.PaisId
                           LEFT JOIN ProvinciasEstados pe ON d.ProvinciaEstadoId = pe.ProvinciaEstadoId
                           LEFT JOIN Ciudades ci ON d.CiudadId = ci.CiudadId"; 

            var lista = new List<EmpleadoListDto>();
            conn.Query<Empleado, DireccionListDto, EmpleadoListDto>
                (selectQuery,
                    (empleado, direccion) =>
                    {
                        var empleadoDto = lista
                            .FirstOrDefault(e => e.EmpleadoId == empleado.EmpleadoId);
                        if (empleadoDto is null)
                        {
                            empleadoDto = new EmpleadoListDto
                            {
                                EmpleadoId = empleado.EmpleadoId,
                                Nombre = empleado.Nombre,
                                Apellido = empleado.Apellido,
                                FechaContratacion = empleado.FechaContratacion,
                                Direccion = $"{direccion.Calle} - {direccion.Altura} - {direccion.Ciudad} - {direccion.ProvinciaEstado} - {direccion.Pais}"
                            };
                            lista.Add(empleadoDto);
                        }
                        return empleadoDto;
                    },
                    splitOn: "EmpleadoId, Calle"
                );

            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }

            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
