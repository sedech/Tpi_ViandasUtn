namespace ViandasUtn
{
    public class Pedido           
    {
        
        public int Id { get; set; }
        public string FechaPedido { get; set; }
        public string FechaRetiro { get; set; }
        public List<Producto> Productos { get; set; }
        
        public Pedido(int id, string fechaPedido, string fechaRetiro, List<Producto> productos)
           
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
