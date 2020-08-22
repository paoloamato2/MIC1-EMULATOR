using MIC1_SYS.Emulatore.LogicaApplicativa.Interprete;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa
{
    public class FacadeEmulatore
    {
        private readonly FacadeInterprete FI;
        private FacadeStato FS;


        public FacadeEmulatore()
        {
            FI = new FacadeInterprete();
            FS = new FacadeStato();
        }

        public bool AvviaCiclo()
        {
            return FI.avviaCiclo();
        }

        public void InizializzaProgramma(string Nome, int ID, string Percorso)
        {
        }

        public void InizializzaMicroProgramma(string Nome, int ID, string Percorso)
        {
        }
    }
}