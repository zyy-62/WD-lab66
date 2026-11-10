using BasicMVCProject.Models;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("DefaultConnection") { }

        public DbSet<UniversityCampus> Campuses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}