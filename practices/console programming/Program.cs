﻿using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
            
           
        }
    }
}
