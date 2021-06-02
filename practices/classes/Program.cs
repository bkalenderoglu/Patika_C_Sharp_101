using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

          /*
          * public - accessible from anywhere
          * private - can be accessed in the same class
          * internal - can be accessed in the same class, or in a class that is derived from that class
          * protected - accessible within the class, ,subclass
          */  

          Employee employee = new Employee();
          employee.Name = "Beyza";
          employee.Surname = "Kalenderoglu";
          employee.No = 444444;
          employee.Department = "IT";

          employee.EmployeeInfo();

          Console.WriteLine("****************");

          Employee employee2 = new Employee();
          employee2.Name = "Ayse";
          employee2.Surname = "Kara";
          employee2.No = 66666;
          employee2.Department = "IT";

          employee2.EmployeeInfo();
        }
    }

    class Employee {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public void EmployeeInfo()
        {
            Console.WriteLine("Employee Name:{0}", Name);
            Console.WriteLine("Employee Surname:{0}", Surname);
            Console.WriteLine("Employee No:{0}", No);
            Console.WriteLine("Employee Name:{0}", Department);
        }
    }
}
