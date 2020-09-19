using System.Collections.Generic;

namespace MIC1_SYS.Emulatore.ServiziTecnici
{
    public abstract class Accesso
    {
        public abstract string[] LeggiContenuto(string percorso);
        public abstract void InserisciProgramma(string nome, int id, string[] data);
        public abstract void AggiornaProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data);

        public abstract void EliminaProgramma(int id);

        public abstract List<string[]> LeggiProgrammi();

        public abstract void InserisciMicroProgramma(string nome, int id, string[] data);

        public abstract void AggiornaMicroProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data);
        public abstract void EliminaMicroProgramma(int id);

        public abstract List<string[]> LeggiMicroProgrammi();
    }
}