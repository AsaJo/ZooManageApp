using System.ComponentModel.DataAnnotations;

namespace ZooManageApp.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public string? Species { get; set; }
        public string? AnimalNickName { get; set; }
        public List<Veterinary> Veterinary { get; set; } = new List<Veterinary>();
    }
}
