using System.Collections.Generic;
using MIC1_SYS.Emulatore.LogicaApplicativa;

namespace MIC1_SYS.Emulatore.Controllo
{
    public class Controller
    {
        private readonly FacadeEmulatore _emu;
        private readonly StatoOttenuto _stato;
        private List<MicroProgrammaOttenuto> _microprogrammiottenuti;
        private List<ProgrammaOttenuto> _programmiottenuti;

        public Controller()
        {
            _emu = FacadeEmulatore.GetInstance();
            _programmiottenuti = new List<ProgrammaOttenuto>();
            _microprogrammiottenuti = new List<MicroProgrammaOttenuto>();
            _stato = StatoOttenuto.GetInstance();
        }

        public void EseguiProgramma(int id)
        {
            _emu.InizializzaProgramma(id);
            _emu.AvviaCiclo();
        }

        public void CaricaMicroProgramma(int id)
        {
            _emu.InizializzaMicroProgramma(id);
        }

        public void InserisciProgramma(string nome, int id, string percorso)
        {
            _emu.InserisciProgramma(nome, id, percorso);
        }

        public void AggiornaProgramma(int vecchioId, int nuovoId, string nuovoNome, string percorsoNuovoContenuto)
        {
            _emu.AggiornaProgramma(vecchioId, nuovoId, nuovoNome, percorsoNuovoContenuto);
        }

        public void EliminaProgramma(int id)
        {
            _emu.EliminaProgramma(id);
        }

        public void CaricaListaProgrammi()
        {
            _emu.CaricaProgrammi();
        }

        public List<ProgrammaOttenuto> get_ListaProgrammi()
        {
            _emu.CaricaProgrammi();
            var programs = _emu.get_ListaProgrammi();
            _programmiottenuti = new List<ProgrammaOttenuto>();

            foreach (var prog in programs) _programmiottenuti.Add(new ProgrammaOttenuto(prog.Id, prog.Nome));

            return _programmiottenuti;
        }

        public void InserisciMicroProgramma(string nome, int id, string percorso)
        {
            _emu.InserisciMicroProgramma(nome, id, percorso);
        }

        public void AggiornaMicroProgramma(int vecchioId, int nuovoId, string nuovoNome, string percorsoNuovoContenuto)
        {
            _emu.AggiornaMicroProgramma(vecchioId, nuovoId, nuovoNome, percorsoNuovoContenuto);
        }

        public void EliminaMicroProgramma(int id)
        {
            _emu.EliminaMicroProgramma(id);
        }

        public void CaricaListaMicroProgrammi()
        {
            _emu.CaricaMicroProgrammi();
        }

        public List<MicroProgrammaOttenuto> get_ListaMicroProgrammi()
        {
            _emu.CaricaMicroProgrammi();
            var microprograms = _emu.get_ListaMicroProgrammi();
            _microprogrammiottenuti = new List<MicroProgrammaOttenuto>();

            foreach (var microprog in microprograms)
                _microprogrammiottenuti.Add(new MicroProgrammaOttenuto(microprog.Id, microprog.Nome));

            return _microprogrammiottenuti;
        }

        public StatoOttenuto get_StatoOttenuto()
        {
            return _stato;
        }

        public bool OttieniStato()
        {
            var cond = _emu.get_Stato().StatoAggiornato;

            if (cond)
            {
                _stato.set_MCSO(_emu.get_Stato().Cms);
                _stato.set_RAMSO(_emu.get_Stato().Mcs);
                _stato.set_UOSO(_emu.get_Stato().Uos);
                ClearStatoAggiornato();
            }


            return cond;
        }

        private void ClearStatoAggiornato()
        {
            _emu.ClearStatoAggiornato();
        }

        public void SetStepByStep(bool p0)
        {
            _emu.SetStepByStep(p0);
        }

        public void Reset()
        {
            _emu.Reset();
        }
    }
}