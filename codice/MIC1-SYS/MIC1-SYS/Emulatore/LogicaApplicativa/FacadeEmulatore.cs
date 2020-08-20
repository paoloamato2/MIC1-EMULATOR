using System;
using MIC1_SYS.Emulatore.LogicaApplicativa.Interprete;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa
{


    public class FacadeEmulatore
    {
        private FacadeInterprete FI;
        private FacadeStato FS;


        public FacadeEmulatore()
        {
            FI = new FacadeInterprete();
            FS = new FacadeStato();
        }

        public bool AvviaCiclo()
        {
            return false;
        }

        public void InizializzaProgramma(String Nome,int ID,String Percorso)
        {

        }

        public void InizializzaMicroProgramma(String Nome, int ID, String Percorso)
        {

        }

    }
}
