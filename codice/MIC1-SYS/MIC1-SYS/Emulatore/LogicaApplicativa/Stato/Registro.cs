using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class Registro
    {
        static readonly object _object = new object();
        private string nome;
        private string dato;
        private static volatile Registro[] registers;

        public Registro(string name,string data)
        {
            Nome = name;
            dato = data;
        }

        public string Dato
        {
            get => dato;
            set => dato = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public void setALUoperand()
        {

        }

        public void writeBUS()
        {

        }

        public static Registro[] getInstance()
        {
            if (registers==null)
            {
                lock (_object)
                {
                    if (registers==null)
                    {
                        registers = new Registro[10];
                        registers[0] = new Registro("MAR","00000000000000000000000000000000");
                        registers[1] = new Registro("MDR", "00000000000000000000000000000000");
                        registers[2] = new Registro("PC", "00000000000000000000000000000000");
                        registers[3] = new Registro("MBR", "00000000000000000000000000000000");
                        registers[4] = new Registro("SP", "00000000000000000000000000000000");
                        registers[5] = new Registro("LV", "00000000000000000000000000000000");
                        registers[6] = new Registro("CPP", "00000000000000000000000000000000");
                        registers[7] = new Registro("TOS", "00000000000000000000000000000000");
                        registers[8] = new Registro("OPC", "00000000000000000000000000000000");
                        registers[9] = new Registro("H", "00000000000000000000000000000000");
                    }
                }
            }

            return registers;
        }
        

    }
}
