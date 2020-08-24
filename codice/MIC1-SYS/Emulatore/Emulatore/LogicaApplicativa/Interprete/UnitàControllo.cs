namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControllo
    {
        private static volatile UnitàControllo _uc;
        private static readonly object Object = new object();
        private UnitàControlloState _state;

        public UnitàControllo()
        {
            Mpc = "000000000";
            Mir = "000000000000000000000000000000000000";
            NFf = 0;
            ZFf = 0;
            ResetFlag = false;
            _state = UnitàControlloState.GetInstance("Reset");
        }

        public string Mpc { get; set; }

        public string Mir { get; set; }

        public int NFf { get; set; }

        public int ZFf { get; set; }

        public bool ResetDone { get; set; }

        public bool ResetFlag { get; set; }

        public static UnitàControllo GetInstance()
        {
            if (_uc != null) return _uc;
            lock (Object)
            {
                if (_uc == null) _uc = new UnitàControllo();
            }

            return _uc;
        }

        public void SetState(UnitàControlloState nextState)
        {
            _state = nextState;
        }

        public void EseguiCiclo()
        {
            _state.EseguiCiclo();
        }
    }
}