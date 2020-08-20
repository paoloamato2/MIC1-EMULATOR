using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Interprete
{
    public class UnitàControlloFetch : UnitàControlloState
    {
        public static readonly object _object = new object();
        private UnitàControllo UC;
        protected override void changeState(UnitàControllo UC, UnitàControlloState NewState)
        {
            throw new NotImplementedException();
        }

        public override void eseguiCiclo()
        {
            throw new NotImplementedException();
        }
    }
}
