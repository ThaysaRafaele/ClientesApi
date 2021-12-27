using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; } //<entidade> tabela 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Nome)
                .HasMaxLength(50); //definindo tamanho máximo para o nome

            modelBuilder.Entity<Cliente>()
               .Property(c => c.Razao)
               .HasMaxLength(100); //definindo tamanho máximo para o Razão Social

            modelBuilder.Entity<Cliente>()
                .HasData(
                new Cliente { Id = 1, Nome = "Thaysa", Razao = "Thaysa Lacerda", Inclusao = DateTime.Now, Ativo = 1 },
                new Cliente { Id = 2, Nome = "Anna", Razao = "Anna Júlia Lacerda", Inclusao = DateTime.Now, Ativo = 1 },
                new Cliente { Id = 3, Nome = "Joana", Razao = "Joana Vasco", Inclusao = DateTime.Now, Ativo = 1 }
                );
        }
    }
}
