using ASPNETMVCCRUD.Areas.Students.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ASPNETMVCCRUD.Areas.Students.ViewModels
{
    public class CreateRecordViewModel
    {
        [Required(ErrorMessage = "LRN is required")]
        public string LRN { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Grade is required")]
        public GradesEnum Grade { get; set; }

        [Required(ErrorMessage = "Section is required")]
        public string Section { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        public DateTime Birthday { get; set; }

    }
}
