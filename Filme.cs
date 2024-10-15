using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Filme
    {

        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Tipo { get; set; }
        
        public int Classificacao { get; set; }
        
        public Filme(string name, int classificacao)
        {
            Name = name;
            Classificacao = classificacao;
        }
        
    }
}