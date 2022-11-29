using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoInsumos 
    {
        Base b = new Base("localhost", "root", "", "calzadoferreti");
        public DataSet Mostrar()
        {
            return b.Obtener("call p_showInsumos()", "insumos");
        }
    }
}