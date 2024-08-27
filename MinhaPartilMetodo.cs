using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public partial class MinhaPartilClass
    {
        public TimeSpan CalculaIdade(DateTime DataNascimento)
        {
            return DateTime.Now.Date - DataNascimento;
        }

        public TimeSpan DifetencaEntreDatas(DateTime date1, DateTime date2)
        {
            var diferenca = date1.Subtract(date2);
            return diferenca;
        }
    }
}