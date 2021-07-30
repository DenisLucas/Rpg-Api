using Microsoft.EntityFrameworkCore;
using RpgApi.Domain.V1;

namespace RpgApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Inventario>()
                .HasOne(b => b.Player)
                .WithMany(ba => ba.Inventory)
                .HasForeignKey(bi => bi.PlayerId);

                

        }


        public DbSet<Player> Player { get; set; }
        public DbSet<Itens> Itens {get; set;}
        public DbSet<Inventario> Inventario {get; set;}
    }
}
