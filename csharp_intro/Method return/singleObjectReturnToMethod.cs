using System;

namespace Studentoperation
{
    class Student
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string subject { get; set; }


        public static Student GetStudent()
        {
            Student student = new Student()
            {
                Name = "peter",
                age = 21,
                subject = "csharp"
            };
            return student;

        }


    }
    class MethodProgram
    {
        static void Main()
        {
            Student s1 = Studentoperation.Student.GetStudent();
            Console.WriteLine($"student is: {s1.Name} and age is: {s1.age} and subject is: {s1.subject}");
        }
    }
}
