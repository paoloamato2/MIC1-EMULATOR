namespace MIC1_SYS.Emulatore.Controllo
{
    public class UnitàOperativaStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile UnitàOperativaStatoOttenuto _uoso;

        public UnitàOperativaStatoOttenuto()
        {
            Srso = ShiftRegisterStatoOttenuto.GetInstance();
            Aso = AluStatoOttenuto.GetInstance();
            Bcso = BusCStatoOttenuto.GetInstance();
            Bbso = BusBStatoOttenuto.GetInstance();
            Rso = RegistriStatoOttenuto.GetInstance();
            Operation = "000000000000000000000000000000000000";
        }

        public string Operation { get; set; }

        public ShiftRegisterStatoOttenuto Srso { get; set; }

        public AluStatoOttenuto Aso { get; set; }

        public BusCStatoOttenuto Bcso { get; set; }

        public BusBStatoOttenuto Bbso { get; set; }

        public RegistriStatoOttenuto Rso { get; set; }

        public static UnitàOperativaStatoOttenuto GetInstance()
        {
            if (_uoso != null) return _uoso;
            lock (Object)
            {
                if (_uoso == null) _uoso = new UnitàOperativaStatoOttenuto();
            }

            return _uoso;
        }
    }
}