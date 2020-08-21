using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class MemoriaCentrale
    {
        static readonly object _object = new object();
        private static volatile MemoriaCentrale RAM;
        private string[] Data;
        private string operation;


        public MemoriaCentrale()
        {
        }

        public static MemoriaCentrale getInstance()
        {
            if (RAM==null)
            {
                lock (_object)
                {
                    if (RAM==null)
                    {
                        RAM = new MemoriaCentrale();
                    }
                }
            }

            return RAM;
        }

        public String read_data(String indirizzo)
        {
            return "";
        }

        public void write_data(String dato, String indirizzo)
        {

        }

        public String read_instr(String indirizzo)
        {
            return "";
        }

        public void execute_op()
        {

        }

        public void caricaProgramma()
        {

        }
    }
}
