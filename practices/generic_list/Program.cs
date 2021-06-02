using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class T --> generic, object type
            //System.Collections.Generic;

            List<int> numList = new List<int>();

            numList.Add(23);
            numList.Add(10);
            numList.Add(4);
            numList.Add(5);
            numList.Add(92);
            numList.Add(34);

            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");

            Console.WriteLine(colorList.Count);
            Console.WriteLine(numList.Count);

            // foreeach - List.ForEach printing items
            foreach (var num in numList)
                Console.WriteLine(num);

            foreach (var color in colorList)
                Console.WriteLine(color);

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            // Removing item from list
            numList.Remove(4);
            colorList.Remove("Green");

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            numList.RemoveAt(0); // Remove item at index zero
            colorList.RemoveAt(1); // Remove item at index one

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            // Searching
            if(numList.Contains(10))
                Console.WriteLine("10 found in the list");

             // By using list item, reaching index
            Console.WriteLine(colorList.BinarySearch("Yellow")); // Red , Orange, Yellow

            // Array to List
            string[] animals = {"Cat", "Dog", "Bird"}; 
            List<string> animalList = new List<string>(animals);

            //Clear
            animalList.Clear();

            // object in list
            List<Users> usersList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "Beyza";
            user1.Surname = "Kalenderoglu";
            user1.Age = 23;

            Users user2 = new Users();
            user2.Name = "Ayse";
            user2.Surname = "Yılmaz";
            user2.Age = 26;

            usersList.Add(user1);
            usersList.Add(user2);

            List<Users> newList = new List<Users>();
            newList.Add(new Users(){

                Name = "Deniz",
                Surname = "Arda",
                Age = 22
            });

            foreach (var user in usersList)
            {
                Console.WriteLine("Name: " + user.Name);
                Console.WriteLine("Surname: " + user.Surname);
                Console.WriteLine("Age: " + user.Age);
            }
            newList.Clear();
        }
    }

    public class Users{

        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    
    }
}
