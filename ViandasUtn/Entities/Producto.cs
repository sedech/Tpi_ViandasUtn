using System.ComponentModel.DataAnnotations;

namespace ViandasUtn
{
    public class Producto
    {
        [Key] // idProducro va a ser la clave primaria del produc
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        

        public Producto(int id, string name, string description, decimal price )
        {
            Id = id;
            Name = name;
            Price = price;
            Description= description;

        }

        
    }
}
