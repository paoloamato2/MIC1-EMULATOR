namespace MIC1_SYS.Emulatore.InterfacciaUtente.BoundEmulatore
{
    partial class BoundEmulatore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstProgrammi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuProgrammi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.avviaProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaListaProgrammiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProgrammi = new System.Windows.Forms.Label();
            this.lblMicroProgrammi = new System.Windows.Forms.Label();
            this.lstMicroProgrammi = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuMicroProgrammi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.caricaMicroProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciMicroProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaMicroProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaMicroProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaListaMicroProgrammiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbModalitaProgrammatore = new System.Windows.Forms.CheckBox();
            this.cbSBS = new System.Windows.Forms.CheckBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnSospendi = new System.Windows.Forms.Button();
            this.btnRiprendi = new System.Windows.Forms.Button();
            this.btnTermina = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.contextMenuProgrammi.SuspendLayout();
            this.contextMenuMicroProgrammi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProgrammi
            // 
            this.lstProgrammi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstProgrammi.ContextMenuStrip = this.contextMenuProgrammi;
            this.lstProgrammi.Enabled = false;
            this.lstProgrammi.ForeColor = System.Drawing.Color.Red;
            this.lstProgrammi.HideSelection = false;
            this.lstProgrammi.Location = new System.Drawing.Point(30, 36);
            this.lstProgrammi.Name = "lstProgrammi";
            this.lstProgrammi.Size = new System.Drawing.Size(349, 242);
            this.lstProgrammi.TabIndex = 20;
            this.lstProgrammi.UseCompatibleStateImageBehavior = false;
            this.lstProgrammi.View = System.Windows.Forms.View.Details;
            this.lstProgrammi.SelectedIndexChanged += new System.EventHandler(this.lstProgrammi_SelectedIndexChanged);
            this.lstProgrammi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstProgrammi_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 130;
            // 
            // contextMenuProgrammi
            // 
            this.contextMenuProgrammi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuProgrammi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avviaProgrammaToolStripMenuItem,
            this.inserisciProgrammaToolStripMenuItem,
            this.eliminaProgrammaToolStripMenuItem,
            this.modificaProgrammaToolStripMenuItem,
            this.caricaListaProgrammiToolStripMenuItem});
            this.contextMenuProgrammi.Name = "contextMenuProgrammi";
            this.contextMenuProgrammi.Size = new System.Drawing.Size(232, 124);
            this.contextMenuProgrammi.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuProgrammi_Opening);
            // 
            // avviaProgrammaToolStripMenuItem
            // 
            this.avviaProgrammaToolStripMenuItem.Name = "avviaProgrammaToolStripMenuItem";
            this.avviaProgrammaToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.avviaProgrammaToolStripMenuItem.Text = "Avvia Programma";
            this.avviaProgrammaToolStripMenuItem.Click += new System.EventHandler(this.avviaProgrammaToolStripMenuItem_Click);
            // 
            // inserisciProgrammaToolStripMenuItem
            // 
            this.inserisciProgrammaToolStripMenuItem.Name = "inserisciProgrammaToolStripMenuItem";
            this.inserisciProgrammaToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.inserisciProgrammaToolStripMenuItem.Text = "Inserisci Programma";
            this.inserisciProgrammaToolStripMenuItem.Click += new System.EventHandler(this.inserisciProgrammaToolStripMenuItem_Click);
            // 
            // eliminaProgrammaToolStripMenuItem
            // 
            this.eliminaProgrammaToolStripMenuItem.Name = "eliminaProgrammaToolStripMenuItem";
            this.eliminaProgrammaToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.eliminaProgrammaToolStripMenuItem.Text = "Elimina Programma";
            this.eliminaProgrammaToolStripMenuItem.Click += new System.EventHandler(this.eliminaProgrammaToolStripMenuItem_Click);
            // 
            // modificaProgrammaToolStripMenuItem
            // 
            this.modificaProgrammaToolStripMenuItem.Name = "modificaProgrammaToolStripMenuItem";
            this.modificaProgrammaToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.modificaProgrammaToolStripMenuItem.Text = "Modifica Programma";
            this.modificaProgrammaToolStripMenuItem.Click += new System.EventHandler(this.modificaProgrammaToolStripMenuItem_Click);
            // 
            // caricaListaProgrammiToolStripMenuItem
            // 
            this.caricaListaProgrammiToolStripMenuItem.Name = "caricaListaProgrammiToolStripMenuItem";
            this.caricaListaProgrammiToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.caricaListaProgrammiToolStripMenuItem.Text = "Carica Lista Programmi";
            this.caricaListaProgrammiToolStripMenuItem.Click += new System.EventHandler(this.caricaListaProgrammiToolStripMenuItem_Click);
            // 
            // lblProgrammi
            // 
            this.lblProgrammi.AutoSize = true;
            this.lblProgrammi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammi.Location = new System.Drawing.Point(27, 16);
            this.lblProgrammi.Name = "lblProgrammi";
            this.lblProgrammi.Size = new System.Drawing.Size(125, 17);
            this.lblProgrammi.TabIndex = 21;
            this.lblProgrammi.Text = "Lista Programmi";
            // 
            // lblMicroProgrammi
            // 
            this.lblMicroProgrammi.AutoSize = true;
            this.lblMicroProgrammi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicroProgrammi.Location = new System.Drawing.Point(447, 16);
            this.lblMicroProgrammi.Name = "lblMicroProgrammi";
            this.lblMicroProgrammi.Size = new System.Drawing.Size(164, 17);
            this.lblMicroProgrammi.TabIndex = 23;
            this.lblMicroProgrammi.Text = "Lista MicroProgrammi";
            // 
            // lstMicroProgrammi
            // 
            this.lstMicroProgrammi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstMicroProgrammi.ContextMenuStrip = this.contextMenuMicroProgrammi;
            this.lstMicroProgrammi.ForeColor = System.Drawing.Color.Red;
            this.lstMicroProgrammi.HideSelection = false;
            this.lstMicroProgrammi.Location = new System.Drawing.Point(450, 36);
            this.lstMicroProgrammi.Name = "lstMicroProgrammi";
            this.lstMicroProgrammi.Size = new System.Drawing.Size(349, 242);
            this.lstMicroProgrammi.TabIndex = 22;
            this.lstMicroProgrammi.UseCompatibleStateImageBehavior = false;
            this.lstMicroProgrammi.View = System.Windows.Forms.View.Details;
            this.lstMicroProgrammi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMicroProgrammi_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome";
            this.columnHeader4.Width = 130;
            // 
            // contextMenuMicroProgrammi
            // 
            this.contextMenuMicroProgrammi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuMicroProgrammi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caricaMicroProgrammaToolStripMenuItem,
            this.inserisciMicroProgrammaToolStripMenuItem,
            this.eliminaMicroProgrammaToolStripMenuItem,
            this.modificaMicroProgrammaToolStripMenuItem,
            this.caricaListaMicroProgrammiToolStripMenuItem});
            this.contextMenuMicroProgrammi.Name = "contextMenuMicroProgrammi";
            this.contextMenuMicroProgrammi.Size = new System.Drawing.Size(423, 152);
            // 
            // caricaMicroProgrammaToolStripMenuItem
            // 
            this.caricaMicroProgrammaToolStripMenuItem.Name = "caricaMicroProgrammaToolStripMenuItem";
            this.caricaMicroProgrammaToolStripMenuItem.Size = new System.Drawing.Size(422, 24);
            this.caricaMicroProgrammaToolStripMenuItem.Text = "Carica MicroProgramma nella Memoria di Controllo";
            this.caricaMicroProgrammaToolStripMenuItem.Click += new System.EventHandler(this.caricaMicroProgrammaToolStripMenuItem_Click);
            // 
            // inserisciMicroProgrammaToolStripMenuItem
            // 
            this.inserisciMicroProgrammaToolStripMenuItem.Name = "inserisciMicroProgrammaToolStripMenuItem";
            this.inserisciMicroProgrammaToolStripMenuItem.Size = new System.Drawing.Size(422, 24);
            this.inserisciMicroProgrammaToolStripMenuItem.Text = "Inserisci MicroProgramma";
            this.inserisciMicroProgrammaToolStripMenuItem.Click += new System.EventHandler(this.inserisciMicroProgrammaToolStripMenuItem_Click);
            // 
            // eliminaMicroProgrammaToolStripMenuItem
            // 
            this.eliminaMicroProgrammaToolStripMenuItem.Name = "eliminaMicroProgrammaToolStripMenuItem";
            this.eliminaMicroProgrammaToolStripMenuItem.Size = new System.Drawing.Size(422, 24);
            this.eliminaMicroProgrammaToolStripMenuItem.Text = "Elimina MicroProgramma";
            this.eliminaMicroProgrammaToolStripMenuItem.Click += new System.EventHandler(this.eliminaMicroProgrammaToolStripMenuItem_Click);
            // 
            // modificaMicroProgrammaToolStripMenuItem
            // 
            this.modificaMicroProgrammaToolStripMenuItem.Name = "modificaMicroProgrammaToolStripMenuItem";
            this.modificaMicroProgrammaToolStripMenuItem.Size = new System.Drawing.Size(422, 24);
            this.modificaMicroProgrammaToolStripMenuItem.Text = "Modifica MicroProgramma";
            this.modificaMicroProgrammaToolStripMenuItem.Click += new System.EventHandler(this.modificaMicroProgrammaToolStripMenuItem_Click);
            // 
            // caricaListaMicroProgrammiToolStripMenuItem
            // 
            this.caricaListaMicroProgrammiToolStripMenuItem.Name = "caricaListaMicroProgrammiToolStripMenuItem";
            this.caricaListaMicroProgrammiToolStripMenuItem.Size = new System.Drawing.Size(422, 24);
            this.caricaListaMicroProgrammiToolStripMenuItem.Text = "Carica Lista MicroProgrammi";
            this.caricaListaMicroProgrammiToolStripMenuItem.Click += new System.EventHandler(this.caricaListaMicroProgrammiToolStripMenuItem_Click_1);
            // 
            // cbModalitaProgrammatore
            // 
            this.cbModalitaProgrammatore.AutoSize = true;
            this.cbModalitaProgrammatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalitaProgrammatore.Location = new System.Drawing.Point(32, 383);
            this.cbModalitaProgrammatore.Name = "cbModalitaProgrammatore";
            this.cbModalitaProgrammatore.Size = new System.Drawing.Size(207, 21);
            this.cbModalitaProgrammatore.TabIndex = 26;
            this.cbModalitaProgrammatore.Text = "Modalità Programmatore";
            this.cbModalitaProgrammatore.UseVisualStyleBackColor = true;
            this.cbModalitaProgrammatore.CheckedChanged += new System.EventHandler(this.cbModalitaProgrammatore_CheckedChanged);
            // 
            // cbSBS
            // 
            this.cbSBS.AutoSize = true;
            this.cbSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSBS.Location = new System.Drawing.Point(32, 420);
            this.cbSBS.Name = "cbSBS";
            this.cbSBS.Size = new System.Drawing.Size(213, 21);
            this.cbSBS.TabIndex = 27;
            this.cbSBS.Text = "Esecuzione Step-by-Step";
            this.cbSBS.UseVisualStyleBackColor = true;
            this.cbSBS.CheckedChanged += new System.EventHandler(this.cbSBS_CheckedChanged);
            // 
            // btnStep
            // 
            this.btnStep.Enabled = false;
            this.btnStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep.Location = new System.Drawing.Point(450, 401);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(70, 29);
            this.btnStep.TabIndex = 28;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = false;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnSospendi
            // 
            this.btnSospendi.Enabled = false;
            this.btnSospendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSospendi.Location = new System.Drawing.Point(542, 401);
            this.btnSospendi.Name = "btnSospendi";
            this.btnSospendi.Size = new System.Drawing.Size(92, 29);
            this.btnSospendi.TabIndex = 29;
            this.btnSospendi.Text = "Sospendi";
            this.btnSospendi.UseVisualStyleBackColor = false;
            this.btnSospendi.Click += new System.EventHandler(this.btnSospendi_Click);
            // 
            // btnRiprendi
            // 
            this.btnRiprendi.Enabled = false;
            this.btnRiprendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiprendi.Location = new System.Drawing.Point(652, 401);
            this.btnRiprendi.Name = "btnRiprendi";
            this.btnRiprendi.Size = new System.Drawing.Size(99, 29);
            this.btnRiprendi.TabIndex = 30;
            this.btnRiprendi.Text = "Riprendi";
            this.btnRiprendi.UseVisualStyleBackColor = false;
            this.btnRiprendi.Click += new System.EventHandler(this.btnRiprendi_Click);
            // 
            // btnTermina
            // 
            this.btnTermina.Enabled = false;
            this.btnTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermina.Location = new System.Drawing.Point(757, 401);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(89, 29);
            this.btnTermina.TabIndex = 31;
            this.btnTermina.Text = "Termina";
            this.btnTermina.UseVisualStyleBackColor = false;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(605, 458);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 29);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BoundEmulatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(924, 520);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTermina);
            this.Controls.Add(this.btnRiprendi);
            this.Controls.Add(this.btnSospendi);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.cbSBS);
            this.Controls.Add(this.cbModalitaProgrammatore);
            this.Controls.Add(this.lblMicroProgrammi);
            this.Controls.Add(this.lstMicroProgrammi);
            this.Controls.Add(this.lblProgrammi);
            this.Controls.Add(this.lstProgrammi);
            this.Name = "BoundEmulatore";
            this.Text = "Emulatore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoundEmulatore_FormClosing);
            this.Load += new System.EventHandler(this.BoundEmulatore_Load);
            this.contextMenuProgrammi.ResumeLayout(false);
            this.contextMenuMicroProgrammi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstProgrammi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblProgrammi;
        private System.Windows.Forms.Label lblMicroProgrammi;
        private System.Windows.Forms.ListView lstMicroProgrammi;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuProgrammi;
        private System.Windows.Forms.ToolStripMenuItem avviaProgrammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciProgrammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaProgrammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaProgrammaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMicroProgrammi;
        private System.Windows.Forms.ToolStripMenuItem caricaMicroProgrammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciMicroProgrammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaMicroProgrammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaMicroProgrammaToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbModalitaProgrammatore;
        private System.Windows.Forms.CheckBox cbSBS;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnSospendi;
        private System.Windows.Forms.Button btnRiprendi;
        private System.Windows.Forms.Button btnTermina;
        private System.Windows.Forms.ToolStripMenuItem caricaListaProgrammiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaListaMicroProgrammiToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
    }
}