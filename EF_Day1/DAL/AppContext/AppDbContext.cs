using EF_Day1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace EF_Day1.DAL.AppContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-A0LMSG6\\SD;Database=EF_Day1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true ");
        }
        DbSet<Employee> Employees {  get; set; }
        DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(a => a.FirstName).HasColumnType("nvarchar(30)");
            modelBuilder.Entity<Employee>().Property(a => a.LastName).HasColumnType("nvarchar(30)");
            modelBuilder.Entity<Employee>().Property(a => a.FullName).HasComputedColumnSql("[FirstName]+[LastName]");
            modelBuilder.Entity<Employee>().HasOne(e => e.Department).WithMany(d => d.Employees).HasForeignKey(k => k.DepartmentId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
