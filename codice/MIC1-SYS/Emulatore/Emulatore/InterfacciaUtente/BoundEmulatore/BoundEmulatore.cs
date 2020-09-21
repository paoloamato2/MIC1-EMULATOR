using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using MIC1_SYS.Emulatore.Controllo;
using Microsoft.VisualBasic;

namespace MIC1_SYS.Emulatore.InterfacciaUtente.BoundEmulatore
{
    public partial class BoundEmulatore : Form
    {
        public static readonly object Object = new object();

        private readonly Controller _controller;
        private List<MicroProgrammaOttenuto> _listaMicroProgrammi;
        private List<ProgrammaOttenuto> _listaProgrammi;
        private bool _reset;
        private bool _riprendi;
        private bool _sospendi;
        private bool _step;
        private bool _termina;
        private Thread _threadEmulazione;
        private Thread _threadInputHandler;

        private Thread _threadVisualizzazione;

        private BoundVisualizzazione.BoundVisualizzazione _vis;


        public BoundEmulatore()
        {
            _controller = new Controller();
            _listaProgrammi = new List<ProgrammaOttenuto>();
            _listaMicroProgrammi = new List<MicroProgrammaOttenuto>();
            InitializeComponent();
        }

        private void BoundEmulatore_Load(object sender, EventArgs e)
        {
            CaricaListaProgrammi();
            CaricaListaMicroProgrammi();
        }

        private void lstProgrammi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lstProgrammi_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lstMicroProgrammi_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            //ThreadEmulazione.Resume();
            _step = true;
        }

        [Obsolete]
        private void avviaProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstProgrammi.Enabled = false;
            lstMicroProgrammi.Enabled = false;
            cbSBS.Enabled = false;
            cbModalitaProgrammatore.Enabled = false;
            _vis = new BoundVisualizzazione.BoundVisualizzazione {Modprogrammatore = cbModalitaProgrammatore.Checked};
            _vis.Show();
            CreaThreadEmulatore(); //creazione del thread che gestisce il processo di emulazione
            CreaThreadVisualizzazione(); //creazione del thread che aggiorna la vista sullo stato dell'architettura
            CreaThreadInputHandler(); //creazione del thread che gestisce gli input forniti dall'utente
            if (cbSBS.Checked)
            {
                btnSospendi.Enabled = false;
                btnStep.Enabled = true;
            }

            //   btnRiprendi.Enabled = true;
            btnTermina.Enabled = true;
            btnReset.Enabled = true;
        }

        [Obsolete]
        private void CreaThreadInputHandler()
        {
            _threadInputHandler = new Thread(ThreadInputHandlingExecute);
            _threadInputHandler.Start();
        }

        private void CreaThreadEmulatore()
        {
            _threadEmulazione = new Thread(ThreadEmulazioneExecute);
            _threadEmulazione.Start();
        }

        private void CreaThreadVisualizzazione()
        {
            _threadVisualizzazione = new Thread(ThreadVisualizzazioneExecute);
            _threadVisualizzazione.Start();
        }

        private void ThreadEmulazioneExecute()
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                var id = int.Parse(lstProgrammi.SelectedItems[0].SubItems[0].Text);
                _controller.EseguiProgramma(id); //esecuzione prgoramma
            }
            catch (Exception)
            {
                Application.Restart();
            }
        }

        private void ThreadVisualizzazioneExecute()
        {
            while (true)
            {
                _controller.OttieniStato(); //prelievo stato corrente architettura
                _vis.AggiornaBoundVisualizzazione(_controller
                    .get_StatoOttenuto()); //aggiornamento dello stato visualizzato
            }
        }

        [Obsolete]
        private void ThreadInputHandlingExecute()
        {
            while (true)
                lock (Object)
                {
                    if (_step) //step input
                    {
                        _threadEmulazione.Resume();
                        _step = false;
                    }

                    if (_sospendi) //input di sospensione
                    {
                        _threadEmulazione.Suspend();
                        _sospendi = false;
                    }

                    if (_riprendi) //input di ripresa
                    {
                        _threadEmulazione.Resume();
                        _riprendi = false;
                    }

                    if (_reset) //input di reset
                    {
                        _controller.Reset();
                        _reset = false;
                    }

                    if (!_termina) continue;
                    //input di terminazione
                    Application.Restart();
                    _threadVisualizzazione.Abort();
                    _threadEmulazione.Abort();
                    _termina = false;
                    _threadInputHandler.Abort();
                }
        }

        private void caricaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstProgrammi.Items) lstProgrammi.Items.Remove(item);

            _listaProgrammi = _controller.get_ListaProgrammi();

            foreach (var prog in _listaProgrammi)
                lstProgrammi.Items.Add(new ListViewItem(new[] {prog.Id.ToString(), prog.Nome}));
        }

        private void caricaListaMicroProgrammiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstMicroProgrammi.Items) lstMicroProgrammi.Items.Remove(item);

            _listaMicroProgrammi = _controller.get_ListaMicroProgrammi();

            foreach (var microprog in _listaMicroProgrammi)
                lstMicroProgrammi.Items.Add(new ListViewItem(new[] {microprog.Id.ToString(), microprog.Nome}));
        }

        private void btnCaricaListaMicroProgrammi_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstMicroProgrammi.Items) lstMicroProgrammi.Items.Remove(item);

            _listaMicroProgrammi = _controller.get_ListaMicroProgrammi();

            foreach (var microprog in _listaMicroProgrammi)
                lstMicroProgrammi.Items.Add(new ListViewItem(new[] {microprog.Id.ToString(), microprog.Nome}));
        }

        private void inserisciProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Interaction.InputBox("Inserisci ID - Deve essere un valore numerico", "ID", "Default", 0,
                0));
            var nome = Interaction.InputBox("Inserisci nome", "Nome", "Default", 0, 0);
            var percorso = Interaction.InputBox("Inserisci nuovo percorso", "Percorso", "Default", 0, 0);
            _controller.InserisciProgramma(nome, id, percorso);
            CaricaListaProgrammi();
            MessageBox.Show("Inserimento effettuato.");
        }

        private void caricaListaProgrammiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaricaListaProgrammi();
        }

        private void CaricaListaProgrammi()
        {
            lstProgrammi.Items.Clear();
            //foreach (ListViewItem item in lstProgrammi.Items) lstProgrammi.Items.Remove(item);

            _listaProgrammi = _controller.get_ListaProgrammi();

            foreach (var prog in _listaProgrammi)
                lstProgrammi.Items.Add(new ListViewItem(new[] {prog.Id.ToString(), prog.Nome}));
        }

        private void caricaListaMicroProgrammiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CaricaListaMicroProgrammi();
        }

        private void CaricaListaMicroProgrammi()
        {
            lstMicroProgrammi.Items.Clear();


            _listaMicroProgrammi = _controller.get_ListaMicroProgrammi();

            foreach (var microprog in _listaMicroProgrammi)
                lstMicroProgrammi.Items.Add(new ListViewItem(new[] {microprog.Id.ToString(), microprog.Nome}));
        }

        private void modificaProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuovoId =
                int.Parse(Interaction.InputBox("Inserisci ID - Deve essere un valore numerico", "ID", "Default", 0, 0));
            var nome = Interaction.InputBox("Inserisci nome", "Nome", "Default", 0, 0);
            var percorso = Interaction.InputBox("Inserisci nuovo percorso", "Percorso", "Default", 0, 0);
            var vecchioId = int.Parse(lstProgrammi.SelectedItems[0].SubItems[0].Text);
            _controller.AggiornaProgramma(vecchioId, nuovoId, nome, percorso);
            CaricaListaProgrammi();
            MessageBox.Show("Modifica effettuata.");
        }

        private void modificaMicroProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuovoId =
                int.Parse(Interaction.InputBox("Inserisci ID - Deve essere un valore numerico", "ID", "Default", 0, 0));
            var nome = Interaction.InputBox("Inserisci nome", "Nome", "Default", 0, 0);
            var percorso = Interaction.InputBox("Inserisci nuovo percorso", "Percorso", "Default", 0, 0);
            var vecchioId = int.Parse(lstMicroProgrammi.SelectedItems[0].SubItems[0].Text);
            _controller.AggiornaMicroProgramma(vecchioId, nuovoId, nome, percorso);
            CaricaListaMicroProgrammi();
            MessageBox.Show("Modifica effettuata.");
        }

        private void eliminaProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = int.Parse(lstProgrammi.SelectedItems[0].SubItems[0].Text);
            _controller.EliminaProgramma(id);
            CaricaListaProgrammi();
            MessageBox.Show("Eliminazione effettuata.");
        }

        private void eliminaMicroProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = int.Parse(lstMicroProgrammi.SelectedItems[0].SubItems[0].Text);
            _controller.EliminaMicroProgramma(id);
            CaricaListaMicroProgrammi();
            MessageBox.Show("Eliminazione effettuata.");
        }

        private void inserisciMicroProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Interaction.InputBox("Inserisci ID - Deve essere un valore numerico", "ID", "Default", 0,
                0));
            var nome = Interaction.InputBox("Inserisci nome", "Nome", "Default", 0, 0);
            var percorso = Interaction.InputBox("Inserisci nuovo percorso", "Percorso", "Default", 0, 0);
            _controller.InserisciMicroProgramma(nome, id, percorso);
            CaricaListaMicroProgrammi();
            MessageBox.Show("Inserimento effettuato.");
        }

        private void caricaMicroProgrammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstProgrammi.Enabled = true;
            var id = int.Parse(lstMicroProgrammi.SelectedItems[0].SubItems[0].Text);
            _controller.CaricaMicroProgramma(id);
        }

        private void btnSospendi_Click(object sender, EventArgs e)
        {
            lock (Object)
            {
                _sospendi = true;
                btnSospendi.Enabled = false;
                btnRiprendi.Enabled = true;
            }
        }

        private void btnRiprendi_Click(object sender, EventArgs e)
        {
            lock (Object)
            {
                _riprendi = true;
                btnRiprendi.Enabled = false;
                btnSospendi.Enabled = true;
            }
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            lock (Object)
            {
                _termina = true;
            }
        }

        private void cbSBS_CheckedChanged(object sender, EventArgs e)
        {
            _controller.SetStepByStep(cbSBS.Checked);
        }

        private void BoundEmulatore_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cbModalitaProgrammatore_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _reset = true;
        }

        private void contextMenuProgrammi_Opening(object sender, CancelEventArgs e)
        {
        }
    }
}