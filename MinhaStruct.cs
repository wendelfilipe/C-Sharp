using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    internal struct MinhaStruct
    {
        int MeuCampo;
        string MinhaProp { get; set; }

        void MeuMetodo()
        {
            Console.WriteLine("Meu Metodo");
        }
    }
}