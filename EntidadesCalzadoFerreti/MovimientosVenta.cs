namespace EntidadesCalzadoFerreti
{
    public class MovimientosVenta
    {
        public MovimientosVenta(int fkIdVenta, int idMovimiento, int cantidadVendida, int cantidadEntregada, double precio, double subtotal, int fkIdCalzado)
        {
            FkIdVenta = fkIdVenta;
            IdMovimiento = idMovimiento;
            CantidadVendida = cantidadVendida;
            CantidadEntregada = cantidadEntregada;
            Precio = precio;
            Subtotal = subtotal;
            FkIdCalzado = fkIdCalzado;
        }

        public int FkIdVenta { get; set; }
        public int IdMovimiento { get; set; }
        public int CantidadVendida { get; set; }
        public int CantidadEntregada { get; set; }
        public double Precio { get; set; }
        public double Subtotal { get; set; }
        public int FkIdCalzado { get; set; }
    }
}
