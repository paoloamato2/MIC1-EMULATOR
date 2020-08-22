using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControlloReset : UnitàControlloState
    {
        public static readonly object _object = new object();
        private readonly FacadeStato FS;
        private UnitàControllo UC;

        protected internal UnitàControlloReset()
        {
            FS = new FacadeStato();
        }

        protected override void changeState(UnitàControllo uc, UnitàControlloState NewState)
        {
            uc.setState(NewState);
        }

        public override void eseguiCiclo()
        {
            UC = UnitàControllo.getInstance();
            UC.Mir = "000000001000000000000000000000001001";
            UC.NFf = 0;
            UC.ZFf = 0;
            FS.Reset();


            changeState(UC, getInstance("Fetch"));
        }
    }
}