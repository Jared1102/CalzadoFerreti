namespace EntidadesCalzadoFerreti
{
    public class Salidas
    {
        public Salidas(int idSalida, int idmovimientoSalida, string fecha, int cantidad, int fkIdVenta, int fkIdMovimiento)
        {
            IdSalida = idSalida;
            IdmovimientoSalida = idmovimientoSalida;
            Fecha = fecha;
            Cantidad = cantidad;
            FkIdVenta = fkIdVenta;
            FkIdMovimiento = fkIdMovimiento;
        }

        public int IdSalida { get; set; }
        public int IdmovimientoSalida { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public int FkIdVenta { get; set; }
        public int FkIdMovimiento { get; set; }
    }
}
