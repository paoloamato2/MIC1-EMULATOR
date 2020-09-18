namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusCStato
    {
        private static readonly object Object = new object();
        private static volatile BusCStato _bcs;
        private readonly BusC _busC;

        public BusCStato()
        {
            _busC = BusC.GetInstance();
            Operation = _busC.Operation;
            Dato = _busC.Dato;
        }

        public string Operation { get; set; }

        public string Dato { get; set; }

        public static BusCStato GetInstance()
        {
            if (_bcs != null) return _bcs;
            lock (Object)
            {
                if (_bcs == null) _bcs = new BusCStato();
            }

            return _bcs;
        }

        public void AggiornaStato()
        {
            Operation = _busC.Operation;
            Dato = _busC.Dato;
        }
    }
}