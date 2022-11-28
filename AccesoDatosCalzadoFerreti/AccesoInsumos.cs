using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoInsumos : IEntidades
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteInsumos({0})", Entidad.IdInsumo));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateInsumos({0},'{1}',{2},{3},{4})", Entidad.IdInsumo, Entidad.Descripcion, Entidad.Existencia, Entidad.Costos, Entidad.InsumoXPar));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("p_showInsumos('%{0}%')", filtro), "insumos");
        }
    }
}