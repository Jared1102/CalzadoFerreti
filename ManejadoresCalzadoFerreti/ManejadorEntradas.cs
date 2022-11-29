using Crud;
using AccesoDatosCalzadoFerreti;
using System.Windows.Forms;
using System.Drawing;
using System;
using EntidadesCalzadoFerreti;
namespace ManejadoresCalzadoFerreti
{
    public class ManejadorEntradas
    {
        AccesoEntradas ae = new AccesoEntradas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar este registro?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ae.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            ae.Guardar(Entidad);
            g.Mensaje("Entrada Guardada", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ae.Mostrar(filtro).Tables["entradas"];
            //tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            //tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
        }
    }
}