using System;
using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models.entities
{
    public class Employee
    {
    [Key]
    public string EmployeeID { get; set; }
    public string Fullname { get; set; }
    }
}
