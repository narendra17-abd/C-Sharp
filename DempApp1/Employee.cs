using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempApp1
{
    class Employee
    {
        int empId;
        string name, designation, location;
        double salary;

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Enter the employee Id, name, designation," +
                " location and salary");
            empId = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            designation = Console.ReadLine();
            location = Console.ReadLine();
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($" Employee Id = {empId} \n Employee Name = {name} \n Employee Designation = {designation} \n " +
                $" Employee Location = {location} \n Employee Salary = {salary}");
        }
    }
}
