using System;

namespace ClassesTutorial
{
    public class Mercedes : AbstractCar
    {
        private string _description;
        private int _price;

        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }

        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }
    }
}
