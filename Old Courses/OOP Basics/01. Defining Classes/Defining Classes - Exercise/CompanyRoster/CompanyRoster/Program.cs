using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();


        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split();
            string name = args[0];
            decimal salary = decimal.Parse(args[1]);
            string position = args[2];
            string departement = args[3];
            int age;
            string email;

            var employee = new Employee(name, salary, position, departement);

            if (args.Length > 4)
            {
                if (int.TryParse(args[4], out age))
                {
                    employee.Age = int.Parse(args[4]);
                }
                else
                {
                    employee.Email = args[4];
                }
            }

            if (args.Length > 5)
            {
                employee.Age = int.Parse(args[5]);
            }

            employees.Add(employee);
        }

        var department = employees
            .GroupBy(em => em.Department)
            .Select(gr => new
            {
                Name = gr.Key,
                AvarangeSalary = gr.Average(em => em.Salary),
                Employees = gr
            })
            .OrderByDescending(gr => gr.AvarangeSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {department.Name}");
        foreach (var emp in department.Employees.OrderByDescending(em=>em.Salary))
        {
            Console.WriteLine(emp.PrintEmployeeInfo());
        }
    }
}

