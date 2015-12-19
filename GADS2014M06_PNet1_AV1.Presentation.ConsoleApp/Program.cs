using System;
using GADS2014M06_PNet1_AV1.Domain.Entidades;
using static System.Console;

namespace GADS2014M06_PNet1_AV1.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) instanciar um País e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var pais = new Pais
            {
                Id = 1,
                Nome = "Brasil"
            };
            WriteLine(pais);
            ReadLine();
            //b) instanciar um Gênero e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var genero = new Genero
            {
                Id = 2,
                Descricao = "Drama"
            };
            WriteLine(genero);
            ReadLine();

            //c) instanciar um "Canal de Tv" e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var canal = new CanalTv
            {
                Id = 1,
                Nome = "AXN"
            };
            WriteLine(canal);
            ReadLine();
            //d) instanciar uma Série e apresentar na tela seus dados. Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var serie = new Serie
            {
                Id = 1,
                Nome = "CSI .NET",
                Criador = "Supremo Samuel Diogo",
                Sinopse = "O Detetive samuel ajuda a turma mas não termina p@rra da prova",
                DataHoraApresentacao = DateTime.Now.AddDays(-175),
                ImagemCapa = @"c:\imagem.png",
                CanalTvId = canal.Id,
                PaisId = pais.Id,
                GeneroId = genero.Id
            };
            WriteLine(serie);

            ReadLine();
            //e) instanciar uma Sessão e apresentar na tela seus dados.Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var sessao01 = new Sessao
            {
                Id = "S01",
                DataLancamento = DateTime.Now.AddMonths(-20),
                Sinopse = "nesta temporada muita coisa pode ou não acontecer..",
                ImagemCapa = @"C:\capa_sessao1.png",
                SerieId = serie.Id
            };
            WriteLine(sessao01);
            ReadLine();
            //f) instanciar um Episódio e apresentar na tela seus dados.Acrescente uma instrução que me permita ler a informação, antes de prosseguir.
            var episodio = new Episodio
            {
                Id = "E01",
                DataExibicao = DateTime.Now.AddDays(-15),
                Titulo = "a volta dos que nao foram p2",
                FormatoAudio = FormatoAudioEnum.Legendado,
                Duracao = 90,
                TipoArquivo = "mkv",
                Sinopse = "acontece que aconteceu o que tinha que acontecer",
                SerieId = serie.Id
            };
            WriteLine(episodio);
            ReadLine();

        }
    }
}
