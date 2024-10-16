using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class FonteDeDados
    {
        public static IEnumerable<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() { Id = 1, Name = "Maria", Idade = 22, Nota = 7, Cursos = null, Sexo = "Feminino" },
                new Aluno() { Id = 2,Name = "Amanda", Idade = 21, Nota = 6, Cursos = null, Sexo = "Feminino" },
                new Aluno() { Id = 3, Name = "Carlos", Idade = 18, Nota = 9, Cursos = null, Sexo = "Masculino" },
                new Aluno() { Id = 4, Name = "Julia", Idade = 17, Nota = 4, Cursos = null, Sexo = "Feminino" },
                new Aluno() { Id = 5, Name = "Alicia", Idade = 17, Nota = 4, Cursos = null, Sexo = "Feminino" },
                new Aluno() { Id = 6, Name ="Matheus", Idade = 18, Nota = 9, Cursos = null, Sexo = "Masculino" },
            };
            return alunos.AsEnumerable();
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