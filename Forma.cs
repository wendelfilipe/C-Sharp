using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Forma
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Forma()
        {
            
        }

        public Forma(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void DesenharForma()
        {
            Console.WriteLine("A forma foi desenhada");
        }
    }
}