using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoCompraXInsumos 
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteCompraXInsumos({0})", Entidad.FkIdCompra,Entidad.FkIdInsumo));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateCompraXInsumos({0},{1},{2},{3},{4},{5})", Entidad.FkIdCompra, Entidad.FkIdInsumo, Entidad.CantidadComprada, Entidad.CantidadRecibida, Entidad.Costo, Entidad.Subtotal));
        }

        public DataSet Mostrar(int filtro)
        {
            return b.Obtener(string.Format("p_showCompraXInsumos({0})", filtro), "compraxinsumos");
        }
    }
}