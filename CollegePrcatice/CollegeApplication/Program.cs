using CollegeLibrary;

namespace CollegeApplication
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.StudentDisplay();

            Employee e = new Employee();
            e.EmployeetDisplay();

            Department d = new Department();
            d.DepartmentDisplay();


            Book b = new Book();
            b.BookDisplay();



        }
    }
}