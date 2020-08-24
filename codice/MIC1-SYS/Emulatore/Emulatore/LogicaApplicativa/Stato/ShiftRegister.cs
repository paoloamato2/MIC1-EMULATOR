﻿namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class ShiftRegister
    {
        private static readonly object Object = new object();
        private static volatile ShiftRegister _sr;
        private BusC _busC;

        public ShiftRegister()
        {
            _busC = BusC.GetInstance();
        }

        public string Operation { get; set; }

        public string Dato { get; set; }

        public static ShiftRegister GetInstance()
        {
            if (_sr != null) return _sr;
            lock (Object)
            {
                if (_sr == null) _sr = new ShiftRegister();
            }

            return _sr;
        }

        public string SLL8()
        {
            return Dato.Substring(8, 24) + "00000000";
        }

        public string SRA1()
        {
            return Dato[0] + Dato.Substring(0, 31);
        }
        public void execute_op()
        {
            Dato = Operation switch
            {
                "10" => (SLL8()),
                "01" => (SRA1()),
                _ => Dato
            };

            _busC = BusC.GetInstance();
            _busC.Dato = Dato;
        }
    }
}