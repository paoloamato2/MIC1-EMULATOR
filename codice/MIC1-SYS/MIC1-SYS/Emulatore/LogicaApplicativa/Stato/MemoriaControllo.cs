using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class MemoriaControllo
    {
        static readonly object _object = new object();
        private static volatile MemoriaControllo MC;
        private string[] Data;

        public MemoriaControllo()
        {
        }

        public static MemoriaControllo getInstance()
        {
            if (MC==null)
            {
                lock (_object)
                {
                    if (MC==null)
                    {
                        MC = new MemoriaControllo();
                    }
                }
            }

            return MC;
        }

        public void caricaMicroProgramma()
        {

        }


        public String leggiMicroIstruzione(String indirizzo)
        {
            return "";
        }


    }
}
