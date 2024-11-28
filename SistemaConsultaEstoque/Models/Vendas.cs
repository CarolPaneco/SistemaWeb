using System.ComponentModel.DataAnnotations;

namespace SistemaConsultaEstoque.Models
{
    public class Venda
    {
        [Key] // Indica que esta é a chave primária
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal { get; set; }
        public DateTime DataVenda { get; set; }
    }

}
