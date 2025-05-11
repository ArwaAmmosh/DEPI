using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
        public bool IsDeleted { get; set; }=false;
        public DateTime Createdon { get; set; }= DateTime.Now;
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

    public static class EmployeeNonfunctionality
    {
        public static void printEmployess(Employee[] emp)
        {
            foreach (Employee employee in emp)
            {
                Console.WriteLine($"Employee - ID :{employee.Id}  Name:{employee.Name} Age:{employee.Age} Salary:{employee.Salary} HRId:{employee.HrId} Bounes:{employee.Bounse} NofLeaves:{employee.NLeaves} Created on:{employee.Createdon} ");
            }
        }
        public static int findIndex(Employee[] emps,int id)
        {
            for (int i= 0;i < emps.Length;i++)
            {
                if (emps[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
       public static void FillData(int num)
        {
            int[] arr = new int[10];
            int[] arr2;
            int index2 = 11;
            int index = 0;
            if (index == arr.Length)
            {
                arr2 = new int[20];
                Array.Copy(arr, arr2, arr.Length);
                arr2[index] = num;
                index++;
            }
            else
            {
                arr[index] = num;
                index++;
            }
        }
    }
}