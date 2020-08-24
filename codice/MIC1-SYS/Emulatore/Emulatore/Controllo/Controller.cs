using MIC1_SYS.Emulatore.LogicaApplicativa;

namespace MIC1_SYS.Emulatore.Controllo
{
    public class Controller
    {
        private readonly FacadeEmulatore _emu;

        public Controller()
        {
            _emu = new FacadeEmulatore();
        }

        public void EseguiProgramma(string nome, int id, string percorso)
        {
            //emu.inizializzaProgramma;
            _emu.AvviaCiclo();
        }

        public void CaricaMicroProgramma(string nome, int id, string percorso)
        {
        }
    }
}