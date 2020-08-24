namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class Registro
    {
        private static readonly object Object = new object();
        private static volatile Registro[] _registers;
        private readonly ALU _alu;
        private readonly BusB _busB;

        public Registro(string name, string data)
        {
            Nome = name;
            Dato = data;
            _busB = BusB.GetInstance();
            _alu = ALU.GetInstance();
        }

        public string Dato { get; set; }

        public string Nome { get; set; }

        public void SetAlUoperand()
        {
            if (Nome == "H") _alu.OperandA = Dato;
        }

        public void WriteBus()
        {
            _busB.Dato = Dato;
        }

        public static Registro[] GetInstance()
        {
            if (_registers != null) return _registers;
            lock (Object)
            {
                if (_registers != null) return _registers;
                _registers = new Registro[10];
                _registers[0] = new Registro("MAR", "00000000000000000000000000000000");
                _registers[1] = new Registro("MDR", "00000000000000000000000000000000");
                _registers[2] = new Registro("PC", "00000000000000000000000000000000");
                _registers[3] = new Registro("MBR", "00000000000000000000000000000000");
                _registers[4] = new Registro("SP", "00000000000000000000000000000000");
                _registers[5] = new Registro("LV", "00000000000000000000000000000000");
                _registers[6] = new Registro("CPP", "00000000000000000000000000000000");
                _registers[7] = new Registro("TOS", "00000000000000000000000000000000");
                _registers[8] = new Registro("OPC", "00000000000000000000000000000000");
                _registers[9] = new Registro("H", "00000000000000000000000000000000");
            }

            return _registers;
        }
    }
}