﻿using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoApartados 
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteApartados({0},{1})", Entidad.FkIdVenta,Entidad.FkIdCalzado));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateApartados({0},{1},{2})", Entidad.FkIdVenta, Entidad.FkIdCalzado, Entidad.CantidadApartada));
        }

        public DataSet Mostrar(int filtro)
        {
            return b.Obtener(string.Format("p_showApartados({0})", filtro), "apartados");
        }
    }
}