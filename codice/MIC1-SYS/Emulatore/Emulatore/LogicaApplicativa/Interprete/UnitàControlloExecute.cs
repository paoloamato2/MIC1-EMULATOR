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
            _fs = new FacadeStato();
        }

        protected override void ChangeState(UnitàControllo uc, UnitàControlloState newState)
        {
            uc.SetState(newState);
        }

        public override void EseguiCiclo()
        {

            _uc = UnitàControllo.GetInstance();

            if (_uc.ResetFlag)
            {
                ChangeState(_uc, GetInstance("Reset"));
                return;
            }

            _fs.Execute(_uc.Mir);
            ChangeState(_uc, GetInstance("Fetch"));
        }
    }
}