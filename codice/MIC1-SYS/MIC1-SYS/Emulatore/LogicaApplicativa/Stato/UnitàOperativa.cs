using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class UnitàOperativa
    {
        static readonly object _object = new object();
        private static volatile UnitàOperativa UO;
        private ShiftRegister SR;
        private ALU alu;
        private BUS_C busC;
        private BUS_B busB;
        private Registro[] registers;

        public UnitàOperativa()
        {

        }

        public static UnitàOperativa getInstance()
        {
            if (UO==null)
            {
                lock (_object)
                {
                    if (UO==null)
                    {
                        UO = new UnitàOperativa();
                    }
                }
            }

            return UO;
        }

        public void reset()
        {

        }

        public void fetch()
        {

        }

        public void execute(String Opcode)
        {

        }
    }
}
