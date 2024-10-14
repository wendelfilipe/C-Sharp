using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class Aluno
    {
        public string Name { get; set; } = string.Empty;

        public int Idade { get; set; }
        
        public int Nota { get; set; }

        public string Sexo { get; set; }
        
        
        
        public List<string> Cursos { get; set; } = new List<string>();
    }
}