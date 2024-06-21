using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doceaconchego.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Codigo do Cliente")]
        public int ClienteId { get; set; }

        [Column("NomeCliente")]
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; }

        [Column("EmailCliente")]
        [Display(Name = "Email do Cliente")]
        public string EmailCliente { get; set; }

        [Column("SenhaCliente")]
        [Display(Name = "Senha do Cliente")]
        public string SenhaCliente { get; set; }

        [Column("FoneCliente")]
        [Display(Name = "Fone do Cliente")]
        public string FoneCliente { get; set; }

        [Column("CpfCliente")]
        [Display(Name = "Cpf do Cliente")]
        public string CpfCliente { get; set; }

        [Column("SexoCliente")]
        [Display(Name = "Sexo do Cliente")]
        public string SexoCliente { get; set; }

        [Column("SexoBebe")]
        [Display(Name = "Sexo do Bebe")]
        public string SexoBebe { get; set; }

    }
}
