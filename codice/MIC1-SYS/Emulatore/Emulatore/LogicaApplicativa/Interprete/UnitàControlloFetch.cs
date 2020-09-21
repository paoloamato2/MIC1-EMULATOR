using System;
using System.Diagnostics;
using System.Threading;
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
            _fs = FacadeStato.GetInstance();
        }

        protected override void ChangeState(UnitàControllo uc, UnitàControlloState newState)
        {
            uc.SetState(newState);
        }

        [Obsolete]
        public override void EseguiCiclo()
        {
            _uc = UnitàControllo.GetInstance();
            DebugInfo();
            _fs.RinnovaStato();

            if (_uc.Termina)
            {
                _uc.Termina = false;
                return;
            }

            if (_uc.Stepbystep)
                Thread.CurrentThread.Suspend(); //il thread corrente viene sospeso per garantire lo step-by-step


            var halt = false;


            if (_uc.ResetFlag)
            {
                ChangeState(_uc, GetInstance("Reset")); //passaggio allo stato di reset
                return;
            }

            if (_uc.ResetDone)
            {
                _uc.ResetDone = false;
                ChangeState(_uc, GetInstance("Execute")); //passaggio allo stato di execute
                return;
            }

            CalcMpc(); //calcolo nuovo MPC

            _uc.Mir = _fs.Fetch(_uc.Mpc); //fetch microistruzione

            if (_uc.Mpc == /*"010100111"*/ "010100111") halt = true;
            if ( /*_uc.Mir== "010101000000001101100100000000000001" ||*/
                /*_uc.Mir == "100000110000000000000000000000001001"*/ halt) _uc.Halt = true;

            ChangeState(_uc, GetInstance("Execute")); //passaggio allo stato di execute
        }

        private void DebugInfo()
        {
            Debug.WriteLine("@@@@@@@@@@@");
            Debug.WriteLine("MIR:" + _uc.Mir);
            Debug.WriteLine("MPC:" + _uc.Mpc);
            Debug.WriteLine("@@@@@@@@@@@");
        }

        private void CalcMpc()
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