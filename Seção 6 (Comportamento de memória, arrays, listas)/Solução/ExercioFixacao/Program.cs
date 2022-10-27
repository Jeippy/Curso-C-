using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");

            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Entre the employee id that will have salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == idEmployee);

            if(emp != null)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double perct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(perct);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

        }
    }
}