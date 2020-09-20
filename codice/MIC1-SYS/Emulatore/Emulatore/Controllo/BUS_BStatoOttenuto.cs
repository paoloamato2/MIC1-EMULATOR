namespace MIC1_SYS.Emulatore.Controllo
{
    public class BusBStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile BusBStatoOttenuto _bbso;


        public BusBStatoOttenuto()
        {
            Operation = "0000";
            Dato = "000000000000000000000000000000";
        }


        public string Operation { get; set; }

        public string Dato { get; set; }

        public static BusBStatoOttenuto GetInstance()
        {
            if (_bbso != null) return _bbso;
            lock (Object)
            {
                if (_bbso == null) _bbso = new BusBStatoOttenuto();
            }

            return _bbso;
        }
    }
}