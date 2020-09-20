using MIC1_SYS.Emulatore.LogicaApplicativa.Stato;

namespace MIC1_SYS.Emulatore.Controllo
{
    public class StatoOttenuto
    {
        private static readonly object Object = new object();
        private static volatile StatoOttenuto _stato;

        public StatoOttenuto()
        {
            StatoAggiornato = false;
            Uoso = UnitàOperativaStatoOttenuto.GetInstance();
            Mcso = MemoriaControlloStatoOttenuto.GetInstance();
            Ramso = MemoriaCentraleStatoOttenuto.GetInstance();
        }

        public bool StatoAggiornato { get; set; }

        public UnitàOperativaStatoOttenuto Uoso { get; set; }

        public MemoriaControlloStatoOttenuto Mcso { get; set; }

        public MemoriaCentraleStatoOttenuto Ramso { get; set; }

        public static StatoOttenuto GetInstance()
        {
            if (_stato != null) return _stato;
            lock (Object)
            {
                if (_stato == null) _stato = new StatoOttenuto();
            }

            return _stato;
        }

        public void set_MCSO(MemoriaControlloStato mcs)
        {
            Mcso.Data = mcs.Data;
        }

        public void set_RAMSO(MemoriaCentraleStato mcs)
        {
            Ramso.Data = mcs.Data;
        }

        public void set_UOSO(UnitàOperativaStato uos)
        {
            Uoso.Operation = uos.Operation;

            Uoso.Aso.Operation = uos.As.Operation;
            Uoso.Aso.NFlag = uos.As.NFlag;
            Uoso.Aso.ZFlag = uos.As.ZFlag;
            Uoso.Aso.OperandA = uos.As.OperandA;
            Uoso.Aso.OperandB = uos.As.OperandB;
            Uoso.Aso.Risultato = uos.As.Risultato;

            Uoso.Bbso.Operation = uos.Bbs.Operation;
            Uoso.Bbso.Dato = uos.Bbs.Dato;

            Uoso.Bcso.Operation = uos.Bcs.Operation;
            Uoso.Bcso.Dato = uos.Bcs.Dato;

            Uoso.Rso.Cpp = uos.Rs.Cpp;
            Uoso.Rso.H = uos.Rs.H;
            Uoso.Rso.Lv = uos.Rs.Lv;
            Uoso.Rso.Mar = uos.Rs.Mar;
            Uoso.Rso.Mbr = uos.Rs.Mbr;
            Uoso.Rso.Mdr = uos.Rs.Mdr;
            Uoso.Rso.Opc = uos.Rs.Opc;
            Uoso.Rso.Pc = uos.Rs.Pc;
            Uoso.Rso.Sp = uos.Rs.Sp;
            Uoso.Rso.Tos = uos.Rs.Tos;

            Uoso.Srso.Operation = uos.Srs.Operation;
            Uoso.Srso.Dato = uos.Srs.Dato;
        }
    }
}