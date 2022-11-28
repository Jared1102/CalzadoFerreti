using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoVentas : IEntidades
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteVentas({0})", Entidad.IdVenta));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateVentas({0},'{1}',{2},{3},'{4}',{5})", Entidad.IdVenta, Entidad.Fecha, Entidad.Monto, Entidad.Saldo, Entidad.Estado, Entidad.FkIdCliente));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("p_showVentas('%{0}%')", filtro), "ventas");
        }
    }
}