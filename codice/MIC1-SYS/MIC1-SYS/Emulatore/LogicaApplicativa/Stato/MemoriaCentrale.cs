using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class MemoriaCentrale
    {
        private static readonly object Object = new object();
        private static volatile MemoriaCentrale _ram;
        private readonly string[] _data;


        public MemoriaCentrale()
        {
            _data = new string[512];

            _data[128] = "00000000000000000000000000000000";
            _data[0] = "00000000000000000000000100000000";
            _data[1] = "00000101000100000000101000010000";
            _data[2] = "00000101000100000000101000010000";
        }

        public static MemoriaCentrale GetInstance()
        {
            if (_ram != null) return _ram;
            lock (Object)
            {
                if (_ram == null) _ram = new MemoriaCentrale();
            }

            return _ram;
        }

        public string read_data(string indirizzo)
        {
            return _data[Convert.ToUInt32(indirizzo, 2)];
        }

        public void write_data(string dato, string indirizzo)
        {
            _data[Convert.ToUInt32(indirizzo, 2)] = dato;
        }

        public string read_instr(string indirizzo)
        {
            var waAddress2 = "00" + indirizzo.Substring(0, 30);
            var tAddress2 = Convert.ToUInt32(waAddress2, 2);


            var tDataOut2 = _data[tAddress2];


            var tmp = indirizzo.Substring(30, 2);

            var retByte = tmp switch
            {
                "00" => tDataOut2.Substring(24, 8),
                "01" => tDataOut2.Substring(16, 8),
                "10" => tDataOut2.Substring(8, 8),
                "11" => tDataOut2.Substring(0, 8),
                _ => "00000000"
            };

            return "000000000000000000000000" + retByte;
        }


        public void CaricaProgramma()
        {
        }
    }
}