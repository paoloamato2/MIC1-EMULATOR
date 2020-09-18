namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class Stato
    {
        private static readonly object Object = new object();
        private static volatile Stato _stato;

        public Stato()
        {
            StatoAggiornato = true;
            Cms = MemoriaControlloStato.GetInstance();
            Mcs = MemoriaCentraleStato.GetInstance();
            Uos = UnitàOperativaStato.GetInstance();
        }

        public bool StatoAggiornato { get; set; }

        public MemoriaControlloStato Cms { get; set; }

        public MemoriaCentraleStato Mcs { get; set; }

        public UnitàOperativaStato Uos { get; set; }

        public static Stato GetInstance()
        {
            if (_stato != null) return _stato;
            lock (Object)
            {
                if (_stato == null) _stato = new Stato();
            }

            return _stato;
        }

        public void AggiornaStato()
        {
            Cms.AggiornaStato();
            Mcs.AggiornaStato();
            Uos.AggiornaStato();
            StatoAggiornato = true;
        }
    }
}