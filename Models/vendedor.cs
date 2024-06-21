using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doceaconchego.Models
{
    [Table("vendedor")]
    public class vendedor
    {
        [Column("vendedorId")]
        [Display(Name = "Codigo do vendedor")]
        public int vendedorId { get; set; }

        [Column("Nomevendedor")]
        [Display(Name = "Nome do vendedor")]
        public string Nomevendedor { get; set; }
    }
}
