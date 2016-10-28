using System;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            //AbstractCar aCar = new AbstractCar();  // can't instantiate an abstract class

            EngineStruct engine = new EngineStruct();

            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();

            Mercedes mercedesEx7 = new Mercedes();
            Console.WriteLine("Mercedes is " + mercedesEx7.description);
            Console.WriteLine("Mercedes costs " + mercedesEx7.price);

            Console.WriteLine("This is my first C# project!");
            Console.ReadKey();
        }
    }
}
