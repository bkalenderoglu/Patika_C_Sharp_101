using System;

namespace staticClass
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Number of employees: {0}", Employee.NumOfEmployees );
           Employee employee = new Employee("Ayse","Yılmaz","IT");
           Console.WriteLine("Number of employees: {0}", Employee.NumOfEmployees );

           Console.WriteLine("Sum           :{0}", Calculations.Add(100, 200));
           Console.WriteLine("Difference    :{0}", Calculations.Subtract(100, 200));
        }
    }

    class Employee
    {
        private static int numOfEmployees;
        public static int NumOfEmployees { get => numOfEmployees; }

        private string Name;
        private string Surname;
        private string Department;

        static Employee() // enters this static constructor just once
        {
            numOfEmployees = 0;
        }
        public Employee(string name, string surname, string department)
        {
            this.Name =  name;
            this.Surname = surname;
            this.Department = department;
            numOfEmployees ++;

        }
    }

    // In static classes, properties and methods must be static
    static class Calculations
    {
        public static long Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static long Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
