using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class FonteDeDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() { Name = "Maria", Idade = 22, Nota = 7, Cursos = null },
                new Aluno() { Name = "Amanda", Idade = 21, Nota = 6, Cursos = null },
                new Aluno() { Name = "Carlos", Idade = 18, Nota = 9, Cursos = null },
                new Aluno() { Name = "Alicia", Idade = 17, Nota = 4, Cursos = null }
            };
            return alunos;
        }
    }
}