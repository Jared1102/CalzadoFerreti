namespace EntidadesCalzadoFerreti
{
    public class Entradas
    {
        public Entradas(int idEntrada, string fecha, int cantidad, int fkIdCompra, int fkIdInsumo)
        {
            IdEntrada = idEntrada;
            Fecha = fecha;
            Cantidad = cantidad;
            FkIdCompra = fkIdCompra;
            FkIdInsumo = fkIdInsumo;
        }

        public int IdEntrada { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public int FkIdCompra { get; set; }
        public int FkIdInsumo { get; set; }
    }
}
