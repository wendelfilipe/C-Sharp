// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("Elemento");

var filmes = new List<Filme>
{
    new Filme("Titanic", 7),
    new Filme("De volta para o futuro", 8),
    new Filme("Mulher Maravilha", 6)
};

var filmeFavorito = new Filme("O quito elemento", 10);

var filmeAssistir = filmes.Where(f => f.Classificacao >= 9).DefaultIfEmpty(filmeFavorito).First();

Console.WriteLine(filmeAssistir.Name);

Console.ReadKey();