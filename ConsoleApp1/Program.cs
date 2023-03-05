using System;

class Program
{
    static void Main(string[] args)
    {
        string[] employees = new string[0];
        bool flag = true;

        do
        {
            Console.Write("Enter new employee: ");
            string newEmployee = Console.ReadLine();

            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = newEmployee;

            Console.Write("Do you want to continue? (yes/no): ");
            string answer = Console.ReadLine();

            flag = (answer.ToLower() == "yes");
        } while (flag);

        Console.WriteLine("Employees:");
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }
        Console.ReadLine();
    }
}
