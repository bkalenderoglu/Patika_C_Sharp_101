using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //calculating mean starting from 1 to entered number which is included too
            System.Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 1;
            int total = 0;
            while (count <= num)
            {
                total += count;
                count++;
            }
            System.Console.WriteLine(total/num);

            //printing letters from a to z
            char character = 'a';
            while (character <= 'z')
            {
                System.Console.Write(character);
                character++;
            }

            System.Console.WriteLine("*** Foreach ***");
            string[] cars = {"BMW", "Ford", "Nissan"};
            foreach (var car in cars)
            {
                System.Console.WriteLine(car);
            }
        }
    }
}
