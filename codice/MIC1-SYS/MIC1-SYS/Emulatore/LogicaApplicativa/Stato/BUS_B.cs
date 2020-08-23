using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusB
    {
        private static readonly object Object = new object();
        private static volatile BusB _busB;
        private ALU _alu;
        private Registro[] _registers;

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
                    _registers[1].WriteBus();
                    break;
                case "000000010":
                    _registers[2].WriteBus();
                    break;
                case "000000100":
                {
                    var tmp = _registers[3].Dato;
                    if (tmp[24] == '1')
                        _registers[3].Dato = "111111111111111111111111" + _registers[3].Dato.Substring(24, 8);
                    else
                        _registers[3].Dato = "000000000000000000000000" + _registers[3].Dato.Substring(24, 8);
                    _registers[3].WriteBus();
                    _registers[3].Dato = tmp;
                    break;
                }
                case "000001000":
                {
                    var tmp = _registers[3].Dato;
                    _registers[3].Dato = "000000000000000000000000" + _registers[3].Dato.Substring(24, 8);
                    _registers[3].WriteBus();
                    _registers[3].Dato = tmp;
                    break;
                }
                case "000010000":
                    _registers[4].WriteBus();
                    break;
                case "000100000":
                    _registers[5].WriteBus();
                    break;
                case "001000000":
                    _registers[6].WriteBus();
                    break;
                case "010000000":
                    _registers[7].WriteBus();
                    break;
                case "100000000":
                    _registers[8].WriteBus();
                    break;
                default:
                    Dato = "00000000000000000000000000000000";
                    break;
            }
        }
    }
}