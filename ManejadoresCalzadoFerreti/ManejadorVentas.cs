using Crud;
using AccesoDatosCalzadoFerreti;
using System.Windows.Forms;
using System.Drawing;
using System;
using EntidadesCalzadoFerreti;
namespace ManejadoresCalzadoFerreti
{
    public class ManejadorVentas
    {
        AccesoVentas av = new AccesoVentas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar este registro?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                av.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            av.Guardar(Entidad);
            g.Mensaje("Venta Guardada", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = av.Mostrar(filtro).Tables["ventas"];
            tabla.Columns.Insert(6, g.Boton("Ver PDF", Color.Red));
            tabla.Columns.Insert(7, g.Boton("$", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Green));
            tabla.AutoResizeColumns();
        }
        public void Mostrar2(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = av.Mostrar(filtro).Tables["ventas"];
            tabla.Columns.Insert(6, g.Boton("Surtir", Color.Blue));
            tabla.Columns.Insert(7, g.Boton("Ver Salidas", Color.Green));
            tabla.AutoResizeColumns();
        }
    }
}