// See https://aka.ms/new-console-template for more information
using System;

public class Readline
{
    public static void Main(string[] args)
    {
        int num;
        while (true)
        {
            Console.WriteLine("Zəhmət olmasa, 10-20 arası bir rəqəm yazın:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 10 && num <= 20)
            {
                break;
            }
            Console.WriteLine("Xəta! Daxil etdiyiniz rəqəm 10-20 aralığında deyil.");
            Console.WriteLine("Davam etmək istəyirsinizmi? (Yes/No)");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "yes")
            {
                return;
            }
        }
        Console.WriteLine("{0} {1} ədəddir.", num, num % 2 == 0 ? "cüt" : "tək");
    }
}