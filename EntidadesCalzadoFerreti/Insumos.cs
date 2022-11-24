namespace EntidadesCalzadoFerreti
{
    public class Insumos
    {
        public Insumos(int idInsumo, string descripcion, int existencia, double costos, int insumoXPar)
        {
            IdInsumo = idInsumo;
            Descripcion = descripcion;
            Existencia = existencia;
            Costos = costos;
            InsumoXPar = insumoXPar;
        }

        public int IdInsumo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public double Costos { get; set; }
        public int InsumoXPar { get; set; }
    }
}
