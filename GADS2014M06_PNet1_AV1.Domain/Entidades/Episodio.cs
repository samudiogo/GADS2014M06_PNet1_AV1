using System;
using System.Runtime.ExceptionServices;

namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{
    public class Episodio
    {
        //Para cada episódio, você deve ter o título, "número" (E01, E02, E03 e assim por diante...), sinopse, data que o episódio foi ao ar, duração, se baixou, se viu, caminho completo onde se encontra o arquivo, Tipo de arquivo (que deve ser mantido - mp4, mkv...), se é dublado ou legendado, Sessão da série a qual pertence (SessaoId).
        /// <summary>
        /// representa o numero do epsodio: E01, E02, E03
        /// </summary>
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataExibicao { get; set; }
        public TimeSpan Duracao { get; set; }
        public string TipoArquivo { get; set; }
        /// <summary>
        /// Se é Dublado ou Linguagem Original
        /// </summary>
        public FormatoAudioEnum FormatoAudio { get; set; }

        //relacionamento

        public int SerieId { get; set; }
        public TYPE Type { get; set; }
    }
}