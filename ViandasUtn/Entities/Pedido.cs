namespace ViandasUtn
{
    public class Pedido           
    {
        /*
         como definir el atributo horario si con DateTime
      
         */
        public DateTime FechaPedido { get; set; }
        public DateTime HorarioRetirado { get; set; }
        public List<Producto> courses = new List<Producto>();
        public int IdPedido { get; set;}
        public Pedido(DateTime fechaPedido, DateTime horarioRetirado, List<Producto> Producto)
            : base(fechaPedido, horarioRetirado)
        {
            FechaPedido = fechaPedido;
            HorarioRetirado = horarioRetirado;
        }
    }
}
