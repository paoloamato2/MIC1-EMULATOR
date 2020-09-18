namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class ShiftRegisterStato
    {
        private static readonly object Object = new object();
        private static volatile ShiftRegisterStato _srs;
        private readonly ShiftRegister _sr;

        public ShiftRegisterStato()
        {
            _sr = ShiftRegister.GetInstance();
            Dato = _sr.Dato;
            Operation = _sr.Operation;
        }

        public string Dato { get; set; }

        public string Operation { get; set; }


        public static ShiftRegisterStato GetInstance()
        {
            if (_srs != null) return _srs;
            lock (Object)
            {
                if (_srs == null) _srs = new ShiftRegisterStato();
            }

            return _srs;
        }

        public void AggiornaStato()
        {
            Dato = _sr.Dato;
            Operation = _sr.Operation;
        }
    }
}