namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class ShiftRegister
    {
        private static readonly object Object = new object();
        private static volatile ShiftRegister _sr;
        private BUS_C _busC;

        public ShiftRegister()
        {
            _busC = BUS_C.GetInstance();
        }

        public string Operation { get; set; }

        public string Dato { get; set; }

        public static ShiftRegister GetInstance()
        {
            if (_sr != null) return _sr;
            lock (Object)
            {
                if (_sr == null) _sr = new ShiftRegister();
            }

            return _sr;
        }

        public void execute_op()
        {
            Dato = Operation switch
            {
                "10" => (Dato.Substring(8, 24) + "00000000"),
                "01" => (Dato[0] + Dato.Substring(0, 31)),
                _ => Dato
            };
        }
    }
}