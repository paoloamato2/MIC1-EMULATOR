namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BUS_C
    {
        private static readonly object Object = new object();
        private static volatile BUS_C _busC;
        private readonly Registro[] _registers;


        public string Operation { get; set; }

        public string Dato { get; set; }

        public BUS_C()
        {
            _registers = Registro.getInstance();
        }

        public static BUS_C GetInstance()
        {
            if (_busC == null)
                lock (Object)
                {
                    if (_busC == null) _busC = new BUS_C();
                }

            return _busC;
        }

        public void execute_op()
        {
            switch (Operation)
            {
                case "000000001":
                    _registers[0].Dato = Dato;
                    break;
                case "000000010":
                    _registers[1].Dato = Dato;
                    break;
                case "000000100":
                    _registers[2].Dato = Dato;
                    break;
                case "000001000":
                    _registers[4].Dato = Dato;
                    break;
                case "000010000":
                    _registers[5].Dato = Dato;
                    break;
                case "000100000":
                    _registers[6].Dato = Dato;
                    break;
                case "001000000":
                    _registers[7].Dato = Dato;
                    break;
                case "010000000":
                    _registers[8].Dato = Dato;
                    break;
                case "100000000":
                    _registers[9].Dato = Dato;
                    break;
            }
        }
    }
}