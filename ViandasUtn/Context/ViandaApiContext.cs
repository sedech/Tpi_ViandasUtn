using Microsoft.EntityFrameworkCore;

namespace ViandasUtn.Context
{
    public class ViandaApiContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto>? Productos { get; set; }
        public ViandaApiContext(DbContextOptions<ViandaApiContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {
             

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add usuario al BD
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario(1, "Mika", "Ben", "@Rosario22", "mikaben@gmail.com", "benka"),
                new Usuario(2, "Dom", "Toreto", "#Dodge1970", "toreto@gmail.com", "toretodom")
            );
            // add producto al BD
            modelBuilder.Entity<Producto>().HasData(
                new Producto(1,"Alfajor","Milka", 150),
                new Producto(2, "Ensalada de frutas","Casera" , 350),
                new Producto(3, "Sandwich","Individuales" , 420),
                new Producto(4, "Agua", "Bonaqua x 500 cc", 150),
                new Producto(5, "Cafe + Medialuna", "La Morenita",500),
                new Producto(6, "Gaseosa", "Coca Cola x 500 cc", 180)
            );
            // 
            modelBuilder.Entity<Pedido>().HasData(
                   new
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
