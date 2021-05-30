using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Logical Operators ( ||, &&, ! )

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            //Physical Operators ( <, >, <=, >=, ==, != )

            int a = 3;
            int b = 4;

            bool result = a < b;
            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            //Arithmetic Operators ( /, *, +, - )

            int num1 = 10;
            int num2 = 5;
            int result_num = num1 / num2;
            Console.WriteLine(result_num);
            result_num = num1 * num2;
            Console.WriteLine(result_num);
            result_num = num1 + num2;
            Console.WriteLine(result_num);
            result_num = num1++;
            Console.WriteLine(num1);

            // Modula Operator

            int result_mod = 20%3;
            Console.WriteLine(result_mod);





        }
    }
}
