namespace MIC1_SYS.Emulatore.LogicaApplicativa
{
    public class Programma
    {
        public Programma(int id, string nome, string[] data)
        {
            Id = id;
            Nome = nome;
            Data = data;
        }


        public int Id { get; set; }

        public string Nome { get; set; }

        public string[] Data { get; set; }
    }
}