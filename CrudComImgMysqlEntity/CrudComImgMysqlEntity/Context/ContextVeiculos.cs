using CrudComImgMysqlEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudComImgMysqlEntity.Context
{
    public class ContextVeiculos : DbContext
    {
        public ContextVeiculos(DbContextOptions<ContextVeiculos> options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>(v =>
           {
               v.ToTable("Veiculos");
               v.HasKey(v => v.IdVeiculo);

           });
        }
    }
}
