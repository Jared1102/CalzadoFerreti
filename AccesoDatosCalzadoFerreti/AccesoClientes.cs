using System;
using System.Data;
using ConectarBd;
namespace AccesoDatosCalzadoFerreti
{
    public class AccesoClientes : IEntidades
    {
        Base b = new Base("localhost", "root", "", "");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_deleteClientes({0})", Entidad.IdCliente));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call p_insertOrUpdateSalidas({0},'{1}','{2}','{3}','{4}')", Entidad.IdCliente, Entidad.Nombre, Entidad.Telefono, Entidad.Correo, Entidad.Direccion));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("p_showClientes('%{0}%')", filtro), "clientes");
        }
    }
}