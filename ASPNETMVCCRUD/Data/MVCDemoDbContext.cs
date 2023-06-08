using ASPNETMVCCRUD.Areas.Students.Models;
using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ASPNETMVCCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasIndex(student => new { student.LRN })
                .IsUnique(true);
        }

    }
}
