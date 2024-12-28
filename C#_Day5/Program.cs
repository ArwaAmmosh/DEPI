namespace C__Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Employees :");
            int size = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Employee Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Employee Name: ");
                string Name = Console.ReadLine();
                Console.Write("Enter Employee Age: ");
                int Age = int.Parse(Console.ReadLine());
                Console.Write("Enter Employee Salary:");
                decimal Salary = decimal.Parse(Console.ReadLine());
                Console.Write("Enter HrId: ");
                string HrId = Console.ReadLine();
                Console.Write("Enter Employee Bounse:");
                double Bounse = double.Parse(Console.ReadLine());
                Console.Write("Enter N of Leaves : ");
                int NLeaves = int.Parse(Console.ReadLine());
                employees[i] = new Employee(Id, Name, Age, Salary, HrId, Bounse, NLeaves);

            }
            foreach (Employee employee in employees)
            {
                employee.Print();

            }
            //toggle status
            Console.WriteLine("Toggle Employee Status:");
            //Enter Id 
            Console.Write("Enter Employee Id:");
            //check Id ==>Index 
            int index = EmployeeNonfunctionality.findIndex(employees, int.Parse(Console.ReadLine()));
            ///Arrr[Id]
            if (index == -1)
            {
                Console.WriteLine("Employee Not Exist or Incorrect Id");
            }
            else
            {
                employees[index].TogelStatusEmployee();
            }
            ///
            foreach (Employee employee in employees)
            {
                employee.printExistingEmployees();
            }
        }
    }
    }
