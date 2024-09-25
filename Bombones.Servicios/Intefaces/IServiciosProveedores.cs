﻿using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosProveedores
    {
        void Borrar(int proveedorId);
        //bool EstaRelacionado(int clienteId);
        bool Existe(Proveedor proveedor);
        List<ProveedorListDto> GetLista(int currentPage, int pageSize, Func<ProveedorListDto, bool>? filter = null);
        void Guardar(Proveedor proveedor);
        Proveedor? GetProveedorPorId(int proveedorId);
        int GetCantidad(Func<ProveedorListDto, bool>? filter = null);
    }
}
