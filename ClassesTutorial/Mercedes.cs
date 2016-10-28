using System;

namespace ClassesTutorial
{
    internal class Mercedes : AbstractCar
    {
        private string _description;
        private int counter;
        private int _price;

        public static int counter2;

        internal string Description { get { return _description; } set { _description = value; } }
        internal int Price { get { return _price; } set { _price = value; } }

        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }

        public string StartEngine()
        {
            return "Engine started";
        }

        public double ShowRemainingNoOfKM(double noOfFuelLiters, double consumption)
        {
            return noOfFuelLiters / consumption * 100;
        }

        public string StartEngine(int ms)
        {
            return $"The car will start in {ms} milliseconds";
        }

        public double CalculateConsumption(params int[] kilometers)
        {
            double sum = 0;

            foreach (int km in kilometers)
            {
                sum += km;
            }

            return sum / 100 * 7;
        }

        public void PrintMercedesLogo()
        {
            Console.WriteLine("This is the logo");
            counter++;

            if (counter == 3)
            {
                return;
            }

            PrintMercedesLogo();
        }

        public void PrintNewMercedes(int c)
        {
            if (c == 3)
            {
                return;
            }

            Console.WriteLine($"Mercedes no. = {c}");
        }
    }
}
