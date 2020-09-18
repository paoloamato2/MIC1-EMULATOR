using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class ALU
    {
        private static readonly object Object = new object();
        private static volatile ALU _alu;
        private ShiftRegister _sr;

        public ALU()
        {
            Operation = "000000";
            OperandA = "00000000000000000000000000000000";
            OperandB = "00000000000000000000000000000000";
            NFlag = false;
            ZFlag = false;
            Risultato = "00000000000000000000000000000000";
        }

        public string Operation { get; set; }

        public bool NFlag { get; private set; }

        public bool ZFlag { get; private set; }

        public string OperandA { get; set; }

        public string OperandB { get; set; }

        public string Risultato { get; private set; }

        public static ALU GetInstance()
        {
            if (_alu != null) return _alu;
            lock (Object)
            {
                if (_alu == null) _alu = new ALU();
            }

            return _alu;
        }

        public void execute_op()
        {
            _sr = ShiftRegister.GetInstance();
            // f0 e f1 stabiliscono l'operazione che l'ALU deve eseguire
            var f0 = Operation[0];
            var f1 = Operation[1];
            // enA e enB abilitano rispettivamente i due ingressi A e B dell'ALU
            var enA = Operation[2];
            var enB = Operation[3];
            // invA inverte l'operando A se  abilitato
            var invA = Operation[4];
            // inc effettua un incremento unitario se abilitato
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
                case "00": //AND 
                    tResult = Utility.ToBin(Convert.ToInt32(tOperandAInv, 2) & Convert.ToInt32(tOperandB, 2), 32);
                    break;
                case "01": //OR
                    tResult = Utility.ToBin(Convert.ToInt32(tOperandAInv, 2) | Convert.ToInt32(tOperandB, 2), 32);
                    break;
                case "10": 
                    tResult = Utility.ToBin(~Convert.ToInt32(tOperandB, 2), 32);
                    break;
                case "11": //SOMMA ALGEBRICA
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

            _sr.Dato = Risultato; //scrittura risultato nel registro a scorrimento

            NFlag = Risultato[0] == '1'; //aggiornamento negative flag
            ZFlag = Risultato == "00000000000000000000000000000000"; //aggiornamento zero flag

            DebugInfo();
        }

        private void DebugInfo()
        {
            Debug.WriteLine("-----------");
            Debug.WriteLine("Operazione ALU: " + Operation);
            Debug.WriteLine("Operando A: " + OperandA);
            Debug.WriteLine("Operando B " + OperandB);
            Debug.WriteLine("Risultato: " + Risultato);
            Debug.WriteLine("Negative Flag: " + NFlag);
            Debug.WriteLine("Zero flag:  " + ZFlag);
            Debug.WriteLine("-----------");
        }
    }
}