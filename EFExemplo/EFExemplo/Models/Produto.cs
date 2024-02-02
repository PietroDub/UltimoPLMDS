using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFExemplo.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Required]
        [Display(Name="Nome do Produto")]
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
