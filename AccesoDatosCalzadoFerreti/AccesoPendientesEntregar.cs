using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoPendientesEntregar 
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deletePendientesEntregar({0})", Entidad.FkIdVenta,Entidad.FkIdCalzado));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdatePendientesEntregar({0},{1},{2})", Entidad.FkIdVenta, Entidad.FkIdCalzado, Entidad.Cantidad));
        }

        public DataSet Mostrar(int filtro)
        {
            return b.Obtener(string.Format("p_showPendientesEntregar({0})", filtro), "pendientesentregar");
        }
    }
}