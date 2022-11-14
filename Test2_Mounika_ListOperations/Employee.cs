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
            this.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
           this.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
          this.Salary = double.Parse(Console.ReadLine()); 
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID : {0}" + Environment.NewLine + "Employee Name : {1}" + Environment.NewLine + "Employee Salary : {2}",
               this.EmployeeId, this.EmployeeName, this.Salary);
        }
    }
    
}


