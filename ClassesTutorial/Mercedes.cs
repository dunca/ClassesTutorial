using System;

namespace ClassesTutorial
{
    public class Mercedes : AbstractCar
    {
        public string description;
        public int price;

        public Mercedes()
        {
            description = "E Class";
            price = 67000;
        }
    }
}
