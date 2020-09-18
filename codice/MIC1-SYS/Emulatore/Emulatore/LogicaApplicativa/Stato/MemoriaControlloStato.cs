namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class MemoriaControlloStato
    {
        private static readonly object Object = new object();
        private static volatile MemoriaControlloStato _mcs;
        private readonly MemoriaControllo _mc;

        public MemoriaControlloStato()
        {
            _mc = MemoriaControllo.GetInstance();
            Data = _mc.Data;
        }

        public string[] Data { get; set; }

        public static MemoriaControlloStato GetInstance()
        {
            if (_mcs != null) return _mcs;
            lock (Object)
            {
                if (_mcs == null) _mcs = new MemoriaControlloStato();
            }

            return _mcs;
        }

        public void AggiornaStato()
        {
            Data = _mc.Data;
        }
    }
}