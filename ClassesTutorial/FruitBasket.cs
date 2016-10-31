using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class FruitBasket
    {
        public List<Fruit> listaDeFructe;

        public FruitBasket()
        {
            listaDeFructe = new List<Fruit>();
        }

        public void AddFruit(Fruit fruct)
        {
            listaDeFructe.Add(fruct);
        }

        public void DisplayFruitCalories()
        {
            foreach (var fruct in listaDeFructe)
            {
                Console.WriteLine(fruct.GetCalories());
            }
        }
    }
}
