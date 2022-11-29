using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoCompras : IEntidades
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteCompras({0})", Entidad.IdCompra));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateCompras({0},'{1}',{2},{3},'{4}')", Entidad.IdCompra, Entidad.Fecha, Entidad.Monto, Entidad.Saldo, Entidad.Estado));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call p_showCompras('%{0}%')", filtro), "compras");
        }
    }
}