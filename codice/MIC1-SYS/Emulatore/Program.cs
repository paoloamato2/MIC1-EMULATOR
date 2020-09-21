using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MIC1_SYS.Emulatore.Controllo;
using MIC1_SYS.Emulatore.InterfacciaUtente.BoundEmulatore;

namespace MIC1_SYS
{
    internal static class Program
    {
        /// <summary>
        ///     Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Form1());
            var cntrl = new Controller();
            //cntrl.EseguiProgramma("", 0, "");
            //cntrl.InserisciProgramma("Testabomba",99, @"C:\Users\amato\OneDrive\Desktop\ASE\tesina\tesina paolo\esercizio 12\processore\tools\ajvm\bin\programmi\program_1.bin");
            //cntrl.InserisciMicroProgramma("TestPaolo",5, @"C:\Users\amato\OneDrive\Desktop\ASE\tesina\tesina paolo\esercizio 12\processore\tools\mal\bin\ajvm.bin");
            //cntrl.AggiornaProgramma(81,150,"Pera#", @"C:\Users\amato\OneDrive\Desktop\ASE\tesina\tesina paolo\esercizio 12\processore\tools\mal\bin\halt.bin");
            //cntrl.AggiornaMicroProgramma(111,112,"TestFranco+++", @"C:\Users\amato\OneDrive\Desktop\ASE\tesina\tesina paolo\esercizio 12\processore\tools\mal\bin\halt.bin");
            //cntrl.EliminaMicroProgramma(112);
            //cntrl.CaricaListaMicroProgrammi();
            //cntrl.get_ListaMicroProgrammi();
            Application.Run(new BoundEmulatore());
            //Application.Run(new BoundVisualizzazione());
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}