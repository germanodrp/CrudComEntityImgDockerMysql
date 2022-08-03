using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudComImgMysqlEntity.Models
{

   
    public class Veiculo
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "CodigoVeiculo")]
        [Column("Id")]
        public int IdVeiculo { get; set; }


        [Required]
        [Display(Name ="Placa")]
        [Column("Placa")]
        public string Placa { get; set; }

        [Required]
        [Display(Name = "Modelo")]
        [Column("Modelo")]
        public string? Modelo { get; set; }

        [Required]
        [Display(Name = "NomeDoVeiculo")]
        [Column("NomeDoVeiculo")]
        public string? NomeDoVeiculo { get; set; }

        [Required]
        [Display(Name = "AnoModelo")]
        [Column("AnoModelo")]
        public string? AnoModelo { get; set; }

        [Required]
        [Display(Name = "Modalidade")]
        [Column("Modalidade")]
        public string? Modalidade { get; set; }
    }
}
