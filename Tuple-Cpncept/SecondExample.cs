using System;
namespace Tupleconcept {
    class CarTupleExample
    {
        public string brand { get; set; }
        public double price { get; set; }


        public (string brand, double price) GetCar()
        {
            return ("FORTUNER", 3500000);
        }

    }
    class GetCarDEtils
    {
        static void Main()
        {
            CarTupleExample car = new CarTupleExample();
            var Car = car.GetCar();

            Console.WriteLine(Car.brand);
            Console.WriteLine(Car.price);


        }
    }


    class Animal
    {
        public string name { get; set; }
        public int Age { get; set; }

        public void makeSound()
        {
            Console.WriteLine("animal make sound");
        }


        public (string name, int age) animalDetils()
        {
            return ("cat", 5);
        }



    }
    

    class GetAnimalTuple
    {
        static void Main()
        {
            Animal a = new Animal();
            var animal = a.animalDetils();
            Console.WriteLine(animal.name);
            Console.WriteLine(animal.age);


            a.makeSound();
        }
    }








}