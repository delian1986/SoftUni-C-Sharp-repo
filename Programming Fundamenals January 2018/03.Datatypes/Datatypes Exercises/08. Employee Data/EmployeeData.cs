using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    public class Employee
    {
        public string FirstName{get;set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public long PersonalId { get; set; }
        public long UENum { get; set; }
    }
    class EmployeeData
    {
        static void Main(string[] args)
        {
            List<Employee>list= new List<Employee>();
            Employee person= new Employee()
            {
              FirstName="Amanda",
               LastName="Jonson",
               Age=27,
               Gender='f',
               PersonalId=8306112507,
               UENum=27563571
            };
        list.Add(person);

            foreach (var item in list)
            {
                Console.WriteLine($"First name: {item.FirstName}");
                Console.WriteLine($"Last name: {item.LastName}");
                Console.WriteLine($"Age: {item.Age}");
                Console.WriteLine($"Gender: {item.Gender}");
                Console.WriteLine($"Personal ID: {item.PersonalId}");
                Console.WriteLine($"Unique Employee number: {item.UENum}");
            }
        }
    }
}
