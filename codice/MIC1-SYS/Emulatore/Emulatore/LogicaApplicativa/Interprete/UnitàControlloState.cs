namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public abstract class UnitàControlloState
    {
        private static volatile UnitàControlloReset _ucr;
        private static volatile UnitàControlloFetch _ucf;
        private static volatile UnitàControlloExecute _uce;

        protected abstract void ChangeState(UnitàControllo uc, UnitàControlloState newState);

        public abstract void EseguiCiclo();

        public static UnitàControlloState GetInstance(string statoSelezionato)
        {
            if (statoSelezionato.Equals("Fetch"))
            {
                if (_ucf != null) return _ucf;
                lock (UnitàControlloFetch.Object)
                {
                    if (_ucf == null) _ucf = new UnitàControlloFetch();
                }

                return _ucf;
            }

            if (statoSelezionato.Equals("Execute"))
            {
                if (_uce != null) return _uce;
                lock (UnitàControlloExecute.Object)
                {
                    if (_uce == null) _uce = new UnitàControlloExecute();
                }

                return _uce;
            }

            lock (UnitàControlloReset.Object)
            {
                if (_ucr != null) return _ucr;
                lock (UnitàControlloReset.Object)
                {
                    if (_ucr == null) _ucr = new UnitàControlloReset();
                }

                return _ucr;
            }
        }
    }
}