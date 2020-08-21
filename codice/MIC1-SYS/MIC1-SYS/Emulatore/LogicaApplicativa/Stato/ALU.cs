using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class ALU
    {
        private static readonly object Object = new object();
        private static volatile ALU _alu;
        private ShiftRegister _sr;

        public ALU()
        {
            _sr = ShiftRegister.GetInstance();
        }

        public string Operation { get; set; }

        public bool NFlag { get; private set; }

        public bool ZFlag { get; private set; }

        public string OperandA { get; set; }

        public string OperandB { get; set; }

        public string Risultato { get; private set; }

        public static ALU GetInstance()
        {
            if (_alu == null)
                lock (Object)
                {
                    if (_alu == null) _alu = new ALU();
                }

            return _alu;
        }

        public void execute_op()
        {
            var f0 = Operation[0];
            var f1 = Operation[1];
            var enA = Operation[2];
            var enB = Operation[3];
            var invA = Operation[4];
            var inc = Operation[5];

            string tResult;

            var tOperandA = enA == '1' ? OperandA : "00000000000000000000000000000000";

            var tOperandAInv = invA == '1' ? Utility.ToBin(~Convert.ToInt32(tOperandA, 2), 32) : tOperandA;

            var tOperandB = enB == '1' ? OperandB : "00000000000000000000000000000000";

            var tInc = inc.ToString();

            var tUSum = Convert.ToUInt32(tOperandAInv, 2) + Convert.ToUInt32(tOperandB, 2) +
                          Convert.ToUInt32(tInc, 2);

            char[] chars = {f0, f1};
            var fn = new string(chars);
            switch (fn)
            {
                case "00":
                    tResult = Utility.ToBin(Convert.ToInt32(tOperandAInv, 2) & Convert.ToInt32(tOperandB, 2), 32);
                    break;
                case "01":
                    tResult = Utility.ToBin(Convert.ToInt32(tOperandAInv, 2) | Convert.ToInt32(tOperandB, 2), 32);
                    break;
                case "10":
                    tResult = Utility.ToBin(~Convert.ToInt32(tOperandB, 2), 32);
                    break;
                case "11":
                {
                    var tSum = Convert.ToString(tUSum, 2);
                    tResult = tSum;
                    break;
                }
                default:
                    tResult = "00000000000000000000000000000000";
                    break;
            }


            Risultato = Utility.ToBin(Convert.ToInt32(tResult, 2), 32);

            NFlag = Risultato[0] == '1';
            ZFlag = Risultato == "00000000000000000000000000000000";
        }
    }
}