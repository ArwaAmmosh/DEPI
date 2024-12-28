
namespace C__Day5
{
    public class Employee
    {

        public Employee(int employeeId, string name, int age, decimal salary, string hrId, double bounse, int nLeaves)
        {
            Id = employeeId;
            Name = name;
            Age = age;
            Salary = salary;
            HrId = hrId;
            Bounse = bounse;
            NLeaves = nLeaves;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string HrId { get; set; }
        public double Bounse { get; set; }
        public int NLeaves { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime Createdon { get; set; } = DateTime.Now;
        public void Print()
        {
            Console.WriteLine($"Employee - ID :{this.Id}  Name:{this.Name} Age:{this.Age} Salary:{this.Salary} HRId:{this.HrId} Bounes:{this.Bounse} NofLeaves:{this.NLeaves} Created on:{this.Createdon} IsDeleted:{IsDeleted}");
        }
        public void TogelStatusEmployee()
        {
            this.IsDeleted = !this.IsDeleted;
            Console.WriteLine("Done Sucessfully!");
        }
        public void printExistingEmployees()
        {

            if (this.IsDeleted)
                Console.WriteLine("Not Existing");
            else
            {
                Console.WriteLine($"Employee - ID :{this.Id}  Name:{this.Name} Age:{this.Age} Salary:{this.Salary} HRId:{this.HrId} Bounes:{this.Bounse} NofLeaves:{this.NLeaves} Created on:{this.Createdon} ");

            }

        }
    }
}
