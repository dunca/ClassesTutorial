using System;

namespace ClassesTutorial
{
    internal class Mercedes : AbstractCar
    {
        private string _description;
        private int _price;

        internal string Description { get { return _description; } set { _description = value; } }
        internal int Price { get { return _price; } set { _price = value; } }

        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }
    }
}
