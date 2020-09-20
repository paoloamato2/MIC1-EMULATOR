namespace MIC1_SYS.Emulatore.Controllo
{
    public class ProgrammaOttenuto
    {
        public ProgrammaOttenuto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }

        public string Nome { get; set; }
    }
}