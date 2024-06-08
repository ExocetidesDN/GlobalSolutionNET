namespace GlobalSolutionNET.Models.Entities
{
    public class DroneMission
    {
        public Guid DroneId { get; set; }
        public Drone Drone { get; set; }

        public Guid MissionId { get; set; }
        public Mission Mission { get; set; }
    }
}
