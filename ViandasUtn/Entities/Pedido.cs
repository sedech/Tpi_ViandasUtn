namespace ViandasUtn
{
    public class Pedido           
    {
        
        public int Id { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaRetiro { get; set; }
        public List<Producto> Productos { get; set; }
        
        public Pedido(int id, DateTime fechaPedido, DateTime fechaRetiro, List<Producto> productos)
           
        {
            Id  = id;    
            FechaPedido = fechaPedido;
            FechaRetiro = fechaRetiro;
        }

        //public void HacerPedido()
        //{

        //}

        //public void ModificarPedido()
        //{

        //}

        //public void BorrarPedido()
        //{

        //}

        //public void GenerarFactura()
        //{

        //}




    }
}
