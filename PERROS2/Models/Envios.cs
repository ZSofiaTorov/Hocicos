using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PERROS2.Models
{
    public class Envios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnvíoID { get; set; }

        [Required]
        public int PedidoID { get; set; }

        [Required]
        [StringLength(50)]
        public string MétodoDeEnvío { get; set; }

        [Required]
        [StringLength(500)]
        public string DirecciónDeEnvío { get; set; }

        public DateTime? FechaDeEnvío { get; set; }
    }
}
