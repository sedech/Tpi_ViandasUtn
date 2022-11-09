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
                Name = "Mika",
                LastName = "Ben",
                Password = "@Rosario22",
                Email = "mikaben@gmail.com",
                UserName = "benka"
            });
            modelBuilder.Entity<Usuario>().HasData(new Usuario() 
            {
                Id = 2,
                Name = "Dom",
                LastName = "Toreto",
                Password = "#Dodge1970",
                Email = "toreto@gmail.com",
                UserName = "toretodom"
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
