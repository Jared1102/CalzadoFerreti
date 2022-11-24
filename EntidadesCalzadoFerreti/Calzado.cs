namespace EntidadesCalzadoFerreti
{
    public class Calzado
    {
        public Calzado(int idCalzado, string descripcion, double precio, double costo, int existencia)
        {
            IdCalzado = idCalzado;
            Descripcion = descripcion;
            Precio = precio;
            Costo = costo;
            Existencia = existencia;
        }

        public int IdCalzado { get; set; }
        public string  Descripcion { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public int Existencia { get; set; }
    }
}
