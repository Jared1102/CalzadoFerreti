using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoEntradas : IEntidades
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteEntradas({0})", Entidad.IdEntrada));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateEntradas({0},'{1}',{2},{3},{4})", Entidad.IdEntrada, Entidad.Fecha, Entidad.Cantidad, Entidad.FkIdCompra, Entidad.FkIdInsumo));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("p_showEntradas('%{0}%')", filtro), "entradas");
        }
    }
}