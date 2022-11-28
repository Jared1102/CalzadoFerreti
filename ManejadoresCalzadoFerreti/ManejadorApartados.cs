using Crud;
using AccesoDatosCalzadoFerreti;
using System.Windows.Forms;
using System.Drawing;
using System;
using EntidadesCalzadoFerreti;
namespace ManejadoresCalzadoFerreti
{
    public class ManejadorApartados 
    {
        AccesoApartados aa = new AccesoApartados();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar este registro?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                aa.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            aa.Guardar(Entidad);
            g.Mensaje("Apartado Guardado", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, int filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = aa.Mostrar(filtro).Tables["apartados"];
            tabla.Columns.Insert(3, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
        }
    }
}
