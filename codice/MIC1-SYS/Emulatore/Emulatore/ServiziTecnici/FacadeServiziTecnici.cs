using System.Collections.Generic;

namespace MIC1_SYS.Emulatore.ServiziTecnici
{
    public class FacadeServiziTecnici
    {
        private static readonly object Object = new object();
        private static volatile FacadeServiziTecnici _fst;
        private readonly Accesso _accesso;

        private FacadeServiziTecnici()
        {
            _accesso = new AccessoFileSystem();
        }

        public static FacadeServiziTecnici GetInstance()
        {
            if (_fst != null) return _fst;
            lock (Object)
            {
                if (_fst == null) _fst = new FacadeServiziTecnici();
            }

            return _fst;
        }

        public string[] LeggiContenuto(string percorso)
        {
            return _accesso.LeggiContenuto(percorso);
        }

        public void InserisciProgramma(string nome, int id, string[] data)
        {
            _accesso.InserisciProgramma(nome, id, data);
        }

        public void AggiornaProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data)
        {
            _accesso.AggiornaProgramma(vecchioId, nuovoId, nuovoNome, data);
        }

        public void EliminaProgramma(int id)
        {
            _accesso.EliminaProgramma(id);
        }

        public List<string[]> LeggiProgrammi()
        {
            return _accesso.LeggiProgrammi();
        }

        public void InserisciMicroProgramma(string nome, int id, string[] data)
        {
            _accesso.InserisciMicroProgramma(nome, id, data);
        }

        public void AggiornaMicroProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data)
        {
            _accesso.AggiornaMicroProgramma(vecchioId, nuovoId, nuovoNome, data);
        }

        public void EliminaMicroProgramma(int id)
        {
            _accesso.EliminaMicroProgramma(id);
        }

        public List<string[]> LeggiMicroProgrammi()
        {
            return _accesso.LeggiMicroProgrammi();
        }
    }
}