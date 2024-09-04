using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    internal class Departamento
    {
        public string? Nome { get; set; }
        private List<Professor>? Professores { get; set; }

        public Departamento(string? nome)
        {
            Nome = nome;
            Professores = new List<Professor>();
        }

        public void IncluirProfessor(Professor professor)
        {
            Professores?.Add(professor);
        }

        public void ListaProfessores()
        {
            Console.WriteLine($"\nDepartamento de : {Nome}");

            foreach(var prof in  Professores)
            {
                Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
            }
        }
    }
}