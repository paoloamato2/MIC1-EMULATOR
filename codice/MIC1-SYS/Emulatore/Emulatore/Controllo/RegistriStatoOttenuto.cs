namespace MIC1_SYS.Emulatore.Controllo
{
    public class RegistriStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile RegistriStatoOttenuto _rso;

        public RegistriStatoOttenuto()
        {
            Mar = "00000000000000000000000000000000";
            Mdr = "00000000000000000000000000000000";
            Pc = "00000000000000000000000000000000";
            Mbr = "00000000000000000000000000000000";
            Sp = "00000000000000000000000000000000";
            Lv = "00000000000000000000000000000000";
            Cpp = "00000000000000000000000000000000";
            Tos = "00000000000000000000000000000000";
            Opc = "00000000000000000000000000000000";
            H = "00000000000000000000000000000000";
        }


        public string Mar { get; set; }

        public string Mdr { get; set; }

        public string Pc { get; set; }

        public string Mbr { get; set; }

        public string Sp { get; set; }

        public string Lv { get; set; }

        public string Cpp { get; set; }

        public string Tos { get; set; }

        public string Opc { get; set; }

        public string H { get; set; }

        public static RegistriStatoOttenuto GetInstance()
        {
            if (_rso != null) return _rso;
            lock (Object)
            {
                if (_rso == null) _rso = new RegistriStatoOttenuto();
            }

            return _rso;
        }
    }
}