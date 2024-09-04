using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Triangulo");
            base.Desenhar();
        }
    }
}