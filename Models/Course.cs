using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Range(1, 10)]
        public int Credits { get; set; }
    }
}
