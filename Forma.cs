using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public abstract class Forma
    {
        public string? Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public abstract void CalcularPerimentro();
        public abstract void CalcularArea();

        public string Descricao()
        {
            return "Sou a classe abstrata Forma";
        }
    }
}