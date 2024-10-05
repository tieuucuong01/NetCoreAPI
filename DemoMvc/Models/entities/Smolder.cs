using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.entities
{
    public class Smolder
    {
        [Key]
        [Required(ErrorMessage = "Xin vui lòng nhập ID")]
        public string SmolderID { get; set; }
        public string Hoten { get; set;}
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
 
        public string Password { get; set; }
        public string Email { get; set;}
    }

}