using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 2;
           int b = 3;
        
           Console.WriteLine(a+b);
           int result = Add(a,b);
           Console.WriteLine(result);

           Methods example = new Methods();
           example.Print(Convert.ToString(result));
        
           //referencing adresses of a and b in memory
           //a and b changes globaly in every run
           int result2 = example.addValueOneSum(ref a, ref b);
           example.Print(Convert.ToString(result2));
           example.Print(Convert.ToString(a+b));
        }

        static int Add(int num1 , int num2)
        {
            return (num1 + num2);
        }
    }

    class Methods
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public int addValueOneSum(ref int value1, ref int value2)
        {
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }
    }
}
