namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class UnitàOperativaStato
    {
        private static readonly object Object = new object();
        private static volatile UnitàOperativaStato _uos;
        private readonly UnitàOperativa _uo;

        public UnitàOperativaStato()
        {
            _uo = UnitàOperativa.GetInstance();
            Srs = ShiftRegisterStato.GetInstance();
            As = AluStato.GetInstance();
            Bcs = BusCStato.GetInstance();
            Bbs = BusBStato.GetInstance();
            Rs = RegistriStato.GetInstance();
            Operation = _uo.Operation;
        }

        public string Operation { get; set; }

        public ShiftRegisterStato Srs { get; set; }

        public AluStato As { get; set; }

        public BusCStato Bcs { get; set; }

        public BusBStato Bbs { get; set; }

        public RegistriStato Rs { get; set; }

        public static UnitàOperativaStato GetInstance()
        {
            if (_uos != null) return _uos;
            lock (Object)
            {
                if (_uos == null) _uos = new UnitàOperativaStato();
            }

            return _uos;
        }


        public void AggiornaStato()
        {
            Operation = _uo.Operation;
            Srs.AggiornaStato();
            As.AggiornaStato();
            Bcs.AggiornaStato();
            Bbs.AggiornaStato();
            Rs.AggiornaStato();
        }
    }
}