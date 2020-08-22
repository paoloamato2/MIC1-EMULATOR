namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControllo
    {
        private static volatile UnitàControllo UC;
        private static readonly object _object = new object();
        private UnitàControlloState State;

        public UnitàControllo()
        {
            Mpc = "000000000";
            Mir = "000000000000000000000000000000000000";
            NFf = 0;
            ZFf = 0;
            State = UnitàControlloState.getInstance("Reset");
        }

        public string Mpc { get; set; }

        public string Mir { get; set; }

        public int NFf { get; set; }

        public int ZFf { get; set; }

        public static UnitàControllo getInstance()
        {
            if (UC != null) return UC;
            lock (_object)
            {
                if (UC == null) UC = new UnitàControllo();
            }

            return UC;
        }

        public void setState(UnitàControlloState nextState)
        {
            State = nextState;
        }

        public void eseguiCiclo()
        {
            State.eseguiCiclo();
        }
    }
}