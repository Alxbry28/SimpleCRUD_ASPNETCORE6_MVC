using System.ComponentModel.DataAnnotations;
using ASPNETMVCCRUD.Areas.Students.Data.Enum;

namespace ASPNETMVCCRUD.Areas.Students.ViewModels
{
    public class EditRecordViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "LRN is required")]
        public string LRN { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        public GradesEnum Grade { get; set; }

        [Required(ErrorMessage = "Section is required")]
        public string Section { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        public DateTime Birthday { get; set; }
    }
}
