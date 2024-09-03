using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Circulo : Forma
    {
        public Circulo()
        {
        }

        public Circulo(int x, int y) : base(x, y)
        {
        }

        public void PintarCirculo()
        {
            Console.WriteLine("O circulo foi pintado");
        }
    }
}