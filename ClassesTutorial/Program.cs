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

            Console.WriteLine("This is my first C# project!");
            Console.ReadKey();
        }
    }
}
