using System;
using System.Collections.Generic;
namespace ConsoleApp8
{
    abstract class Employee
    {
        private double baseSalary;

        public double GetSalary()
        {
            return baseSalary;
        }

        public void SetSalary(double salary)
        {
            baseSalary = salary;
        }

        public abstract double CalculateBonus();
    }
    class Manager : Employee
    {
        public override double CalculateBonus()
        {
            return GetSalary() * 0.20;
        }
    }
    class Intern : Employee
    {
        public override double CalculateBonus()
        {
            return 100;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Manager manager1 = new Manager();
            manager1.SetSalary(3000);

            Manager manager2 = new Manager();
            manager2.SetSalary(4000);

            Intern intern1 = new Intern();
            intern1.SetSalary(600);

            Intern intern2 = new Intern();
            intern2.SetSalary(5000);

            employees.Add(manager1);
            employees.Add(manager2);
            employees.Add(intern1);
            employees.Add(intern2);

            foreach (Employee employee in employees)
            {
                double salary = employee.GetSalary();
                double bonus = employee.CalculateBonus();
                double totalSalary = salary + bonus;

                Console.WriteLine("Esas maas: " + salary + " AZN");
                Console.WriteLine("Bonus: " + bonus + " AZN");
                Console.WriteLine("Ümumi maas: " + totalSalary + " AZN");
                Console.WriteLine();
            }
        }
    }
}