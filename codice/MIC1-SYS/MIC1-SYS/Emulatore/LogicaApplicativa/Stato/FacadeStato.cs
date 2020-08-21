using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class FacadeStato
    {
        private UnitàOperativa OU;
        private MemoriaControllo MC;
        private MemoriaCentrale RAM;

        public FacadeStato()
        {
            OU = UnitàOperativa.getInstance();
            MC = MemoriaControllo.getInstance();
            RAM = MemoriaCentrale.getInstance();
        }

        public void Reset()
        {

        }

        public string Fetch()
        {
            throw new InvalidOperationException();
        }

        public bool Execute(string Opcode)
        {
            throw new InvalidOperationException();
        }

        public void CaricaProgramma()
        {

        }

        public void CaricaMicroProgramma()
        {

        }
    }
    
}
