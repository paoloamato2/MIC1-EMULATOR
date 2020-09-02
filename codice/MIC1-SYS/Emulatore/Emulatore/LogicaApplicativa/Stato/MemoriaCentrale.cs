using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class MemoriaCentrale
    {
        private static readonly object Object = new object();
        private static volatile MemoriaCentrale _ram;


        public MemoriaCentrale()
        {
            Data = new string[512];

            for (var i = 0; i < 512; i++) Data[i] = "00000000000000000000000000000000";

            // _data[128] = "00000000000000000000000000000000";
            //_data[0] = "00000000000000000000000100000000";
            //_data[1] = "00000101000100000000101000010000";
            //_data[2] = "00000101000100000000101000010000";

            //_data[128] = "00000000000000000000000000000000";

            Data[0] = "00000011000000000000000100000000";
            Data[1] = "00000001001101100000111100010000";
            Data[2] = "00000010001101100001011000010000";
            Data[3] = "00000010000101010000000100010101";
            Data[4] = "10100111000000110011011010110110";
            Data[5] = "00000000000000000000000000000000";

            //_data[128] = "00000000000000000000000000000000";
            //_data[129] = "00000000000000000000000000101100";
            //_data[130] = "00000000000000000000000000010000";
            //_data[0] = "00000000000000000000000100000000";
            //_data[1] = "00010000000000010000000000100000";
            //_data[2] = "00000000101110010101110000001010";
            //_data[3] = "00000000000000001010011100000010";
            //_data[4] = "00000000000000000000000100000000";
            //_data[5] = "00001011000100000001101000010000";
            //_data[6] = "00000000000000001010110101011100";
        }

        public string[] Data { get; set; }

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
            return Data[Convert.ToUInt32(indirizzo, 2)];
        }

        public void write_data(string dato, string indirizzo)
        {
            Data[Convert.ToUInt32(indirizzo, 2)] = dato;
        }

        public string read_instr(string indirizzo)
        {
            var waAddress2 = "00" + indirizzo.Substring(0, 30);
            var tAddress2 = Convert.ToUInt32(waAddress2, 2);


            var tDataOut2 = Data[tAddress2];


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


        public void CaricaProgramma(string[] data)
        {
            var index = 0;
            for (var i = 0; i < 512; i++) Data[i] = "00000000000000000000000000000000";

            for (var i = 0; i < data.Length; i++)
            {
                if (!data[i].Contains("@0")) continue;
                index = i;
                break;
            }

            for (var i = 1; i < index; i++) Data[128 + i - 1] = data[i];

            for (var i = 0; i < data.Length - index - 1; i++) Data[i] = data[i + 1 + index];
        }
    }
}