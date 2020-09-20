namespace MIC1_SYS.Emulatore.Controllo
{
    public class MemoriaCentraleStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile MemoriaCentraleStatoOttenuto _mcso;


        public MemoriaCentraleStatoOttenuto()
        {
            Data = new string[512];
        }

        public string[] Data { get; set; }

        public static MemoriaCentraleStatoOttenuto GetInstance()
        {
            if (_mcso != null) return _mcso;
            lock (Object)
            {
                if (_mcso == null) _mcso = new MemoriaCentraleStatoOttenuto();
            }

            return _mcso;
        }
    }
}