namespace EntidadesCalzadoFerreti
{
    public class Ventas
    {
        public Ventas(int idVenta, string fecha, double monto, double saldo, string estado, int fkIdCliente)
        {
            IdVenta = idVenta;
            Fecha = fecha;
            Monto = monto;
            Saldo = saldo;
            Estado = estado;
            FkIdCliente = fkIdCliente;
        }

        public int IdVenta { get; set; }
        public string Fecha { get; set; }
        public double Monto { get; set; }
        public double Saldo { get; set; }
        public string Estado { get; set; }
        public int FkIdCliente { get; set; }
    }
}
