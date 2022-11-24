namespace EntidadesCalzadoFerreti
{
    public class Clientes
    {
        public Clientes(int idCliente, string nombre, string telefono, string correo, string direccion)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    }
}
