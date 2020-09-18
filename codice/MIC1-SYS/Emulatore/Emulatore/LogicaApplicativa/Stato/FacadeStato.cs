namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class FacadeStato
    {
        private static readonly object Object = new object();
        private static volatile FacadeStato _fs;
        private readonly MemoriaControllo _mc;
        private readonly UnitàOperativa _ou;
        private readonly MemoriaCentrale _ram;
        private readonly Stato _stato;

        private FacadeStato()
        {
            _ou = UnitàOperativa.GetInstance();
            _mc = MemoriaControllo.GetInstance();
            _ram = MemoriaCentrale.GetInstance();
            _stato = Stato.GetInstance();
        }

        public static FacadeStato GetInstance()
        {
            if (_fs != null) return _fs;
            lock (Object)
            {
                if (_fs == null) _fs = new FacadeStato();
            }

            return _fs;
        }

        public void Reset()
        {
            //_stato.StatoAggiornato = false;
            _ou.Reset();
        }

        public string Fetch(string indirizzo)
        {
           // _stato.StatoAggiornato = false;
            return _mc.LeggiMicroIstruzione(indirizzo);
        }

        public bool Execute(string opcode)
        {
            //_stato.StatoAggiornato = false;
            _ou.Execute(opcode);
            return true;
        }

        public void CaricaProgramma(string[] data)
        {
            //_stato.StatoAggiornato = false;
            _ram.CaricaProgramma(data);
        }

        public void CaricaMicroProgramma(string[] data)
        {
           // _stato.StatoAggiornato = false;
            _mc.CaricaMicroProgramma(data);
        }

        public Stato get_Stato()
        {
            return _stato;
        }

        public void RinnovaStato()
        {
            _stato.AggiornaStato();
        }


        public string get_MBR()
        {
            return _ou.get_MBR();
        }

        public int[] get_ALUflag()
        {
            return _ou.get_ALUflag();
        }

        public void ClearStatoAggiornato()
        {
            _stato.StatoAggiornato = false;
        }
    }
}