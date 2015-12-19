namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{
    public class CanalTv
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //Expression Body (C# 6.0)
        public override string ToString() => $"Canal de TV:\nid: {Id}\t - Descricao: {Nome}";
    }

}