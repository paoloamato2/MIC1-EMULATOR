﻿using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class BusDiSistema
    {
        private static readonly object Object = new object();
        private static volatile BusDiSistema _bus;
        private readonly MemoriaCentrale _ram;

        public BusDiSistema()
        {
            _ram = MemoriaCentrale.GetInstance();
        }

        public string Operation { get; set; }

        public static BusDiSistema GetInstance()
        {
            if (_bus != null) return _bus;
            lock (Object)
            {
                if (_bus == null) _bus = new BusDiSistema();
            }

            return _bus;
        }

        public string[] execute_op(string mar, string mdr, string pc)
        {
            var retValueData = "";
            var retValueInstr = "";
            var retValue = new string[2];

            var wrFf = Convert.ToInt32(Operation.Substring(0, 1)); //write bit
            var rdFf = Convert.ToInt32(Operation.Substring(1, 1)); //read bit
            var fetchFf = Convert.ToInt32(Operation.Substring(2, 1)); //fetch bit

            if (wrFf == 1) _ram.write_data(mdr, mar); //scrittura in area dati della memoria centrale

            if (rdFf == 1) retValueData = _ram.read_data(mar); //lettura da area dati della memoria centrale

            if (fetchFf == 1) retValueInstr = _ram.read_instr(pc); //lettura da area istruzioni della memoria centrale

            retValue[0] = retValueData; //dato letto
            retValue[1] = retValueInstr; //istruzione letta

            return retValue;
        }
    }
}