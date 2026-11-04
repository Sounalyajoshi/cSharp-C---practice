using System;
namespace College
{
    namespace Department
    {
        class multiNamespace
        {
            public int studentid = 101;
            public string departmentname = "ENC";


            public void displayDetails()
            {
                Console.WriteLine("studentid:" + studentid);
                Console.WriteLine("departmentname:" + departmentname);
            }

        }

        public class program { 
        
            static void Main()
        {
                College.Department.multiNamespace s1 = new College.Department.multiNamespace();

                s1.displayDetails   ();
        }
        }

    }
}