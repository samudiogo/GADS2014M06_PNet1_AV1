using System;
using System.Text;

namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{

    public class Serie
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public string Criador { get; set; }

        public DateTime DataHoraApresentacao { get; set; }
        public string ImagemCapa { get; set; }


        //representando os relacionamentos exeternos:
        public int GeneroId { get; set; }
        public int PaisId { get; set; }
        public int CanalTvId { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Serie:");
            sb.AppendLine($"Id:{Id}\t - Nome: {Nome}");
            sb.AppendLine($"Sinopse: {Sinopse}\nCriador: {Criador}\t | Data: {DataHoraApresentacao}");
            sb.AppendLine($"Capa:{ImagemCapa}\nGeneroId: {GeneroId}\t | PaisId: {PaisId}\t | CanalTVid: {CanalTvId}");
            return sb.ToString();
        }
    }
}