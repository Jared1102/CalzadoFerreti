namespace EntidadesCalzadoFerreti
{
    public class PendientesEntregar
    {
        public PendientesEntregar(int fkIdVenta, int fkIdCalzado, int cantidad)
        {
            FkIdVenta = fkIdVenta;
            FkIdCalzado = fkIdCalzado;
            Cantidad = cantidad;
        }

        public int FkIdVenta { get; set; }
        public int FkIdCalzado { get; set; }
        public int Cantidad { get; set; }
    }
}
