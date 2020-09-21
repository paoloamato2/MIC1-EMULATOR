using System.Diagnostics;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControlloReset : UnitàControlloState
    {
        public static readonly object Object = new object();
        private readonly FacadeStato _fs;
        private UnitàControllo _uc;

        protected internal UnitàControlloReset()
        {
            _fs = FacadeStato.GetInstance();
        }

        protected override void ChangeState(UnitàControllo uc, UnitàControlloState newState)
        {
            uc.SetState(newState);
        }

        public override void EseguiCiclo()
        {
            DebugInfo();
            _uc = UnitàControllo.GetInstance();
            _uc.Mir = "000000001000000000000000000000001001"; //reset MIR
            _uc.NFf = 0; //reset negative flag
            _uc.ZFf = 0; //reset zero flag
            _uc.ResetDone = true;
            _uc.ResetFlag = false;
            _uc.Halt = false;
            _uc.Termina = false;
            _fs.Reset(); //reset unità operativa


            ChangeState(_uc, GetInstance("Fetch")); //passaggio allo stato di fetch
        }

        private static void DebugInfo()
        {
            Debug.WriteLine("L'esecuzione è nello stato di reset");
        }
    }
}