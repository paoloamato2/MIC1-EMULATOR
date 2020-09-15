namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class FacadeInterprete
    {
        private static readonly object Object = new object();
        private static volatile FacadeInterprete _fi;
        private UnitàControllo _uc;

        private FacadeInterprete()
        {
        }

        public static FacadeInterprete GetInstance()
        {
            if (_fi != null) return _fi;
            lock (Object)
            {
                if (_fi == null) _fi = new FacadeInterprete();
            }

            return _fi;
        }

        public bool AvviaCiclo()
        {
            _uc = UnitàControllo.GetInstance();
            while (true) _uc.EseguiCiclo();
        }

        public void SetStepByStep(bool p0)
        {
            _uc = UnitàControllo.GetInstance();
            _uc.Stepbystep = p0;
        }

        public void Reset()
        {
            _uc = UnitàControllo.GetInstance();
            _uc.ResetFlag = true;
        }
    }
}