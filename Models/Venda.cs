using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doceaconchego.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Column("VendaId")]
        [Display(Name = "Codigo daVenda")]
        public int VendaId { get; set; }

        [Column("DataVenda")]
        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }

        [Column("ValorVenda")]
        [Display(Name = " Valor da Venda")]
        public int ValorVenda { get; set; }

        [ForeignKey("vendedorId")]
        [Display(Name = "Codigo do vendedor")]
        public int vendedorId { get; set; }

        public vendedor? vendedor { get; set; }

    }
}
