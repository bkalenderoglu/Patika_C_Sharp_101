using System;

namespace recursive_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive
            //3^4

            //With for loop
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
                
            calculations instance = new();
            Console.WriteLine(instance.Exponential(3,4));

            //Extension Methods

            string expr = "Beyza Kalenderoglu";
            bool finalResult = expr.CheckSpaces();
            Console.WriteLine(finalResult);
            if(finalResult)
                Console.WriteLine(expr.RemoveWhiteSpaces());

            Console.WriteLine(expr.UpperCase());
            Console.WriteLine(expr.LowerCase());

            int[] arr = {9,3,6,2,1,5,0};
            arr.SortArray();
            arr.PrintToScreen();

            int num = 5;
            Console.WriteLine(num.isEven());

            Console.WriteLine(expr.GetFirstChar());
        }
    }
    public class calculations
    {   
        //recursive function
        public int Exponential(int num, int power)
        {
            if(power < 2)
                return num;
            return Exponential(num, power-1) * num;
        }

        //Exponential(3.4)
        //Exponential(3.3) * 3
        //Exponential(3.2) * 3 * 3
        //Exponential(3.1) * 3 * 3 * 3
    }

    //Extension classes and methods must be static!
    public static class Extension{

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("",arr);
        }
        
        public static string UpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string LowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintToScreen(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }

        public static bool isEven(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstChar(this string param)
        {
            //Substring(starting_index, ending_index) --> gives the substring between starting_index and ending_index-1
            return param.Substring(0,1);
        }
    }
}
