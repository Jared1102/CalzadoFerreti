using Crud;
using AccesoDatosCalzadoFerreti;
using System.Windows.Forms;
using System.Drawing;
using System;
using EntidadesCalzadoFerreti;
namespace ManejadoresCalzadoFerreti
{
    public class ManejadorInsumos
    {
        AccesoInsumos ai = new AccesoInsumos();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar este registro?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ai.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            ai.Guardar(Entidad);
            g.Mensaje("Insumos Guardados", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ai.Mostrar(filtro).Tables["insumos"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
        }
    }
}