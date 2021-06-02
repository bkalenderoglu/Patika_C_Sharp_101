using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Sunday);

            int degree = 32;
            if(degree <= (int)wheather.Cold)
                Console.WriteLine("Extreme conditions to go outside.. ");
            else if(degree > (int)wheather.Cold && degree < (int)wheather.Normal )
                Console.WriteLine("Wait for better conditions to go outside!");
            else if(degree >=(int)wheather.Normal && degree < (int)wheather.Hot)
                Console.WriteLine("Let's go outside!"); 
            else if(degree >=(int)wheather.Hot && degree < (int)wheather.TooHot)
                Console.WriteLine("It's very hot day to go outside!");
            else
                Console.WriteLine("Dont go outside!");

        }
    }

    enum Days{

        Monday, //or Monday=1
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday = 23,
        Sunday

    }

    enum wheather{

        Cold = 5,
        Normal = 20,
        Hot = 25,
        TooHot = 30
    }
}
