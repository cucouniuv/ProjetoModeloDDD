using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        //public ProjetoModeloContext(DbContextOptions<ProjetoModeloContext> options)
        //    : base(options)
        //{
        //}

        //public ProjetoModeloContext(DbContextOptions options) 
        //    : base(options)
        //{
        //}

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            optionsBuilder.UseMySql("server=localhost;database=ProjetoModeloDB;userid=developer;password=1234567");
            //}
        }
    }
}
