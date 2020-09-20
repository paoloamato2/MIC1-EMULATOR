namespace MIC1_SYS.Emulatore.Controllo
{
    public class MemoriaControlloStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile MemoriaControlloStatoOttenuto _mcso;


        public MemoriaControlloStatoOttenuto()
        {
            Data = new string[512];
        }

        public string[] Data { get; set; }

        public static MemoriaControlloStatoOttenuto GetInstance()
        {
            if (_mcso != null) return _mcso;
            lock (Object)
            {
                if (_mcso == null) _mcso = new MemoriaControlloStatoOttenuto();
            }

            return _mcso;
        }
    }
}