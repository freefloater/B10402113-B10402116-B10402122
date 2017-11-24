using System;
using System.Collections.Generic;
using System.Text;

namespace B10402113B10402116B10402122
{
    class ClassA
    {
        public int number = 0;

        public int Rend()
        {
            Random rnd1 = new Random();
            number = rnd1.Next(100);
            return number; 

        }
    }
}
