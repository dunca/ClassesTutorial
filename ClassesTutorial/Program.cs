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
            Console.WriteLine("Mercedes is " + mercedesEx7.Description);
            Console.WriteLine("Mercedes costs " + mercedesEx7.Price);

            var mercedes31 = new Mercedes();
            mercedes31.StartEngine();

            var mercedes32 = new Mercedes();
            mercedes.ShowRemainingNoOfKM(10, 5);

            var mercedes33 = new Mercedes();
            Console.WriteLine(mercedes33.StartEngine());
            Console.WriteLine(mercedes.ShowRemainingNoOfKM(10, 5));

            var mercedes34 = new Mercedes();
            Console.WriteLine(mercedes34.StartEngine(100));

            Console.WriteLine(mercedes34.CalculateConsumption(1, 2, 3, 4, 5, 6));

            Console.WriteLine(FizzBuzz.GetFizzBuzz(15));

            Console.WriteLine("This is my first C# project!");
            Console.ReadKey();
        }
    }
}
