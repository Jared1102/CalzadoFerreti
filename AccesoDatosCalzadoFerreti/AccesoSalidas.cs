using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoSalidas : IEntidades
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteSalidas({0})", Entidad.IdSalida));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateSalidas({0},'{1}',{2},{3},{4})", Entidad.IdSalida, Entidad.Fecha, Entidad.Cantidad, Entidad.FkIdVenta,Entidad.FkIdMovimiento));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("p_showSalidas('%{0}%')", filtro), "salidas");
        }
    }
}
