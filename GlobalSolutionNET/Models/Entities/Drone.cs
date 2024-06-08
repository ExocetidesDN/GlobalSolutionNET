using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalSolutionNET.Models.Entities
{
    public class Drone
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
        
        [ForeignKey("FlightLicense")] 
        public Guid LicenseID { get; set; }

        [ForeignKey("Operator")]
        public Guid OperatorId { get; set; }

        public Operator Operator { get; set; }

        public FlightLicense FlightLicense { get; set; }

        public ICollection<DroneMission> DroneMissions { get; set; }
    }
}
