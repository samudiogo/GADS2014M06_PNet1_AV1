using System;
using System.Text;

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

        //Relacionamento:

        public int SerieId { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Temporada (Sessão):");
            sb.AppendLine($"Id: {Id}\t| Data: {DataLancamento}");
            sb.AppendLine($"Sinopse: {Sinopse}");
            sb.AppendLine($"Capa: {ImagemCapa}");
            sb.AppendLine($"SerieId: {SerieId}");
            return sb.ToString();
        }
    }
}