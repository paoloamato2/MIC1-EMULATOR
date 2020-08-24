using MIC1_SYS.Emulatore.LogicaApplicativa.Interprete;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa
{
    public class FacadeEmulatore
    {
        private readonly FacadeInterprete _fi;
        private FacadeStato _fs;


        public FacadeEmulatore()
        {
            _fi = new FacadeInterprete();
            _fs = new FacadeStato();
        }

        public bool AvviaCiclo()
        {
            return _fi.AvviaCiclo();
        }

        public void InizializzaProgramma(string nome, int id, string percorso)
        {
        }

        public void InizializzaMicroProgramma(string nome, int id, string percorso)
        {
        }
    }
}