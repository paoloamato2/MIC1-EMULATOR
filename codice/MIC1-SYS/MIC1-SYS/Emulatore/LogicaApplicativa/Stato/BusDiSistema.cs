namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusDiSistema
    {
        private static readonly object _object = new object();
        private static volatile BusDiSistema BUS;
        private string operation;
        private MemoriaCentrale RAM;

        public BusDiSistema()
        {
            RAM = MemoriaCentrale.GetInstance();
        }

        public BusDiSistema getInstance()
        {
            if (BUS != null) return BUS;
            lock (_object)
            {
                if (BUS == null) BUS = new BusDiSistema();
            }

            return BUS;
        }

        public void execute_op()
        {

        }
    }
}