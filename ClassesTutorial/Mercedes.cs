using System;

namespace ClassesTutorial
{
    protected class Mercedes : AbstractCar // won't compile
    {
        private string _description;
        private int _price;

        // won't be accessible from within Program.cs
        protected string Description { get { return _description; } set { _description = value; } }
        protected int Price { get { return _price; } set { _price = value; } }

        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }
    }
}
