namespace MIC1_SYS.Emulatore.Controllo
{
    public class AluStatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile AluStatoOttenuto _aso;

        public AluStatoOttenuto()
        {
            Operation = "000000";
            OperandA = "00000000000000000000000000000000";
            OperandB = "00000000000000000000000000000000";
            Risultato = "00000000000000000000000000000000";
            NFlag = false;
            ZFlag = false;
        }

        public string Operation { get; set; }

        public string OperandA { get; set; }

        public string OperandB { get; set; }

        public string Risultato { get; set; }

        public bool NFlag { get; set; }

        public bool ZFlag { get; set; }

        public static AluStatoOttenuto GetInstance()
        {
            if (_aso != null) return _aso;
            lock (Object)
            {
                if (_aso == null) _aso = new AluStatoOttenuto();
            }

            return _aso;
        }
    }
}