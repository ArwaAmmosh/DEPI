
namespace EF_Day1.DAL.Entities
{
    public class Employee
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedDate { get; set; }=DateTime.Now;
        public bool IsDeleted { get; set; }=false;
        public long? DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
