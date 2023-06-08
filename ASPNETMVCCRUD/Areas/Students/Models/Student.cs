using ASPNETMVCCRUD.Areas.Students.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ASPNETMVCCRUD.Areas.Students.Models
{
	public class Student
	{
		[Key]
		public Guid Id { get; set; }
		public string LRN { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public GradesEnum Grade { get; set; }
		public string Section { get; set; }
		public string Address { get; set; }
		public DateTime Birthday { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

	}
}
