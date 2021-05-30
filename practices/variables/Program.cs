using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = 2;
            string variable = null;
            string Variable = null;
            Console.WriteLine(num);

            byte b = 5;     // 1 byte
            sbyte s = 5;    // 1 byte

            short sh = 5;   // 2 byte
            ushort ush = 5; // 2 byte

            Int16 i16 = 2;  // 2 byte
            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 4;     // 8 byte
            ulong ul = 4;   // 8 byte

            //Reel Numbers
            float f = 5;    // 4 byte
            double d = 5;   // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';  // 2 byte
            string str = "be"; //infinite 

            bool b1 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;*/

            //Strings

            string str1 = string.Empty;
            str1 = "Beyza Kalenderoglu";
            string name = "Beyza";
            string surname = "Kalenderoglu";
            string fullname = name + " " + surname;

            //Integer

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //Boolean

            //bool bool1 = 10>2;

            //variable casting

            string str20 = "20";
            int var20 = 20;

            string newVar = str20 + var20.ToString();
            Console.WriteLine(newVar); // output: 2020

            int int21 = var20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // output: 40

            int int22 = var20 + int.Parse(str20); // output: 40

            //dateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);  

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);  
        
        }
    }
}
