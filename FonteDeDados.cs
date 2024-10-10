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
                new Aluno() { Name = "Julia", Idade = 17, Nota = 4, Cursos = null },
                new Aluno() { Name = "Alicia", Idade = 17, Nota = 4, Cursos = null },
                 new Aluno() { Name ="Matheus", Idade = 18, Nota = 9, Cursos = null },
            };
            return alunos;
        }

        public static int[] GetIdades()
        {
            var idades = new  int[] {30, 33, 35, 36, 40, 30, 33, 36, 30, 30};
            return idades;
        }

        public static string[] GetNomes()
        {
            var nomes = new  string[] {"Paulo", "Maria", "ana", "paulo", "maria", "Amanda"};
            return nomes;
        }
    }
}