using System;

namespace encapsulation_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Beyza";
            student.Surname = "Kalenderoglu";
            student.Stu_no = 6404;
            student.thYear = 3;

            student.StudentInfo();

            student.PassYear();
            student.StudentInfo();

            Student student2 = new Student("Gözde", "Tumacar", 55555, 1);
            student2.StudentInfo();
            student2.decreaseYear();
            student2.StudentInfo();
        }
    }

    class Student{
        private string name;
        private string surname;
        private int stu_no;
        private int thyear;

        public string Name 
        { 
            get { return name; }  
            set { name = value; }
        }
        public string Surname { get => surname; set => surname = value; }
        public int Stu_no { get => stu_no; set => stu_no = value; }
        public int thYear 
        { 
            get => thyear; 
            set
            {
                if (value < 1) 
                {
                    Console.WriteLine("Student year cannot be less than 1 ! ");
                    thyear = 1;
                }
                else{
                    thyear = value;
                }
            } 
        }

        public Student(string name, string surname, int stu_no, int thyear)
        {
            Name = name;
            Surname = surname;
            Stu_no = stu_no;
            thYear = thyear;
        }
        public Student(){}

        public void StudentInfo()
        {
            Console.WriteLine("***** Student Information *****");
            Console.WriteLine("Student Name     :{0}", this.Name);
            Console.WriteLine("Student Surname  :{0}", this.Surname);
            Console.WriteLine("Student No       :{0}", this.Stu_no);
            Console.WriteLine("Student Class    :{0}", this.thYear);
        }

        public void PassYear()
        {
            this.thYear = this.thYear + 1;
        }

        public void decreaseYear()
        {
            this.thYear = this.thYear - 1;
        }

    }
}
