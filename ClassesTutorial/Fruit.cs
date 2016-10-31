using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class Fruit
    {

        private class Sambure
        {

        }

        int fibres;

        public virtual int GetCalories()
        {
            return 1;
        }

        public Fruit()
        {
            Console.WriteLine("Fruit has been instantiated");
        }
    }
}
