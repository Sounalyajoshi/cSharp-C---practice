using System;
namespace ExtensionMethods
{
    public class SmartPhone
    {
        public string Brand { get; set; }

        public void MakeCall(string number)
        {
            Console.WriteLine($"calling {number} from {Brand} smartphone");

        }
    }

    public static class ExtensionSmartPhone
    {
        public static void TrackFitness(this SmartPhone myphone)
        {
            Console.WriteLine($"the{myphone.Brand} smartphone is tracking fitness now");
        }
    }
    class ExtensionProgram
    {
        static void Main()
        {
            SmartPhone phone = new SmartPhone { Brand = "pixel" };
            phone.MakeCall("12345678910");

            phone.TrackFitness();
        }
    }


    public class Book
    {
        public string BookName { get; set; }
        public string author { get; set; }
        public int price { get; set; }

    }
        public static class BookExtension
        {
            public static void DisplayBook(this Book book)
            {
                Console.WriteLine(book.BookName);
                Console.WriteLine(book.author);
                Console.WriteLine(book.price);
            }
        }
        class Bookextensionprogram
        {
            static void Main()
            {
                Book b = new Book();
                b.BookName = "c#program";
                b.author = "smith";
                b.price = 500;

            b.DisplayBook();
            }
        }
    
    }
