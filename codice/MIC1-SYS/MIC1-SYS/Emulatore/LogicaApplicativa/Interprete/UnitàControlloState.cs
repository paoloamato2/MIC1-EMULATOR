using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public abstract class UnitàControlloState
    {
        private static volatile UnitàControlloReset UCR = null;
        private static volatile UnitàControlloFetch UCF = null;
        private static volatile UnitàControlloExecute UCE = null;

        protected abstract void changeState(UnitàControllo UC, UnitàControlloState NewState);

        public abstract void eseguiCiclo();

        public static UnitàControlloState getInstance(String StatoSelezionato)
        {
            if (StatoSelezionato.Equals("Fetch"))
            {
                if (UCF == null)
                {
                    lock (UnitàControlloFetch._object)
                    {
                        if (UCF == null)
                        {
                            UCF = new UnitàControlloFetch();
                        }
                    }
                }

                return UCF;

            }
            else if (StatoSelezionato.Equals("Execute"))
            {
                if (UCE == null)
                {
                    lock (UnitàControlloExecute._object)
                    {
                        if (UCE == null)
                        {
                            UCE = new UnitàControlloExecute();
                        }
                    }
                }

                return UCE;
            }
            else
            {
                lock (UnitàControlloReset._object)
                {
                    if (UCR == null)
                    {
                        lock (UnitàControlloReset._object)
                        {
                            if (UCR == null)
                            {
                                UCR = new UnitàControlloReset();
                            }
                        }
                    }

                    return UCR;
                }
            }
        }
    }
}
