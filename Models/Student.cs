using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }
    }
}
