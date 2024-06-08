using System.ComponentModel.DataAnnotations;

namespace GlobalSolutionNET.Models.Entities
{
    public class Mission
    {
        [Key]
        public Guid MissionId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        // Propriedade de navegação para a relação N:N com Drones
        public ICollection<DroneMission> DroneMissions { get; set; }
    }
}
