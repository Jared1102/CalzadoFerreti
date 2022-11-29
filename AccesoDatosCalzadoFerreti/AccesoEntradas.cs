using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoEntradas 
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");

        public void Borrar(int fkidcompra)
        {
            b.Comando(String.Format("call p_deleteEntradas({0})", fkidcompra));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateEntradas({0},{1},'{2}',{3},{4},{5})", Entidad.IdEntrada,Entidad.IdMovimientoEntrada, Entidad.Fecha, Entidad.Cantidad, Entidad.FkIdCompra, Entidad.FkIdInsumo));
        }

        public DataSet Mostrar(int identrada)
        {
            return b.Obtener(string.Format("call p_showEntradas({0})", identrada), "entradas");
        }
        public DataSet MostrarUnitarias(int fkidcompra)
        {
            return b.Obtener(string.Format("call p_showEntradasUnitarias({0})", fkidcompra), "entradas");
        }
        public DataSet MostrarUnitarias2()
        {
            return b.Obtener("call p_showEntradasUnitarias2()", "entradas");
        }
    }
}