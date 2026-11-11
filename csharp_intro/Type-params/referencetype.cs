using System;
namespace referencetype
{
    class Student
    {
        public int marks = 50;
    }

    class School
    {
        Student s1 = new Student();

        public void UpdateMarks(Student s)
        {
            Console.WriteLine("Before updating: " + s.marks);

            s.marks = 100;

            Console.WriteLine("After updating: " + s.marks);
        }

        public void SendStudent()
        {
            UpdateMarks(s1);
        }
    }

    class referencetypeProgram
    {
        static void Main()
        {
            School school = new School();

            school.SendStudent();
        }
    }
}