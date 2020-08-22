using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class FacadeStato
    {
        private readonly MemoriaControllo MC;
        private readonly UnitàOperativa OU;
        private MemoriaCentrale RAM;

        public FacadeStato()
        {
            OU = UnitàOperativa.getInstance();
            MC = MemoriaControllo.getInstance();
            RAM = MemoriaCentrale.GetInstance();
        }

        public void Reset()
        {
            OU.reset();
        }

        public string Fetch(string indirizzo)
        {
            return MC.leggiMicroIstruzione(indirizzo);
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


        public string get_MBR()
        {
            return OU.get_MBR();
        }

        public int[] get_ALUflag()
        {
            return OU.get_ALUflag();
        }
    }
}