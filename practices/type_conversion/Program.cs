using System;

namespace type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion

            Console.WriteLine("***Implicit Conversion***");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d:" +d);

            long h = d;
            Console.WriteLine("h:" +h);

            float i = h;
            Console.WriteLine("i:" +i);

            string e = "Beyza";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g:" +g);

            //Explicit Conversion

            Console.WriteLine("***Explicit Conversion***");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " +y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " +t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " +v);

            // *** ToString Medhod
            Console.WriteLine("***ToString Method***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " +yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " +zz);

            //System.Convert
            Console.WriteLine("***System.Convert***");

            string s1 = "10", s2 = "20";
            int num1, num2;
            int total;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            total = num1 + num2;
            Console.WriteLine("Total: " +total);

            //Parse

            Console.WriteLine("***Parse***");
            ParseMethod();
        }

        public static void ParseMethod() 
        { 
           string text1 = "10";
           string text2 = "10,25";
           int number1;
           double double1; 

           number1 = Int32.Parse(text1);
           Console.WriteLine("Number1: " +number1);

           double1 = Double.Parse(text2);
           Console.WriteLine("Double1: " +double1);
        }
    }
}
