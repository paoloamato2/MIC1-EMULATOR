namespace MIC1_SYS.Emulatore.Controllo
{
    public class BusCStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile BusCStatoOttenuto _bcso;

        public BusCStatoOttenuto()
        {
            Operation = "000000000";
            Dato = "00000000000000000000000000000000";
        }


        public string Operation { get; set; }

        public string Dato { get; set; }

        public static BusCStatoOttenuto GetInstance()
        {
            if (_bcso != null) return _bcso;
            lock (Object)
            {
                if (_bcso == null) _bcso = new BusCStatoOttenuto();
            }

            return _bcso;
        }
    }
}