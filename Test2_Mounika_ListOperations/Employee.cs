using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_Mounika_ListOperations;

namespace Test2_Mounika_ListOperations
{



    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }

        public double Salary { get; set; }

        public void AddEmployees()
        {
            Console.WriteLine("Enter Employee ID");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            Salary = double.Parse(Console.ReadLine()); 
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID  : " + EmployeeId);
            Console.WriteLine("Employee Name  : " + EmployeeName);

            Console.WriteLine("Employee Salary  : " + Salary);
        }
    }

}


