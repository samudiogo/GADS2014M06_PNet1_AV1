using System;

namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{
    /// <summary>
    /// Sessão representa a temporada da serie
    /// </summary>
    public class Sessao
    {
        /// <summary>
        /// Id : S01, S02
        /// </summary>
        public string Id { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Sinopse { get; set; }
        public string ImagemCapa { get; set; }

    }
}