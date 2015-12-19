namespace GADS2014M06_PNet1_AV1.Domain.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        //Expression Body (C# 6.0)
        public override string ToString() => $"Gênero:\nId: {Id} - Descrição: {Descricao}";
    }


}