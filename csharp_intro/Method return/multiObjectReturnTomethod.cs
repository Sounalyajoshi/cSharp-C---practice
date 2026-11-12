using System;
namespace MultipleStudents
{
    class Students
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string subject { get; set; }


        public static Students[] GetStudents()
        {
            //Student student = new Student()
            //{
            //    Name = "peter",
            //    age = 21,
            //    subject = "csharp"
            //};
            return new Students[] {

            new Students() {Name="peter" ,age=22,subject="javascript"},
            new Students() { Name = "smith", age = 23, subject = "csharp" },
            new Students() { Name = "john", age = 24, subject = "angular" }
               };

        }
    }

    class Method3Program
    {
        static void Main()
        {
            Students[] students = MultipleStudents.Students.GetStudents();
            foreach (Students s in students)
            {

                Console.WriteLine($"{s.Name} is {s.age} and {s.subject}");

            }
        }
    }
}