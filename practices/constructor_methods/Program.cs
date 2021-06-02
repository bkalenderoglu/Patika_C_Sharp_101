using System;

namespace constructor_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor name = class name
            //public
            Console.WriteLine("******* Employee 1 *********");
            Employee employee = new Employee("Beyza", "Kalenderoglu", 444444, "IT");
            employee.EmployeeInfo();

            Console.WriteLine("******* Employee 2 *********");
            Employee employee2 = new Employee();
            employee2.Name = "Ayse";
            employee2.Surname = "Kara";
            employee2.No = 66666;
            employee2.Department = "IT";

            employee2.EmployeeInfo();

            Console.WriteLine("******* Employee 1 *********");
            Employee employee3 = new Employee("Gözde", "Tümacar");

            employee3.EmployeeInfo();
        }
    }

    class Employee {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        
        public Employee(){}
          public Employee(string name, string surname){
            
            this.Name = name;
            this.Surname = surname;
        }
        public Employee(string name, string surname, int no, string department){
            
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = department;
        }
        public void EmployeeInfo()
        {
            Console.WriteLine("Employee Name:{0}", Name);
            Console.WriteLine("Employee Surname:{0}", Surname);
            Console.WriteLine("Employee No:{0}", No);
            Console.WriteLine("Employee Name:{0}", Department);
        }
    }
}
