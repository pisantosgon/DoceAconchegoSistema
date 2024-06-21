using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doceaconchego.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Codigo do Produto")]
        public int ProdutoId { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; }


        [Column("PrecoProduto")]
        [Display(Name = "Preco do Produto")]
        public int PrecoProduto { get; set; }

        [Column("CorProduto")]
        [Display(Name = "Cor do Produto")]
        public string CorProduto { get; set; }

        [Column("ImgProduto")]
        [Display(Name = "Imagem do Produto")]
        public string ImgProduto { get; set; }

        [Column("DescricaoProduto")]
        [Display(Name = "Descrição do Produto")]
        public string DescricaoProduto { get; set; }


        [ForeignKey("SubcategoriaId")]
        [Display(Name = "Codigo da Subcategoria")]
        public int SubcategoriaId { get; set; }

        public Subcategoria? Subcategoria { get; set; }
    }
}
