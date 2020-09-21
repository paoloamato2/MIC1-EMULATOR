using System.Diagnostics;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    internal class UnitàControlloExecute : UnitàControlloState
    {
        public static readonly object Object = new object();
        private readonly FacadeStato _fs;
        private UnitàControllo _uc;

        protected internal UnitàControlloExecute()
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

            if (_uc.ResetFlag)
            {
                ChangeState(_uc, GetInstance("Reset")); //passaggio allo stato di reset
                return;
            }

            _fs.Execute(_uc.Mir); //esecuzione microistruzione

            if (_uc.Halt)
            {
                ChangeState(_uc, GetInstance("Halt")); //passaggio allo stato di halt
                return;
            }

            ChangeState(_uc, GetInstance("Fetch")); //passaggio allo stato di fetch
        }

        private static void DebugInfo()
        {
            Debug.WriteLine("L'esecuzione è nello stato di execute");
        }
    }
}