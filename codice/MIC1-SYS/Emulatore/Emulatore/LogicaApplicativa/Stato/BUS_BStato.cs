namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusBStato
    {
        private static readonly object Object = new object();
        private static volatile BusBStato _bbs;
        private readonly BusB _busB;


        public BusBStato()
        {
            _busB = BusB.GetInstance();
            Operation = _busB.Operation;
            Dato = _busB.Dato;
        }

        public string Operation { get; set; }

        public string Dato { get; set; }

        public static BusBStato GetInstance()
        {
            if (_bbs != null) return _bbs;
            lock (Object)
            {
                if (_bbs == null) _bbs = new BusBStato();
            }

            return _bbs;
        }

        public void AggiornaStato()
        {
            Operation = _busB.Operation;
            Dato = _busB.Dato;
        }
    }
}