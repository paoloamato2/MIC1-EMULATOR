using System;
using System.Diagnostics;
using System.Threading;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControlloHalt : UnitàControlloState
    {
        public static readonly object Object = new object();
        private UnitàControllo _uc;

        protected override void ChangeState(UnitàControllo uc, UnitàControlloState newState)
        {
            uc.SetState(newState);
        }

        [Obsolete]
        public override void EseguiCiclo()
        {
            _uc = UnitàControllo.GetInstance();

            Debug.WriteLine("L'esecuzione è in stato di halt");


            if (_uc.Termina)
                // _uc.Termina = false;
                return;

            if (_uc.Stepbystep) Thread.CurrentThread.Suspend();

           

            if (_uc.ResetFlag)
            {
                ChangeState(_uc, GetInstance("Reset"));
                return;
            }


            ChangeState(_uc, GetInstance("Halt"));
        }
    }
}