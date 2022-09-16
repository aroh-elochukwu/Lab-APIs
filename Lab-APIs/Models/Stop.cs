using System.ComponentModel.DataAnnotations;

namespace Lab_APIs.Models
{
    public class Stop
    {
        [Key]
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public EnumDirection Direction { get; set; }
        public ICollection<string> StopSchedules =  new List<string>();

        
    }
}
