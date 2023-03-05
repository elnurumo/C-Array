// See https://aka.ms/new-console-template for more information

//bool flag = true;
//int increment = 0;
//Console.WriteLine("Please enter the size of the array");
//int sizeArray = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[0];
//do
//{
//    Console.WriteLine("Enter element ");
//    int element = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(element);
//    numbers[increment] = element;
//    increment++;
//    Console.WriteLine("Do you want to continue? ");
//    string answer = Console.ReadLine();
//    if (!(answer == "y" || answer == "Y"))
//    {
//        flag = false;
//        Console.WriteLine(".......exiting");
//    }

//} while (flag);

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] employees = new string[0];
        bool isContinuing = true;

        do
        {
            Console.Write("Enter new employee: ");
            string newEmployee = Console.ReadLine();

            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = newEmployee;

            Console.Write("Do you want to continue? (yes/no): ");
            string answer = Console.ReadLine();

            isContinuing = (answer.ToLower() == "yes");
        } while (isContinuing);

        Console.WriteLine("Employees:");
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }

        Console.ReadLine();
    }
}
