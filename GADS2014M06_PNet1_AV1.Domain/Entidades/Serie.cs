using System;

namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{

    public class Serie
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public string Criador { get; set; }

        public DateTime DataHoraApresentacao { get; set; }
        public string ImagemCapa { get; set; }


        //representando os relacionamentos exeternos:
        public int GeneroId { get; set; }
        public int PaisId { get; set; }
        public int CanalTvId { get; set; }

        

    }
}