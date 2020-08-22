using System;
using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControlloFetch : UnitàControlloState
    {
        public static readonly object _object = new object();
        private readonly FacadeStato FS;
        private UnitàControllo UC;

        protected internal UnitàControlloFetch()
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

            var ctrl_nxt_addr_no_msb = UC.Mir.Substring(1, 8);
            var mbr_reg_in = FS.get_MBR().Substring(24, 8);
            string jmpc_addr;
            if (UC.Mir[9] == '1')
                jmpc_addr = Utility.ToBin(Convert.ToInt32(ctrl_nxt_addr_no_msb, 2) | Convert.ToInt32(mbr_reg_in, 2), 8);
            else
                jmpc_addr = ctrl_nxt_addr_no_msb;

            var alu_flag = FS.get_ALUflag();

            var n_flag = alu_flag[0];
            var z_flag = alu_flag[1];
            var jam_n = Convert.ToInt32(UC.Mir[10].ToString(), 2);
            var jam_z = Convert.ToInt32(UC.Mir[11].ToString(), 2);

            var high_bit = (n_flag & jam_n) | (z_flag & jam_z);
            high_bit |= Convert.ToInt32(UC.Mpc[0].ToString(), 2);

            UC.Mpc = high_bit + jmpc_addr;

            UC.Mir = FS.Fetch(UC.Mpc);
            changeState(UC, getInstance("Execute"));
        }
    }
}