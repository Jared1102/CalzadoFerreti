namespace EntidadesCalzadoFerreti
{
    public class Apartados
    {
        public Apartados(int fkIdVenta, int fkIdCalzado, int cantidadApartada)
        {
            FkIdVenta = fkIdVenta;
            FkIdCalzado = fkIdCalzado;
            CantidadApartada = cantidadApartada;
        }

        public int FkIdVenta { get; set; }
        public int FkIdCalzado { get; set; }
        public int CantidadApartada { get; set; }
    }
}
