using ASPNETMVCCRUD.Areas.Students.Models;
using ASPNETMVCCRUD.Data;
using Microsoft.EntityFrameworkCore;

public class StudentRepository : IStudentRepository
{
	private readonly MVCDemoDbContext _context;
    public StudentRepository(MVCDemoDbContext context)
    {
		_context = context;
	}
    public bool Create(Student student)
	{
		_context.Add(student);
		return Save();
	}

	public bool Delete(Student student)
	{
		_context.Remove(student);
		return Save();
	}

	public async Task<IEnumerable<Student>> GetAll()
	{
		return await _context.Students.ToListAsync();
	}

	public async Task<Student?> GetByGuidAsync(Guid guid)
	{
		return await _context.Students.FirstOrDefaultAsync(student => student.Id == guid);
	}

	public async Task<Student?> GetByIdAsyncNoTracking(Guid guid)
	{
		return await _context.Students.AsNoTracking().FirstOrDefaultAsync(student => student.Id == guid);
	}

	public bool Save()
	{
		int saved = _context.SaveChanges();
		return saved > 0;
	}

	public bool Update(Student student)
	{
		_context.Update(student);
		return Save();
	}


}