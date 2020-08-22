using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    internal class UnitàControlloExecute : UnitàControlloState
    {
        public static readonly object _object = new object();
        private UnitàControllo UC;

        protected override void changeState(UnitàControllo uc, UnitàControlloState NewState)
        {
            uc.setState(NewState);
        }

        public override void eseguiCiclo()
        {
            throw new NotImplementedException();
        }
    }
}