
namespace EF_Day1.DAL.Entities
{
    public class Department
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int FloorNum { get; set; }
        public List<Employee>? Employees { get; set; }

    }
}
