using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Quadrada : Forma
    {
        private double Lado { get; set; }
        public Quadrada(double lado)
        {
            Lado = lado;
        }
        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimentro()
        {
            Perimetro = 4 * Lado;
        }
    }
}