using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoSalidas 
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");

        public void Borrar(int fkidventa)
        {
            b.Comando(String.Format("call p_deleteSalidas({0})", fkidventa));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateSalidas({0},{1},'{2}',{3},{4},{5})", Entidad.IdSalida,Entidad.IdmovimientoSalida, Entidad.Fecha, Entidad.Cantidad, Entidad.FkIdVenta,Entidad.FkIdMovimiento));
        }

        public DataSet Mostrar(int idsalida)
        {
            return b.Obtener(string.Format("call p_showSalidas({0})", idsalida), "salidas");
        }
        public DataSet MostrarUnitarias(int fkidventa)
        {
            return b.Obtener(string.Format("call p_showSalidasUnitarias({0})", fkidventa), "salidas");
        }
        public DataSet MostrarUnitarias2()
        {
            return b.Obtener("call p_showSalidasUnitarias2()", "salidas");
        }
    }
}
