using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doceaconchego.Models
{
    [Table("Subcategoria")]
    public class Subcategoria
    {

        [Column("SubcategoriaId")]
        [Display(Name = "Codigo da Subcategoria")]
        public int SubcategoriaId { get; set; }

        [Column("NomeSubcategoria")]
        [Display(Name = "Nome da Subcategoria")]
        public string NomeSubcategoria { get; set; }


        [ForeignKey("CategoriaId")]
        [Display(Name = "Codigo da Categoria")]
        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
