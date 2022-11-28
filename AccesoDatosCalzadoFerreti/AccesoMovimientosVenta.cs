using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoMovimientosVenta 
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteMovimientosVenta({0},{1})", Entidad.FkIdVenta, Entidad.IdMovimiento));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateMovimientosVenta({0},{1},{2},{3},{4},{5},{6})", Entidad.FkIdVenta, Entidad.IdMovimiento, Entidad.CantidadVendida, Entidad.CantidadEntregada, Entidad.Precio, Entidad.Subtotal, Entidad.FkIdCalzado));
        }

        public DataSet Mostrar(int filtro)
        {
            return b.Obtener(string.Format("p_showMovimientosVenta({0})", filtro), "movimientosventa");
        }
    }
}
