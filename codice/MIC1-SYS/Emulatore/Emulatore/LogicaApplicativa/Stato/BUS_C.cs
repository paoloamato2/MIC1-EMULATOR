namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusC
    {
        private static readonly object Object = new object();
        private static volatile BusC _busC;
        private readonly Registro[] _registers;

        public BusC()
        {
            _registers = Registro.GetInstance();
        }


        public string Operation { get; set; }

        public string Dato { get; set; }

        public static BusC GetInstance()
        {
            if (_busC != null) return _busC;
            lock (Object)
            {
                if (_busC == null) _busC = new BusC();
            }

            return _busC;
        }

        public void execute_op()
        {
            if (Operation[8] == '1') _registers[0].Dato = Dato;

            if (Operation[7] == '1') _registers[1].Dato = Dato;

            if (Operation[6] == '1') _registers[2].Dato = Dato;

            if (Operation[5] == '1') _registers[4].Dato = Dato;

            if (Operation[4] == '1') _registers[5].Dato = Dato;

            if (Operation[3] == '1') _registers[6].Dato = Dato;

            if (Operation[2] == '1') _registers[7].Dato = Dato;

            if (Operation[1] == '1') _registers[8].Dato = Dato;

            if (Operation[0] == '1') _registers[9].Dato = Dato;
            //------------------------
            //switch (Operation)
            //{
            //    case "000000001":
            //        _registers[0].Dato = Dato;
            //        break;
            //    case "000000010":
            //        _registers[1].Dato = Dato;
            //        break;
            //    case "000000100":
            //        _registers[2].Dato = Dato;
            //        break;
            //    case "000001000":
            //        _registers[4].Dato = Dato;
            //        break;
            //    case "000010000":
            //        _registers[5].Dato = Dato;
            //        break;
            //    case "000100000":
            //        _registers[6].Dato = Dato;
            //        break;
            //    case "001000000":
            //        _registers[7].Dato = Dato;
            //        break;
            //    case "010000000":
            //        _registers[8].Dato = Dato;
            //        break;
            //    case "100000000":
            //        _registers[9].Dato = Dato;
            //        break;
            //}
        }
    }
}