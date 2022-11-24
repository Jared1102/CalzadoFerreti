namespace EntidadesCalzadoFerreti
{
    public class CompraXInsumos
    {
        public CompraXInsumos(int fkIdCompra, int fkIdInsumo, int cantidadComprada, int cantidadRecibida, double costo, double subtotal)
        {
            FkIdCompra = fkIdCompra;
            FkIdInsumo = fkIdInsumo;
            CantidadComprada = cantidadComprada;
            CantidadRecibida = cantidadRecibida;
            Costo = costo;
            Subtotal = subtotal;
        }

        public int FkIdCompra { get; set; }
        public int FkIdInsumo { get; set; }
        public int CantidadComprada { get; set; }
        public int CantidadRecibida { get; set; }
        public double Costo { get; set; }
        public double Subtotal { get; set; }
    }
}
