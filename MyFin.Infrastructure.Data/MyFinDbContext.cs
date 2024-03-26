using Microsoft.EntityFrameworkCore;
using MyFin.Domain.Models;

namespace MyFin.Infrastructure.Data
{
    public class MyFinDbContext : DbContext
    {
        public MyFinDbContext()
        {
        }
        public MyFinDbContext(DbContextOptions<DbContext> options) : base(options) {  }

        public DbSet<TransactionOrder> TransactionOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlite(MyFinConnection.GetConnectionString());
                optionsBuilder.UseNpgsql(MyFinConnection.GetConnectionString());
            }            
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }


            }

            return base.SaveChanges();
        }
    }
}
