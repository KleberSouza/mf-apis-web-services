using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public int Km { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required]
        public TipoCombustivel Tipo { get; set; }

        [Required]
        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        [Display(Name = "Diesel")]
        Diesel,
        [Display(Name = "Etanol")]
        Etanol,
        [Display(Name = "Gasolina")]
        Gasolina,        
    }
}
