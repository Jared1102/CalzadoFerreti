using Crud;
using AccesoDatosCalzadoFerreti;
using System.Windows.Forms;
using System.Drawing;
using System;
using EntidadesCalzadoFerreti;
namespace ManejadoresCalzadoFerreti
{
    public class ManejadorSalidas
    {
        AccesoSalidas a = new AccesoSalidas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar este registro?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                a.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            a.Guardar(Entidad);
            g.Mensaje("Salida Guardada", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = a.Mostrar(filtro).Tables["salidas"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
        }
    }
}