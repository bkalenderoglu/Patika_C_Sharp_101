using System;

namespace methods_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = "Welcome to CSharp...";
            string var2 = "CSharp...";

            //Length
            Console.WriteLine(var.Length);

            //ToUpper, ToLower
            Console.WriteLine(var.ToUpper());
            Console.WriteLine(var.ToLower());

            //Concat
            Console.WriteLine(String.Concat(var," Hello!"));

            //Compare, CompareTo
            Console.WriteLine(var.CompareTo(var2)); // 0, 1, -1
            Console.WriteLine(String.Compare(var, var2, true));
            Console.WriteLine(String.Compare(var, var2, false));  // false: case sensitive

            //Contains
            Console.WriteLine(var.Contains(var2));
            Console.WriteLine(var.EndsWith("..."));
            Console.WriteLine(var.StartsWith("Hello"));

            //IndexOf - LastIndexOf
            Console.WriteLine(var.IndexOf("CS"));
            Console.WriteLine(var.IndexOf("Beyza"));// returns -1 if CS does not exist
            Console.WriteLine(var.LastIndexOf("p"));

            //Insert
            Console.WriteLine(var.Insert(0, "Hello! "));
            
            //PadLeft - PadRight
            Console.WriteLine(var + var2.PadLeft(30)); // adds white space to the left till var2 has total of 30 characters
            Console.WriteLine(var + var2.PadLeft(30, '*')); // adds * to the left till var2 has total of 30 characters
            Console.WriteLine(var.PadRight(50) + var2); // adds white space to the right till var has total of 50 characters
            Console.WriteLine(var.PadRight(50, '-') + var2); // adds - to the right till var has total of 50 characters

            //Remove
            Console.WriteLine(var.Remove(10)); // starting from  index 10, delete rest
            Console.WriteLine(var.Remove(5,3)); // starting from  index 5, delete 3 character
            Console.WriteLine(var.Remove(0,1)); // deletes first character

            //Replace
            Console.WriteLine(var.Replace("CSharp","C#"));
            Console.WriteLine(var.Replace(" ","*"));

            //Split
            Console.WriteLine(var.Split(' ')[1]);

            //Substring
            Console.WriteLine(var.Substring(4)); // starting from index 4, get the rest
            Console.WriteLine(var.Substring(4,6)); // starting from index 4, get the next 6 characters
        }
    }
}
