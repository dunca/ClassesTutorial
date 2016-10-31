using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Ionatan : Apple
    {
        public int GetCalories()
        {
            return 3;
        }

        public Ionatan()
        {
            Console.WriteLine("Ionatan has been instantiated");
        }
    }
}
