using System;
using System.Data;
namespace AccesoDatosCalzadoFerreti
{
    public interface IEntidades
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
