namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BUS_B
    {
        private static readonly object Object = new object();
        private static volatile BUS_B _busB;
        private readonly ALU _alu;

        public BUS_B()
        {
            _alu = ALU.GetInstance();
        }

        public string Dato { get; set; }

        public string Operation { get; set; }

        public static BUS_B GetInstance()
        {
            if (_busB == null)
                lock (Object)
                {
                    if (_busB == null) _busB = new BUS_B();
                }

            return _busB;
        }

        public void SetAlUoperand()
        {
            _alu.OperandB = Dato;
        }
    }
}