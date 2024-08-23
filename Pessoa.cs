using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Pessoa
    {
        public static int IdadeMinima;
        public int Idade { get; set; }
        public string Name { get; set; } = string.Empty;

        public Pessoa(int idade, string name)
        {
            Console.WriteLine("\nExecutando o construtor parametrizado");
            Idade = idade;
            Name = name;
        }

        public Pessoa()
        {}

        static Pessoa()
        {
            Console.WriteLine("\nExecutando o construtor estatico");
            Console.WriteLine("\nInicializando idade minima");
            IdadeMinima = 18;
        }
        
    }
}