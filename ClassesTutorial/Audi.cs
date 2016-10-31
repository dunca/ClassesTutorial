using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Audi : Car
    {
        public int Vitezometru(int acceleratie)
        {
            //if (acceleratie == 1)
            //{
            //    return 50;
            //}
            //else if (acceleratie == 2)
            //{
            //    return 100;
            //}
            //else if (acceleratie == 3)
            //{
            //    return 150;
            //}
            //else
            //{
            //    return 0;
            //}

            switch (acceleratie)
            {
                case 1:
                    return 50;
                case 2:
                    return 100;
                case 3:
                    return 150;
                default:
                    return 0;
            }
        }
    }
}
