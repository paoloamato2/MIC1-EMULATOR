using System;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class UnitàOperativa
    {
        private static readonly object _object = new object();
        private static volatile UnitàOperativa UO;
        public static int rd_ff;
        public static int fetch_ff;
        public static int wr_ff;
        private readonly ALU alu;
        private BUS_B busB;
        private BUS_C busC;
        private string operation;
        private readonly Registro[] registers;
        private ShiftRegister SR;

        public UnitàOperativa()
        {
            SR = ShiftRegister.GetInstance();
            alu = ALU.GetInstance();
            busC = BUS_C.GetInstance();
            busB = BUS_B.GetInstance();
            registers = Registro.getInstance();
        }

        public static UnitàOperativa getInstance()
        {
            if (UO != null) return UO;
            lock (_object)
            {
                if (UO == null) UO = new UnitàOperativa();
            }

            return UO;
        }

        public void reset()
        {
            registers[4].Dato = Utility.ToBin(0x00000101, 32); //sp
            registers[5].Dato = Utility.ToBin(0x00000100, 32); //lv
            registers[6].Dato = Utility.ToBin(0x00000080, 32); //cpp
            registers[7].Dato = Utility.ToBin(0, 32); //tos
            registers[8].Dato = Utility.ToBin(0, 32); //opc
            registers[9].Dato = Utility.ToBin(0, 32); //h
            registers[0].Dato = Utility.ToBin(0, 32); //mar
            registers[1].Dato = Utility.ToBin(0, 32); //mdr
            registers[2].Dato = Utility.ToBin(0, 32); //mbr
            registers[3].Dato = Utility.ToBin(0, 32); //pc

            rd_ff = 0;
            fetch_ff = 0;
            wr_ff = 0;
        }

        public void fetch()
        {
        }

        public void execute(string Opcode)
        {
        }

        public string get_MBR()
        {
            return registers[3].Dato;
        }

        public int[] get_ALUflag()
        {
            var result = new int[2];
            result[0] = Convert.ToInt32(alu.NFlag);
            result[1] = Convert.ToInt32(alu.ZFlag);
            return result;
        }
    }
}