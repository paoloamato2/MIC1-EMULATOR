namespace MIC1_SYS.Emulatore.Controllo
{
    public class ShiftRegisterStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile ShiftRegisterStatoOttenuto _srso;

        public ShiftRegisterStatoOttenuto()
        {
            Dato = "00000000000000000000000000000000";
            Operation = "00";
        }

        public string Dato { get; set; }

        public string Operation { get; set; }


        public static ShiftRegisterStatoOttenuto GetInstance()
        {
            if (_srso != null) return _srso;
            lock (Object)
            {
                if (_srso == null) _srso = new ShiftRegisterStatoOttenuto();
            }

            return _srso;
        }
    }
}