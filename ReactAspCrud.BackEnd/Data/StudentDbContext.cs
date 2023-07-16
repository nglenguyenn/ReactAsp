using Microsoft.EntityFrameworkCore;
using ReactAspCrud.Models;

namespace ReactAspCrud.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        public DbSet<Student> Student { get; set; }
    }
}
