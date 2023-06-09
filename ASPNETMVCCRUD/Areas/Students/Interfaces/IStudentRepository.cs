
using ASPNETMVCCRUD.Areas.Students.Models;

public interface IStudentRepository
{
	Task<IEnumerable<Student>> GetAll();
	Task<Student?> GetByIdAsyncNoTracking(Guid guid);
	Task<Student?> GetByGuidAsync(Guid guid);
	Task<Student?> GetByLRNAsync(string lrn);
	bool Create(Student student);
	bool Delete(Student student);
	bool Update(Student student);
	bool Save();
}