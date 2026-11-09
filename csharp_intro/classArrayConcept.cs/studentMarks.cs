using System;
 class studentMarks
    {

     public void DisplayMarks(int[] marks)
    {
       foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        
    }

    public void DisplaySubject(string[] subjects)
    {
        foreach(string sub in subjects)
        {
            Console.WriteLine(sub);
        }
    }
   
    }
class StudentDetails
{
      static void Main()
    {
        int[] marks = { 55, 80, 90, 98 };
        string[] subjects = { "c#", "js", "sql" };

        studentMarks obj = new studentMarks();
        obj.DisplayMarks(marks);
        obj.DisplaySubject(subjects);




    }
}





