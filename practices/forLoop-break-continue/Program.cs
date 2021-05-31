using System;

namespace forLoop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //print odd numbers till given number
            System.Console.Write("Enter a number: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i < count; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }

            //print odd and even numbers between 1 - 1000
            int odd_total = 0;
            int even_total = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 1)
                    odd_total += i;
                else
                    even_total += i;
            }
            System.Console.WriteLine("Sum of odd numbers between 1-1000 : " +odd_total);
            System.Console.WriteLine("Sum of even numbers between 1-1000: " +even_total);

            // break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                System.Console.WriteLine(i);
         
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                System.Console.WriteLine(i);
         
            }
        }
    }
}
