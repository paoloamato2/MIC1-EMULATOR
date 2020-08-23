namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class FacadeStato
    {
        private readonly MemoriaControllo _mc;
        private readonly UnitàOperativa _ou;
        private MemoriaCentrale _ram;

        public FacadeStato()
        {
            _ou = UnitàOperativa.GetInstance();
            _mc = MemoriaControllo.GetInstance();
            _ram = MemoriaCentrale.GetInstance();
        }

        public void Reset()
        {
            _ou.Reset();
        }

        public string Fetch(string indirizzo)
        {
            return _mc.LeggiMicroIstruzione(indirizzo);
        }

        public bool Execute(string opcode)
        {
            _ou.Execute(opcode);
            return true;
        }

        public void CaricaProgramma()
        {
        }

        public void CaricaMicroProgramma()
        {
        }


        public string get_MBR()
        {
            return _ou.get_MBR();
        }

        public int[] get_ALUflag()
        {
            return _ou.get_ALUflag();
        }
    }
}