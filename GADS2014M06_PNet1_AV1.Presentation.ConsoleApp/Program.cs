using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GADS2014M06_PNet1_AV1.Domain.Entidades;

using static System.Console;

namespace GADS2014M06_PNet1_AV1.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //a) instanciar um País e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var paises = new List<Pais>
            {
                new Pais {Id = 1, Nome = "Brasil"},
                new Pais {Id = 2, Nome = "USA"}
            };
            WriteLine("Escolha um pais abaixo:");
            ExibePais(paises);
            ReadLine();
            //b) instanciar um Gênero e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var generos = new List<Genero>
            {
                new Genero {Id = 1, Descricao = "Investigação"},
                new Genero {Id = 2, Descricao = "Drama"}

            };
            WriteLine("Escolha um genero abaixo:");
            ExibeGenero(generos);
            ReadLine();

            //c) instanciar um "Canal de Tv" e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            WriteLine("Escolha um Canal de Tv abaixo:");
            var canal = new CanalTv {Id = 1, Nome = "AXN"};

            WriteLine($"id:{canal.Id}\t - Descricao: {canal.Nome}");

            //d) instanciar uma Série e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            WriteLine("Escolha um Série abaixo:");
            var serie = new Serie {Id = 1, Nome = "CSI"};
            WriteLine($"id:{serie.Id}\t - Descricao: {serie.Nome}");
            ReadLine();
            //e) instanciar uma Sessão e apresentar na tela seus dados.Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            WriteLine("Escolha um Sessao abaixo:");
            var sessao1 = new Sessao {Id = "S01", DataLancamento = DateTime.Now.AddMonths(-20)};
            WriteLine($"id:{sessao1.Id}\t - Descricao: {sessao1.DataLancamento}");
            ReadLine();
            //f) instanciar um Episódio e apresentar na tela seus dados.Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            WriteLine("Escolha um Episódio abaixo:");
            var episodios = new List<Episodio>
            {
                new Episodio
                {
                    Id = "E01",
                    DataExibicao = DateTime.Now.AddDays(-15),
                    Titulo = "a volta dos que nao foram p2"
                },
                new Episodio
                {
                    Id = "E02",
                    DataExibicao = DateTime.Now.AddDays(-45),
                    Titulo = "a volta dos que nao foram p1"
                },
            };
            ExibeEpisodios(episodios);
            ReadLine();

        }

        public static void ExibePais(List<Pais> paises )
        {
            foreach(var p in paises)
                WriteLine($"id: {p.Id}\t - Nome: {p.Nome}");
        }

        public static void ExibeGenero(List<Genero> generos)
        {
            foreach (var g in generos)
                WriteLine($"id: {g.Id}\t - Descricao: {g.Descricao}");
        }

        public static void ExibeEpisodios(List<Episodio> episodios)
        {
            foreach (var g in episodios)
                WriteLine($"Id: {g.Id}\t - Titulo: {g.Titulo} - \tExibido em: {g.DataExibicao.ToString()}");
        }

    }
}
