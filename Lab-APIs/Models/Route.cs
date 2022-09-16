using System.ComponentModel.DataAnnotations;

namespace Lab_APIs.Models
{
    public class Route
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public EnumDirection Direction { get; set; } 
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public Queue<string> StopSchedule { get; set; }

    }
}
