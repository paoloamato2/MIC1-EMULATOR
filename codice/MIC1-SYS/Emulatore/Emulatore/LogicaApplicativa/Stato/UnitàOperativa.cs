using System;
using System.Diagnostics;

namespace MIC1_SYS.Emulatore.LogicaApplicativa.Stato
{
    public class UnitàOperativa
    {
        private static readonly object Object = new object();
        private static volatile UnitàOperativa _uo;
        public static int RdFf;
        public static int FetchFf;
        public static int WrFf;
        private readonly ALU _alu;
        private readonly BusB _busB;
        private readonly BusC _busC;
        private readonly Registro[] _registers;
        private readonly ShiftRegister _sr;
        private readonly BusDiSistema _systemBus;
        private string _prevMemControl;
        private string[] _prevMemOp;
        private bool _prevOp;

        public UnitàOperativa()
        {
            _sr = ShiftRegister.GetInstance();
            _alu = ALU.GetInstance();
            _busC = BusC.GetInstance();
            _busB = BusB.GetInstance();
            _registers = Registro.GetInstance();
            _systemBus = BusDiSistema.GetInstance();
        }

        public static UnitàOperativa GetInstance()
        {
            if (_uo != null) return _uo;
            lock (Object)
            {
                if (_uo == null) _uo = new UnitàOperativa();
            }

            return _uo;
        }

        public void Reset()
        {
            _registers[4].Dato = Utility.ToBin(0x00000101, 32); //sp
            _registers[5].Dato = Utility.ToBin(0x00000100, 32); //lv
            _registers[6].Dato = Utility.ToBin(0x00000080, 32); //cpp
            _registers[7].Dato = Utility.ToBin(0, 32); //tos
            _registers[8].Dato = Utility.ToBin(0, 32); //opc
            _registers[9].Dato = Utility.ToBin(0, 32); //h
            _registers[0].Dato = Utility.ToBin(0, 32); //mar
            _registers[1].Dato = Utility.ToBin(0, 32); //mdr
            _registers[2].Dato = Utility.ToBin(0, 32); //mbr
            _registers[3].Dato = Utility.ToBin(0, 32); //pc

            _prevOp = false;
            _prevMemControl = "000";
            RdFf = 0; //read_data
            FetchFf = 0; //fetch_instruction
            WrFf = 0; //write_data
        }

        public void Execute(string opcode)
        {
            var bControl = opcode.Substring(32, 4);
            var memControl = opcode.Substring(29, 3);
            var cControl = opcode.Substring(20, 9);
            var aluControl = opcode.Substring(14, 6);
            var srControl = opcode.Substring(12, 2);

            //Debug.WriteLine(registers[3].Dato);

            Debug.WriteLine("Valore Stack Pointer: " + _registers[4].Dato);
            Debug.WriteLine("Valore all'indirizzo puntato da SP: " +
                            MemoriaCentrale.GetInstance().read_data(_registers[4].Dato));
            //  wr_ff = Convert.ToInt32(mem_control.Substring(0, 1));
            // rd_ff = Convert.ToInt32(mem_control.Substring(1, 1));
            // fetch_ff = Convert.ToInt32(mem_control.Substring(2, 1));

            _busB.Operation = bControl;
            _busB.execute_op();

            _busB.SetAlUoperand();
            _registers[9].SetAlUoperand();

            _alu.Operation = aluControl;
            _alu.execute_op();

            _sr.Operation = srControl;
            _sr.execute_op();


            _busC.Operation = cControl;
            _busC.execute_op();

            var mar = _registers[0].Dato;
            var mdr = _registers[1].Dato;
            var pc = _registers[2].Dato;

            UpdateRegisters();

            _systemBus.Operation = memControl;
            var result = _systemBus.execute_op(mar, mdr, pc);
            _prevMemOp = result;

            if (memControl == "000") return;
            _prevMemControl = memControl;
            _prevOp = true;
        }

        private void UpdateRegisters()
        {
            if (_prevOp)
            {
                RdFf = Convert.ToInt32(_prevMemControl.Substring(1, 1));
                FetchFf = Convert.ToInt32(_prevMemControl.Substring(2, 1));

                if (RdFf == 1) _registers[1].Dato = _prevMemOp[0]; //update mdr

                if (FetchFf == 1) _registers[3].Dato = _prevMemOp[1]; //update mbr

                _prevOp = false;
            }
        }

        public string get_MBR()
        {
            return _registers[3].Dato;
        }

        public int[] get_ALUflag()
        {
            var result = new int[2];
            result[0] = Convert.ToInt32(_alu.NFlag);
            result[1] = Convert.ToInt32(_alu.ZFlag);
            return result;
        }
    }
}