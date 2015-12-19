namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //Expression Body (C# 6.0)
        public override string ToString() => $"País:\nId: {Id}\tNome: {Nome}";
    }
}