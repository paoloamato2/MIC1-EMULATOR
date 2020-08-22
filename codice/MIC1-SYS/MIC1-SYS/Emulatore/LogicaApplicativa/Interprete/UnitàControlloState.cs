namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public abstract class UnitàControlloState
    {
        private static volatile UnitàControlloReset UCR;
        private static volatile UnitàControlloFetch UCF;
        private static volatile UnitàControlloExecute UCE;

        protected abstract void changeState(UnitàControllo UC, UnitàControlloState NewState);

        public abstract void eseguiCiclo();

        public static UnitàControlloState getInstance(string StatoSelezionato)
        {
            if (StatoSelezionato.Equals("Fetch"))
            {
                if (UCF != null) return UCF;
                lock (UnitàControlloFetch._object)
                {
                    if (UCF == null) UCF = new UnitàControlloFetch();
                }

                return UCF;
            }

            if (StatoSelezionato.Equals("Execute"))
            {
                if (UCE != null) return UCE;
                lock (UnitàControlloExecute._object)
                {
                    if (UCE == null) UCE = new UnitàControlloExecute();
                }

                return UCE;
            }

            lock (UnitàControlloReset._object)
            {
                if (UCR != null) return UCR;
                lock (UnitàControlloReset._object)
                {
                    if (UCR == null) UCR = new UnitàControlloReset();
                }

                return UCR;
            }
        }
    }
}