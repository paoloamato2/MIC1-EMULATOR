using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusDiSistema
    {
        static readonly object _object = new object();
        private static volatile BusDiSistema BUS;
        private string operation;
        private MemoriaCentrale RAM;
        public BusDiSistema()
        {
            RAM = MemoriaCentrale.getInstance();
        }

        public BusDiSistema getInstance()
        {
            if (BUS==null)
            {
                lock (_object)
                {

                    if (BUS==null)
                    {
                        BUS = new BusDiSistema();
                    }

                }
            }

            return BUS;
        }

        public void execute_op()
        {

        }
    }
}
