namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class RegistriStato
    {
        private static readonly object Object = new object();
        private static volatile RegistriStato _rs;
        private readonly Registro[] _registers;

        public RegistriStato()
        {
            _registers = Registro.GetInstance();
            Mar = _registers[0].Dato;
            Mdr = _registers[1].Dato;
            Pc = _registers[2].Dato;
            Mbr = _registers[3].Dato;
            Sp = _registers[4].Dato;
            Lv = _registers[5].Dato;
            Cpp = _registers[6].Dato;
            Tos = _registers[7].Dato;
            Opc = _registers[8].Dato;
            H = _registers[9].Dato;
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

        public static RegistriStato GetInstance()
        {
            if (_rs != null) return _rs;
            lock (Object)
            {
                if (_rs == null) _rs = new RegistriStato();
            }

            return _rs;
        }

        public void AggiornaStato()
        {
            Mar = _registers[0].Dato;
            Mdr = _registers[1].Dato;
            Pc = _registers[2].Dato;
            Mbr = _registers[3].Dato;
            Sp = _registers[4].Dato;
            Lv = _registers[5].Dato;
            Cpp = _registers[6].Dato;
            Tos = _registers[7].Dato;
            Opc = _registers[8].Dato;
            H = _registers[9].Dato;
        }
    }
}