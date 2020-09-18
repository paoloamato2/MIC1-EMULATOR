using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusB
    {
        private static readonly object Object = new object();
        private static volatile BusB _busB;
        private ALU _alu;
        private Registro[] _registers;

        public BusB()
        {
            Dato = "00000000000000000000000000000000";
            Operation = "0000";
        }

        public string Dato { get; set; }

        public string Operation { get; set; }

        public static BusB GetInstance()
        {
            if (_busB != null) return _busB;
            lock (Object)
            {
                if (_busB == null) _busB = new BusB();
            }

            return _busB;
        }

        public void SetAlUoperand()
        {
            _alu = ALU.GetInstance();
            _alu.OperandB = Dato;
        }

        public void execute_op()
        {
            _registers = Registro.GetInstance();

            var regToBDecoderOut = "000000000";
            var index = Convert.ToUInt32(Operation, 2);
            var tmp1 = index;
            index = 8 - index;


            if (tmp1 < 9)
            {
                var temp = regToBDecoderOut.ToCharArray();
                temp[index] = '1';
                regToBDecoderOut = new string(temp);
            }


            switch (regToBDecoderOut)
            {
                case "000000001":
                    _registers[1].WriteBus(); //MDR scrive nel bus B
                    break;
                case "000000010":
                    _registers[2].WriteBus(); //PC scrive nel bus B
                    break;
                case "000000100": //MBRU scrive nel bus B
                {
                    var tmp = _registers[3].Dato;
                    ElabMbr(tmp);
                    _registers[3].WriteBus();
                    _registers[3].Dato = tmp;
                    break;
                }
                case "000001000": //MBR scrive nel bus B
                {
                    var tmp = _registers[3].Dato;
                    _registers[3].Dato = "000000000000000000000000" + _registers[3].Dato.Substring(24, 8);
                    _registers[3].WriteBus();
                    _registers[3].Dato = tmp;
                    break;
                }
                case "000010000": //SP scrive nel bus B
                    _registers[4].WriteBus();
                    break;
                case "000100000": //LV scrive nel bus B
                    _registers[5].WriteBus();
                    break;
                case "001000000": //CPP scrive nel bus B
                    _registers[6].WriteBus();
                    break;
                case "010000000": //TOS scrive nel bus B
                    _registers[7].WriteBus();
                    break;
                case "100000000": //OPC scrive nel bus B
                    _registers[8].WriteBus();
                    break;
                default:
                    Dato = "00000000000000000000000000000000";
                    break;
            }
        }

        private void ElabMbr(string tmp) //complemento a due
        {
            if (tmp[24] == '1')
                _registers[3].Dato = "111111111111111111111111" + _registers[3].Dato.Substring(24, 8);
            else
                _registers[3].Dato = "000000000000000000000000" + _registers[3].Dato.Substring(24, 8);
        }
    }
}