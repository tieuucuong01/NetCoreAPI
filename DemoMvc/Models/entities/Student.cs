using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.entities
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string fullname { get; set; }
        public string Address { get; set; }
    }
}