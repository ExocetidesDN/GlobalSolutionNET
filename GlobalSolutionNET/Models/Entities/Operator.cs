using System.ComponentModel.DataAnnotations;

namespace GlobalSolutionNET.Models.Entities
{
    public class Operator
    {
        [Key]
        public Guid OperatorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Certificantion { get; set; }

        public ICollection<Drone> Drones { get; set; }
    }
}
