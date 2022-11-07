using Microsoft.EntityFrameworkCore;

namespace ViandasUtn.Context
{
    public class ViandaApiContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        //public DbSet<Producto> Productos { get; set; }
        public ViandaApiContext(DbContextOptions<ViandaApiContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario()  // add usuario al BD
            {
                Id =  1,     
                Name = "Karen",
                LastName = "Lasot",
                Password = "Pa$$w0rd",
                Email = "karenbailapiola@gmail.com",
                UserName = "karenpiola"
            });
            modelBuilder.Entity<Usuario>().HasData(new Usuario() 
            {
                Id = 2,
                Name = "Luis Gonzalez",
                LastName = "Gonzales",
                Password = "lamismadesiempre",
                Email = "elluismidetotoras@gmail.com",
                UserName = "luismitoto"
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
