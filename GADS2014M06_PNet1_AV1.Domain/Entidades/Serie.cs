using System;

namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{
    public class Serie
    {
        // Nome, criador, País (PaisId), Gênero (GeneroId), sinopse, qual o Canal de TV (CanalDeTvId) oficial que apresenta a série, qual o dia da semana e horário do episódio e uma foto de capa (caminho da foto).
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }

        public DateTime DataHoraApresentacao { get; set; }
        public string ImagemCapa { get; set; }

        public int GeneroId { get; set; }
        public int PaisId { get; set; }
        public int CanalTvId { get; set; }

    }
}