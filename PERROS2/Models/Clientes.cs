using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PERROS2.Models
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteID { get; set; }

        [Required]
        [StringLength(255)]
        public string NombreComercial { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDeCliente { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string CorreoElectronico { get; set; }

        [Required]
        [StringLength(255)]
        public string ContraseñaHash { get; set; }

        [Required]
        [StringLength(500)]
        public string Dirección { get; set; }

        [Required]
        [StringLength(50)]
        public string Teléfono { get; set; }

        public DateTime? FechaDeCreación { get; set; }
    }
}
