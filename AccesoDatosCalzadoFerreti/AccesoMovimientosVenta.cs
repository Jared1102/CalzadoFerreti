using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoMovimientosVenta 
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteMovimientosVenta({0})", Entidad.FkIdVenta));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateMovimientosVenta({0},{1},{2},{3},{4},{5},{6})", Entidad.FkIdVenta, Entidad.IdMovimiento, Entidad.CantidadVendida, Entidad.CantidadEntregada, Entidad.Precio, Entidad.Subtotal, Entidad.FkIdCalzado));
        }

        public DataSet Mostrar(int fkidventa)
        {
            return b.Obtener(string.Format("call p_showMovimientosVenta({0})", fkidventa), "movimientosventa");
        }
    }
}
