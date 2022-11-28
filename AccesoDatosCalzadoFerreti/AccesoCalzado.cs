using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoCalzado : IEntidades
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteCalzado({0})", Entidad.IdCalzado));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateCalzado({0},'{1}',{2},{3},'{4}')", Entidad.IdCalzado, Entidad.Descripcion, Entidad.Precio, Entidad.Costo, Entidad.Existencia));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("p_showCalzado('%{0}%')", filtro), "calzado");
        }
    }
}