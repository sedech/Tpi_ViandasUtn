namespace ViandasUtn
{
    public class Pedido           
    {
        /*
         como definir el atributo horario si con DateTime
      
         */
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaRetiro { get; set; }
        public List<Producto> Productos { get; set; }
        
        public Pedido(int idPedido, DateTime fechaPedido, DateTime fechaRetiro, List<Producto> productos)
           
        {
            IdPedido = idPedido;    
            FechaPedido = fechaPedido;
            FechaRetiro = fechaRetiro;
        }

        public void HacerPedido()
        {

        }

        public void ModificarPedido()
        {

        }

        public void BorrarPedido()
        {

        }

        public void GenerarFactura()
        {

        }




    }
}
