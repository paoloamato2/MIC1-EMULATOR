namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class AluStato
    {
        private static readonly object Object = new object();
        private static volatile AluStato _as;
        private readonly ALU _alu;

        public AluStato()
        {
            _alu = ALU.GetInstance();
            Operation = _alu.Operation;
            OperandA = _alu.OperandA;
            OperandB = _alu.OperandB;
            Risultato = _alu.Risultato;
            NFlag = _alu.NFlag;
            ZFlag = _alu.ZFlag;
        }

        public string Operation { get; set; }

        public string OperandA { get; set; }

        public string OperandB { get; set; }

        public string Risultato { get; set; }

        public bool NFlag { get; set; }

        public bool ZFlag { get; set; }

        public static AluStato GetInstance()
        {
            if (_as != null) return _as;
            lock (Object)
            {
                if (_as == null) _as = new AluStato();
            }

            return _as;
        }

        public void AggiornaStato()
        {
            Operation = _alu.Operation;
            OperandA = _alu.OperandA;
            OperandB = _alu.OperandB;
            Risultato = _alu.Risultato;
            NFlag = _alu.NFlag;
            ZFlag = _alu.ZFlag;
        }
    }
}