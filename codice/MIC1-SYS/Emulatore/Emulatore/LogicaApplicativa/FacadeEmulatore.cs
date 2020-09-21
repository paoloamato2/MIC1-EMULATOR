using System.Collections.Generic;
using System.Linq;
using MIC1_SYS.Emulatore.LogicaApplicativa.Interprete;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;
using MIC1_SYS.Emulatore.ServiziTecnici;

namespace MIC1_SYS.Emulatore.LogicaApplicativa
{
    public class FacadeEmulatore
    {
        private static readonly object Object = new object();
        private static volatile FacadeEmulatore _fe;
        private readonly FacadeInterprete _fi;
        private readonly FacadeStato _fs;
        private readonly FacadeServiziTecnici _fst;
        private List<MicroProgramma> _microprogrammi;
        private List<Programma> _programmi;

        private FacadeEmulatore()
        {
            _fi = FacadeInterprete.GetInstance();
            _fs = FacadeStato.GetInstance();
            _fst = FacadeServiziTecnici.GetInstance();
            _programmi = new List<Programma>();
            _microprogrammi = new List<MicroProgramma>();
        }

        public static FacadeEmulatore GetInstance()
        {
            if (_fe != null) return _fe;
            lock (Object)
            {
                if (_fe == null) _fe = new FacadeEmulatore();
            }

            return _fe;
        }

        public bool AvviaCiclo()
        {
            return _fi.AvviaCiclo();
        }


        public void InizializzaProgramma(int id)
        {
            foreach (var prog in _programmi.Where(prog => prog.Id == id))
            {
                _fs.CaricaProgramma(prog.Data);
                break;
            }
        }

        public void InizializzaMicroProgramma(int id)
        {
            foreach (var microprog in _microprogrammi.Where(microprog => microprog.Id == id))
                _fs.CaricaMicroProgramma(microprog.Data);
        }


        public void InserisciProgramma(string nome, int id, string percorso)
        {
            var data = _fst.LeggiContenuto(percorso);
            var prog = new Programma(id, nome, data);
            _programmi.Add(prog);
            _fst.InserisciProgramma(nome, id, data);
        }

        public void AggiornaProgramma(int vecchioId, int nuovoId, string nuovoNome, string percorsoNuovoContenuto)
        {
            var data = _fst.LeggiContenuto(percorsoNuovoContenuto);
            var found = false;
            foreach (var prog in _programmi.Where(prog => prog.Id == vecchioId))
            {
                prog.Id = nuovoId;
                prog.Nome = nuovoNome;
                prog.Data = data;
                found = true;
            }

            if (found
            ) // messo !found solo per testing, aggiornare dopo che si è implementato il caricamento della lista
                _fst.AggiornaProgramma(vecchioId, nuovoId, nuovoNome, data);
        }


        public void EliminaProgramma(int id)
        {
            var found = false;
            foreach (var prog in _programmi.Where(prog => prog.Id == id))
            {
                _programmi.Remove(prog);
                found = true;
                break;
            }

            if (found
            ) // messo !found solo per testing, aggiornare dopo che si è implementato il caricamento della lista
                _fst.EliminaProgramma(id);
        }

        public void CaricaProgrammi()
        {
            var returnedData = _fst.LeggiProgrammi();
            _programmi = new List<Programma>();
            foreach (var prog in from progText in returnedData
                let nome = progText[0]
                let id = int.Parse(progText[1])
                let codice = progText[2].Split('\n')
                select new Programma(id, nome, codice)) _programmi.Add(prog);

            //test
            // foreach (var prog in _programmi)
            //   Debug.WriteLine(prog.Nome + " " + prog.Id + " " + "\n" + string.Join("\n", prog.Data));
        }

        public List<Programma> get_ListaProgrammi()
        {
            return _programmi;
        }

        internal void InserisciMicroProgramma(string nome, int id, string percorso)
        {
            var data = _fst.LeggiContenuto(percorso);
            var microprog = new MicroProgramma(id, nome, data);
            _microprogrammi.Add(microprog);
            _fst.InserisciMicroProgramma(nome, id, data);
        }

        public void AggiornaMicroProgramma(int vecchioId, int nuovoId, string nuovoNome, string percorsoNuovoContenuto)
        {
            var data = _fst.LeggiContenuto(percorsoNuovoContenuto);
            var found = false;
            foreach (var microprog in _microprogrammi.Where(microprog => microprog.Id == vecchioId))
            {
                microprog.Id = nuovoId;
                microprog.Nome = nuovoNome;
                microprog.Data = data;
                found = true;
            }

            if (found
            ) // messo !found solo per testing, aggiornare dopo che si è implementato il caricamento della lista
                _fst.AggiornaMicroProgramma(vecchioId, nuovoId, nuovoNome, data);
        }


        public void EliminaMicroProgramma(int id)
        {
            var found = false;
            foreach (var microprog in _microprogrammi.Where(microprog => microprog.Id == id))
            {
                _microprogrammi.Remove(microprog);
                found = true;
                break;
            }

            if (found
            ) // messo !found solo per testing, aggiornare dopo che si è implementato il caricamento della lista
                _fst.EliminaMicroProgramma(id);
        }

        public void CaricaMicroProgrammi()
        {
            var returnedData = _fst.LeggiMicroProgrammi();
            _microprogrammi = new List<MicroProgramma>();
            foreach (var prog in from prog_text in returnedData
                let nome = prog_text[0]
                let id = int.Parse(prog_text[1])
                let codice = prog_text[2].Split('\n')
                select new MicroProgramma(id, nome, codice)) _microprogrammi.Add(prog);

            //test
            //  foreach (var microprog in _microprogrammi)
            //    Debug.WriteLine(microprog.Nome + " " + microprog.Id + " " + "\n" + string.Join("\n", microprog.Data));
        }

        public List<MicroProgramma> get_ListaMicroProgrammi()
        {
            return _microprogrammi;
        }


        public Stato.Stato get_Stato()
        {
            return _fs.get_Stato();
        }

        public void ClearStatoAggiornato()
        {
            _fs.ClearStatoAggiornato();
        }

        public void SetStepByStep(bool p0)
        {
            _fi.SetStepByStep(p0);
        }

        public void Reset()
        {
            _fi.Reset();
        }
    }
}