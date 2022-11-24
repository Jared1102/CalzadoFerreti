namespace EntidadesCalzadoFerreti
{
    public class Compras
    {
        public Compras(int idCompra, string fecha, double monto, double saldo, string estado)
        {
            IdCompra = idCompra;
            Fecha = fecha;
            Monto = monto;
            Saldo = saldo;
            Estado = estado;
        }

        public int IdCompra { get; set; }
        public string Fecha { get; set; }
        public double Monto { get; set; }
        public double Saldo { get; set; }
        public string Estado { get; set; }
    }
}
