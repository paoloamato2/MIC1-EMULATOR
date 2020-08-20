using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControllo
    {
        private string MPC;
        private string MIR;
        private static volatile UnitàControllo UC = null;
        private UnitàControlloState State;
        static readonly object _object = new object();
        public UnitàControllo()
        {
            MPC = "000000000";
            MIR = "000000000000000000000000000000000000";
            State = UnitàControlloState.getInstance("Reset");

        }

        public static UnitàControllo getInstance()
        {
            if (UC == null)
            {
                lock (_object)
                {
                    if (UC == null)
                    {
                        UC = new UnitàControllo();
                    }
                }
            }

            return UC;
        }

        public void setState(UnitàControlloState nextState)
        {
            State = nextState;
        }

        public void eseguiCiclo()
        {

        }

    }
}
