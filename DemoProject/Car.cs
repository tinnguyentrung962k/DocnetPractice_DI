using System.ComponentModel.DataAnnotations;

namespace DemoProject
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
    }
}
