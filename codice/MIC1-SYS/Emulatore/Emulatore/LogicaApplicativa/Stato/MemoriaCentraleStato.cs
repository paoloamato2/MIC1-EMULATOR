namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class MemoriaCentraleStato
    {
        private static readonly object Object = new object();
        private static volatile MemoriaCentraleStato _mcs;
        private readonly MemoriaCentrale _ram;

        public MemoriaCentraleStato()
        {
            _ram = MemoriaCentrale.GetInstance();
            Data = _ram.Data;
        }

        public string[] Data { get; set; }

        public static MemoriaCentraleStato GetInstance()
        {
            if (_mcs != null) return _mcs;
            lock (Object)
            {
                if (_mcs == null) _mcs = new MemoriaCentraleStato();
            }

            return _mcs;
        }


        public void AggiornaStato()
        {
            Data = _ram.Data;
        }
    }
}