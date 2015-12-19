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
            var pais = new Pais { Id = 1, Nome = "Brasil" };
            ReadLine();
            //b) instanciar um Gênero e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var genero = new Genero { Id = 2, Descricao = "Drama" };
            ReadLine();

            //c) instanciar um "Canal de Tv" e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var canal = new CanalTv { Id = 1, Nome = "AXN" };
            WriteLine($"id:{canal.Id}\t - Descricao: {canal.Nome}");
            ReadLine();
            //d) instanciar uma Série e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var serie = new Serie { Id = 1, Nome = "CSI" };
            WriteLine($"id:{serie.Id}\t - Descricao: {serie.Nome}");
            ReadLine();
            //e) instanciar uma Sessão e apresentar na tela seus dados.Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            WriteLine("Escolha um Sessao abaixo:");
            var sessao1 = new Sessao { Id = "S01", DataLancamento = DateTime.Now.AddMonths(-20),Sinopse = "nesta temporada muita coisa pode ou não acontecer..",ImagemCapa = @"C:\capa_sessao1.png"};
            WriteLine($"id:{sessao1.Id}\t - Descricao: {sessao1.DataLancamento}\nSinopse: {sessao1.Sinopse}");
            WriteLine($"Data: {sessao1.DataLancamento}\t - Capa: {sessao1.ImagemCapa}");
            ReadLine();
            //f) instanciar um Episódio e apresentar na tela seus dados.Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            WriteLine("Escolha um Episódio abaixo:");
            var episodio = new Episodio { Id = "E01", DataExibicao = DateTime.Now.AddDays(-15), Titulo = "a volta dos que nao foram p2", FormatoAudio = FormatoAudioEnum.Legendado, SerieId = serie.Id, Duracao = 90, TipoArquivo = "mkv", Sinopse = "acontece que aconteceu o que tinha que acontecer" };
            ReadLine();

        }
    }
}
