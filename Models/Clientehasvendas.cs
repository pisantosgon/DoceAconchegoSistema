using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Doceaconchego.Models
{
    [Table("Clientehasvendas")]
    public class Clientehasvendas
    {
        [Column("ClientehasvendasId")]
        [Display(Name = "Codigo da Clientehasvendas")]
        public int ClientehasvendasId { get; set; }



        [ForeignKey("ClienteId")]
        [Display(Name = "Codigo do Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }



        [ForeignKey("VendaId")]
        [Display(Name = "Codigo do Venda")]
        public int VendaId { get; set; }

        public Venda? Venda { get; set; }



        [ForeignKey("ProdutoId")]
        [Display(Name = "Codigo do Produto")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

    }
}
