using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic
            Dictionary<int, string> users = new Dictionary<int, string>();

            users.Add(10,"Beyza Kalenderoglu");
            users.Add(12,"Ayse Yılmaz");
            users.Add(18,"Deniz Arda");
            users.Add(20,"Gözde Tümacar");

            Console.WriteLine("*** Getting items ***");
            Console.WriteLine(users[12]);

            foreach (var item in users)
                Console.WriteLine(item);

            //Count
            Console.WriteLine("*** Count ***");
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("*** Contains ***");
            System.Console.WriteLine(users.ContainsKey(12));
            System.Console.WriteLine(users.ContainsValue("Beyza Kalenderoglu"));

            //Remove
            Console.WriteLine("*** Remove ***");
            users.Remove(12);

            foreach (var item in users)
                Console.WriteLine(item.Value);

            //Keys
            Console.WriteLine("*** Keys ***");
            foreach (var item in users.Keys)
                Console.WriteLine(item);
            //Values
            Console.WriteLine("*** Values ***");
            foreach (var item in users.Values)
                Console.WriteLine(item);
        }
    }
}
