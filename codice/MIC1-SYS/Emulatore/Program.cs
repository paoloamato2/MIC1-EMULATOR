using System;
using System.Windows.Forms;
using MIC1_SYS.Emulatore.Controllo;

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
            cntrl.EseguiProgramma("", 0, "");
        }
    }
}