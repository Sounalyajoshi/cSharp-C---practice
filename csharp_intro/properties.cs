using System;



class Student
{
    public string name { get; set; }
    public int age { get; set; }

    class program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.name = "janu";
            s1.age = 12;

            Console.WriteLine(s1.name);
            Console.WriteLine(s1.age);
        }
    }


    class Employee
    {
        public string name { get; set; }
        public int salary { get; set; }

        public void display()
        {
            Console.WriteLine("employee name is:" + name);
            Console.WriteLine("employee salary is:" + salary);
        }

        class EmpDetails
        {
            static void Main()
            {
                Employee e1 = new Employee();
                e1.name = "janu";
                e1.salary = 200000;
                e1.display();

            }
        }


    }



    class Worker
    {
        public int id { get; set; }
        public int age { get; set; }

        public void disp()
        {
            Console.WriteLine($"below display the worker details");
            Console.WriteLine(age);
            Console.WriteLine(id);


        }


    }
    class WorkerDetails
    {
        static void Main()
        {
            Worker w1 = new Worker();
            w1.id = 12;
            w1.age = 23;
            w1.disp();
        }

    }
}