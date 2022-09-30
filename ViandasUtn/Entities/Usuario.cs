namespace ViandasUtn
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        // es necesario el legajo 
        public int Legajo { get; set; }
        public int IdUsuario { get; set; }
        public string Clave { get; set; }

        public Usuario( string nombre, string apellido, int legajo, int idUsuario, string clave)
        {
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;
            IdUsuario = idUsuario;
            Clave = clave;
        }

        public void IniciarSesion()
        {

        }

        public void CerrarSesion()
        {

        }

        public void BorrarUsuario()
        {

        }



    }
}
