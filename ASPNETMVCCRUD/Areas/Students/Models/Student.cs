using ASPNETMVCCRUD.Areas.Students.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ASPNETMVCCRUD.Areas.Students.Models
{
	public class Student
	{
		[Key]
		public Guid Id { get; set; }
        [Required]
        public string LRN { get; set; } = default!;
        [Required]
        public string FirstName { get; set; } = default!;
		public string? MiddleName { get; set; }
        [Required]
        public string LastName { get; set; } = default!;
        [Required]
        public GradesEnum Grade { get; set; }
        [Required]
        public string Section { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        public DateTime Birthday { get; set; }

        public string? Picture { get; set; }
        public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

	}
}
