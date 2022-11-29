using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoCompraXInsumos 
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");

        public void Borrar(int FkIdCompra)
        {
            b.Comando(String.Format("call p_deleteCompraXInsumos({0})",FkIdCompra));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateCompraXInsumos({0},{1},{2},{3},{4},{5})", Entidad.FkIdCompra, Entidad.FkIdInsumo, Entidad.CantidadComprada, Entidad.CantidadRecibida, Entidad.Costo, Entidad.Subtotal));
        }

        public DataSet Mostrar(int fkidcompra)
        {
            return b.Obtener(string.Format("call p_showCompraXInsumos({0})", fkidcompra), "compraxinsumos");
        }
    }
}