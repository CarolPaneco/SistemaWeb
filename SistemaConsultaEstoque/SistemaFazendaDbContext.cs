using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaConsultaEstoque
{
    public class SistemaFazendaDbContext : DbContext
    {
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Vendas> Vendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SistemaFazendaDB;Trusted_Connection=True;");
        }
    }

    public class Estoque
    {
        public int EstoqueId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }

    public class Vendas
    {
        [Key] // Indica que esta é a chave primária
        public int VendaId { get; set; }
        public int? ProdutoId { get; set; }
        public int? Quantidade { get; set; }
        public decimal? PrecoTotal { get; set; }
        public DateTime? DataVenda { get; set; }
    }
}
