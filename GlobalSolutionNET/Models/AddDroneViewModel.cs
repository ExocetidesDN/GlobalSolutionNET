using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalSolutionNET.Models
{
    public class AddDroneViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DroneId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public Guid OperatorId { get; set; }
    }
}
