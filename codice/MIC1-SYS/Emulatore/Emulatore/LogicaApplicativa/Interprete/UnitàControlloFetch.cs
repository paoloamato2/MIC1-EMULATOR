using System;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControlloFetch : UnitàControlloState
    {
        public static readonly object Object = new object();
        private readonly FacadeStato _fs;
        private UnitàControllo _uc;

        protected internal UnitàControlloFetch()
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

            if (_uc.ResetDone)
            {
                _uc.ResetDone = false;
                ChangeState(_uc, GetInstance("Execute"));
                return;
            }

            calcMPC();

            _uc.Mir = _fs.Fetch(_uc.Mpc);
            ChangeState(_uc, GetInstance("Execute"));
        }

        private void calcMPC()
        {
            var ctrlNxtAddrNoMsb = _uc.Mir.Substring(1, 8);
            var mbrRegIn = _fs.get_MBR().Substring(24, 8);
            var jmpcAddr = _uc.Mir[9] == '1'
                ? Utility.ToBin(Convert.ToInt32(ctrlNxtAddrNoMsb, 2) | Convert.ToInt32(mbrRegIn, 2), 8)
                : ctrlNxtAddrNoMsb;

            var aluFlag = _fs.get_ALUflag();

            var nFlag = aluFlag[0];
            var zFlag = aluFlag[1];
            var jamN = Convert.ToInt32(_uc.Mir[10].ToString(), 2);
            var jamZ = Convert.ToInt32(_uc.Mir[11].ToString(), 2);

            var highBit = (nFlag & jamN) | (zFlag & jamZ);
            highBit |= Convert.ToInt32(_uc.Mpc[0].ToString(), 2);

            _uc.Mpc = highBit + jmpcAddr;
        }
    }
}