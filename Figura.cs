using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Figura
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Executando desenhar na clase base");
        }
    }
}