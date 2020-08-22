namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class FacadeInterprete
    {
        private UnitàControllo UC;

        public bool avviaCiclo()
        {
            UC = UnitàControllo.getInstance();
            while (true) UC.eseguiCiclo();
        }
    }
}