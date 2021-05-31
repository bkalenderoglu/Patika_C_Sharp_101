using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parameters
            string number = "999";

            bool result = int.TryParse(number, out int outNumber);
            if(result){
                Console.WriteLine("Success...");
                Console.WriteLine(outNumber);
            }
            else{
                Console.WriteLine("Failed...");
            }

            Methods instance = new Methods();
            instance.Add(4,5, out int sumResult);
            Console.WriteLine(sumResult);

            //Method Overloading

            int exp = 999;
            instance.printToScreen(Convert.ToString(exp));
            instance.printToScreen(exp);
            instance.printToScreen("Beyza","Kalenderoglu");
            //Method Signature - 
            //Method name + #parameters + parameter type

            
        }
    }

    class Methods
    {
        public void Add(int a, int b, out int sum){
            sum = a+b;
        }

        public void printToScreen(string text){
            Console.WriteLine(text);
        }

        public void printToScreen(int text){
            Console.WriteLine(text);
        }
        public void printToScreen(string text1, string text2){
            Console.WriteLine(text1 + text2);
        }
    }
}
