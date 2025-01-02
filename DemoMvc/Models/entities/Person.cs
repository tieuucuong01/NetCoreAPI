using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.entities
{
    public class Person
    {
        [Key]
        public required string PersonID { get; set; }
        public required string Hoten { get; set; }
        public string? Quequan { get; set; }
    }

}