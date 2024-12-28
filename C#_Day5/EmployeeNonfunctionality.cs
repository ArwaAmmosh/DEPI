using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day5
{
    public static class EmployeeNonfunctionality
    {
        public static void printEmployess(Employee[] emp)
        {
            foreach (Employee employee in emp)
            {
                Console.WriteLine($"Employee - ID :{employee.Id}  Name:{employee.Name} Age:{employee.Age} Salary:{employee.Salary} HRId:{employee.HrId} Bounes:{employee.Bounse} NofLeaves:{employee.NLeaves} Created on:{employee.Createdon} ");
            }
        }
        public static int findIndex(Employee[] emps, int id)
        {
            for (int i = 0; i < emps.Length; i++)
            {
                if (emps[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
