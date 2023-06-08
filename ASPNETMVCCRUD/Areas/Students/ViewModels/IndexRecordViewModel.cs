using ASPNETMVCCRUD.Areas.Students.Models;

namespace ASPNETMVCCRUD.Areas.Students.ViewModels
{
    public class IndexRecordViewModel
    {
        public IEnumerable<Student> Students { get; set; }
    }
}
