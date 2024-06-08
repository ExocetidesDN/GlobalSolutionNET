using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalSolutionNET.Models.Entities
{
    public class FlightLicense
    {
        [Key]
        public Guid LicenseId { get; set; }
        
        public DateTime IssuedDate { get; set; }
        
        public DateTime ExpirationDate { get; set; }

        [Required]
        [ForeignKey("Drone")]
        public Guid DroneId { get; set; }

        public Drone Drone { get; set; }
    }
}
