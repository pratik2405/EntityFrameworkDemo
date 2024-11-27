using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }

        [Required]
        [Display(Name=("Employee Name"))]
        public string ?Ename { get; set; }

        [Required]
        [Display(Name = ("Employee Email"))]
        public string ?Email { get; set; }

        [Required]
        [Display(Name = ("Employee Salary"))]
        public int  Esal { get; set; }
    }
}
