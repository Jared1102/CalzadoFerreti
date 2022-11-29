using Crud;
using AccesoDatosCalzadoFerreti;
using System.Windows.Forms;
using System.Drawing;
using System;
using EntidadesCalzadoFerreti;
namespace ManejadoresCalzadoFerreti
{
    public class ManejadorCompras
    {
        AccesoCompras ac = new AccesoCompras();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar este registro?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ac.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            ac.Guardar(Entidad);
            g.Mensaje("Compra Guardada", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ac.Mostrar(filtro).Tables["compras"];
            tabla.Columns.Insert(5, g.Boton("Ver PDF", Color.Red));
            tabla.Columns.Insert(6, g.Boton("$", Color.Green));
            tabla.Columns.Insert(7, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
        }
        public void Mostrar2(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ac.Mostrar(filtro).Tables["compras"];
            tabla.Columns.Insert(5, g.Boton("Surtir", Color.Blue));
            tabla.Columns.Insert(6, g.Boton("Ver Entradas", Color.Green));
            tabla.AutoResizeColumns();
        }
    }
}