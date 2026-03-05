using System.ComponentModel.DataAnnotations;

namespace Abilong_ELENET1.MVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; } 

        [Required]
        public string Name { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public int Age { get; set; }
    }
}