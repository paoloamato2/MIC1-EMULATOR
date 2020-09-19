using System.Collections.Generic;
using MIC1_SYS.Emulatore.ServiziTecnici.FileSystem;

namespace MIC1_SYS.Emulatore.ServiziTecnici
{
    public class AccessoFileSystem : Accesso
    {
        private GestoreFileSystem _gfs;

        public override string[] LeggiContenuto(string percorso)
        {
            _gfs = GestoreFileSystem.GetInstance();
            return _gfs.LeggiContenuto(percorso);
        }

        public override void InserisciProgramma(string nome, int id, string[] data)
        {
            _gfs = GestoreFileSystem.GetInstance();
            _gfs.ScriviProgramma(nome, id, data);
        }

        public override void AggiornaProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data)
        {
            _gfs = GestoreFileSystem.GetInstance();
            _gfs.RiscriviProgramma(vecchioId, nuovoId, nuovoNome, data);
        }

        public override void EliminaProgramma(int id)
        {
            _gfs = GestoreFileSystem.GetInstance();
            _gfs.RimuoviProgramma(id);
        }

        public override List<string[]> LeggiProgrammi()
        {
            _gfs = GestoreFileSystem.GetInstance();
            return _gfs.PrelevaProgrammi();
        }

        public override void InserisciMicroProgramma(string nome, int id, string[] data)
        {
            _gfs = GestoreFileSystem.GetInstance();
            _gfs.ScriviMicroProgramma(nome, id, data);
        }

        public override void AggiornaMicroProgramma(int vecchioId, int nuovoId, string nuovoNome, string[] data)
        {
            _gfs = GestoreFileSystem.GetInstance();
            _gfs.RiscriviMicroProgramma(vecchioId, nuovoId, nuovoNome, data);
        }

        public override void EliminaMicroProgramma(int id)
        {
            _gfs = GestoreFileSystem.GetInstance();
            _gfs.RimuoviMicroProgramma(id);
        }

        public override List<string[]> LeggiMicroProgrammi()
        {
            _gfs = GestoreFileSystem.GetInstance();
            return _gfs.PrelevaMicroProgrammi();
        }
    }
}