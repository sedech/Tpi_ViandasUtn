namespace ViandasUtn
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        /*
         BD como armar el archivo 
         */
        public Producto(string id, string nombre, float precio, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            /*
             * modelo de datos o domini usuario/precio/ cantidad para el jueves 29 
             * metodos que hacen falta crear usuario, autenticar usuario 
             * diagrama de clase  usuario/nombre/apellido -------------
             */


        }
    }
}
