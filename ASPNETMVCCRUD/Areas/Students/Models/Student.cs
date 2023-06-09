using ASPNETMVCCRUD.Areas.Students.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ASPNETMVCCRUD.Areas.Students.Models
{
	public class Student
	{
		[Key]
		public Guid Id { get; set; }
		public string LRN { get; set; } = default!;
		public string FirstName { get; set; } = default!;
		public string? MiddleName { get; set; }
		public string LastName { get; set; } = default!;
		public GradesEnum Grade { get; set; }
		public string Section { get; set; } = default!;
		public string Address { get; set; } = default!;
		public DateTime Birthday { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

	}
}
