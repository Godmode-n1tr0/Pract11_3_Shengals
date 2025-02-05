using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract11_3_Shengals
{
    public partial class Robot
    {
        public int kollife;
        public int Getlife()
        {
            return kollife;
        }
        public void Min(int a)
        {
            Random rn1 = new Random();
            kollife = a;
            kollife = rn1.Next(0, (a * 70 / 100));
        }
        public void Kol(int a, int k)
        {
            if (k == a / 2)
            {
                kollife = kollife + 30;
            }
            else if (k == a * 0.7)
            {
                kollife += 20;
            }
        }
    }
}
