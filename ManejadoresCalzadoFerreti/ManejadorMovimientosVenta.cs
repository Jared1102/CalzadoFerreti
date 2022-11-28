using Crud;
using AccesoDatosCalzadoFerreti;
using System.Windows.Forms;
using System.Drawing;
using System;
using EntidadesCalzadoFerreti;
namespace ManejadoresCalzadoFerreti
{
    public class ManejadorMovimientosVenta
    {
        AccesoMovimientosVenta am = new AccesoMovimientosVenta();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar este registro?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                am.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            am.Guardar(Entidad);
            g.Mensaje("Guardado", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, int filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = am.Mostrar(filtro).Tables["movimientosventa"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
        }
    }
}