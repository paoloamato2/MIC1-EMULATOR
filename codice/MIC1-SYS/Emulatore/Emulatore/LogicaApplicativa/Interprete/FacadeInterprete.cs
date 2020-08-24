namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class FacadeInterprete
    {
        private UnitàControllo _uc;

        public bool AvviaCiclo()
        {
            _uc = UnitàControllo.GetInstance();
            while (true) _uc.EseguiCiclo();
        }
    }
}