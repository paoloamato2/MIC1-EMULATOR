namespace MIC1_SYS.Emulatore.InterfacciaUtente.BoundVisualizzazione
{
    partial class BoundVisualizzazione
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
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblMAR = new System.Windows.Forms.Label();
            this.txtMAR = new System.Windows.Forms.TextBox();
            this.lblMDR = new System.Windows.Forms.Label();
            this.txtMDR = new System.Windows.Forms.TextBox();
            this.lblPC = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.lblLV = new System.Windows.Forms.Label();
            this.txtLV = new System.Windows.Forms.TextBox();
            this.lblCPP = new System.Windows.Forms.Label();
            this.txtCPP = new System.Windows.Forms.TextBox();
            this.lblTOS = new System.Windows.Forms.Label();
            this.txtTOS = new System.Windows.Forms.TextBox();
            this.lblOPC = new System.Windows.Forms.Label();
            this.txtOPC = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblRegistri = new System.Windows.Forms.Label();
            this.lstMemoriaCentrale = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMemoriaCentrale = new System.Windows.Forms.Label();
            this.lblMemoriaControllo = new System.Windows.Forms.Label();
            this.lstMemoriaControllo = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBusBop = new System.Windows.Forms.Label();
            this.txtBusBop = new System.Windows.Forms.TextBox();
            this.lblBusBdato = new System.Windows.Forms.Label();
            this.txtBusBdato = new System.Windows.Forms.TextBox();
            this.lblBusCdato = new System.Windows.Forms.Label();
            this.txtBusCdato = new System.Windows.Forms.TextBox();
            this.lblBusCop = new System.Windows.Forms.Label();
            this.txtBusCop = new System.Windows.Forms.TextBox();
            this.lblBusB = new System.Windows.Forms.Label();
            this.lblBusC = new System.Windows.Forms.Label();
            this.lblOpALU = new System.Windows.Forms.Label();
            this.txtOpALU = new System.Windows.Forms.TextBox();
            this.lblOperand_A_ALU = new System.Windows.Forms.Label();
            this.txtOperand_A_ALU = new System.Windows.Forms.TextBox();
            this.lblOperand_B_ALU = new System.Windows.Forms.Label();
            this.txtOperand_B_ALU = new System.Windows.Forms.TextBox();
            this.lblRisultatoALU = new System.Windows.Forms.Label();
            this.txtRisultatoALU = new System.Windows.Forms.TextBox();
            this.lblNflagALU = new System.Windows.Forms.Label();
            this.txtNflagALU = new System.Windows.Forms.TextBox();
            this.lblZflagALU = new System.Windows.Forms.Label();
            this.txtZflagALU = new System.Windows.Forms.TextBox();
            this.lblALU = new System.Windows.Forms.Label();
            this.lblOpSR = new System.Windows.Forms.Label();
            this.txtOpSR = new System.Windows.Forms.TextBox();
            this.lblDatoSR = new System.Windows.Forms.Label();
            this.txtDatoSR = new System.Windows.Forms.TextBox();
            this.lblSR = new System.Windows.Forms.Label();
            this.lblMBR = new System.Windows.Forms.Label();
            this.txtMBR = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbVisualizzaRegistri = new System.Windows.Forms.CheckBox();
            this.cbVisualizzaMemoriaCentrale = new System.Windows.Forms.CheckBox();
            this.cbVisualizzaMemoriaControllo = new System.Windows.Forms.CheckBox();
            this.cbVisualizzaBusB = new System.Windows.Forms.CheckBox();
            this.cbVisualizzaBusC = new System.Windows.Forms.CheckBox();
            this.cbVisualizzaSR = new System.Windows.Forms.CheckBox();
            this.cbVisualizzaALU = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSP
            // 
            this.txtSP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP.ForeColor = System.Drawing.Color.Red;
            this.txtSP.Location = new System.Drawing.Point(74, 38);
            this.txtSP.Name = "txtSP";
            this.txtSP.ReadOnly = true;
            this.txtSP.Size = new System.Drawing.Size(319, 22);
            this.txtSP.TabIndex = 0;
            this.txtSP.TextChanged += new System.EventHandler(this.txtSP_TextChanged);
            this.txtSP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSP_MouseMove);
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP.Location = new System.Drawing.Point(19, 41);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(33, 17);
            this.lblSP.TabIndex = 1;
            this.lblSP.Text = "SP:";
            // 
            // lblMAR
            // 
            this.lblMAR.AutoSize = true;
            this.lblMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAR.Location = new System.Drawing.Point(19, 69);
            this.lblMAR.Name = "lblMAR";
            this.lblMAR.Size = new System.Drawing.Size(46, 17);
            this.lblMAR.TabIndex = 3;
            this.lblMAR.Text = "MAR:";
            this.lblMAR.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMAR
            // 
            this.txtMAR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAR.ForeColor = System.Drawing.Color.Red;
            this.txtMAR.Location = new System.Drawing.Point(74, 66);
            this.txtMAR.Name = "txtMAR";
            this.txtMAR.ReadOnly = true;
            this.txtMAR.Size = new System.Drawing.Size(319, 22);
            this.txtMAR.TabIndex = 2;
            this.txtMAR.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtMAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtMAR_MouseMove);
            // 
            // lblMDR
            // 
            this.lblMDR.AutoSize = true;
            this.lblMDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDR.Location = new System.Drawing.Point(19, 97);
            this.lblMDR.Name = "lblMDR";
            this.lblMDR.Size = new System.Drawing.Size(47, 17);
            this.lblMDR.TabIndex = 5;
            this.lblMDR.Text = "MDR:";
            this.lblMDR.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtMDR
            // 
            this.txtMDR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDR.ForeColor = System.Drawing.Color.Red;
            this.txtMDR.Location = new System.Drawing.Point(74, 94);
            this.txtMDR.Name = "txtMDR";
            this.txtMDR.ReadOnly = true;
            this.txtMDR.Size = new System.Drawing.Size(319, 22);
            this.txtMDR.TabIndex = 4;
            this.txtMDR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtMDR_MouseMove);
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.Location = new System.Drawing.Point(19, 125);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(33, 17);
            this.lblPC.TabIndex = 7;
            this.lblPC.Text = "PC:";
            // 
            // txtPC
            // 
            this.txtPC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPC.ForeColor = System.Drawing.Color.Red;
            this.txtPC.Location = new System.Drawing.Point(74, 122);
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(319, 22);
            this.txtPC.TabIndex = 6;
            this.txtPC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPC_MouseMove);
            // 
            // lblLV
            // 
            this.lblLV.AutoSize = true;
            this.lblLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLV.Location = new System.Drawing.Point(19, 181);
            this.lblLV.Name = "lblLV";
            this.lblLV.Size = new System.Drawing.Size(32, 17);
            this.lblLV.TabIndex = 9;
            this.lblLV.Text = "LV:";
            // 
            // txtLV
            // 
            this.txtLV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLV.ForeColor = System.Drawing.Color.Red;
            this.txtLV.Location = new System.Drawing.Point(74, 178);
            this.txtLV.Name = "txtLV";
            this.txtLV.ReadOnly = true;
            this.txtLV.Size = new System.Drawing.Size(319, 22);
            this.txtLV.TabIndex = 8;
            this.txtLV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtLV_MouseMove);
            // 
            // lblCPP
            // 
            this.lblCPP.AutoSize = true;
            this.lblCPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPP.Location = new System.Drawing.Point(19, 209);
            this.lblCPP.Name = "lblCPP";
            this.lblCPP.Size = new System.Drawing.Size(43, 17);
            this.lblCPP.TabIndex = 11;
            this.lblCPP.Text = "CPP:";
            // 
            // txtCPP
            // 
            this.txtCPP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPP.ForeColor = System.Drawing.Color.Red;
            this.txtCPP.Location = new System.Drawing.Point(74, 206);
            this.txtCPP.Name = "txtCPP";
            this.txtCPP.ReadOnly = true;
            this.txtCPP.Size = new System.Drawing.Size(319, 22);
            this.txtCPP.TabIndex = 10;
            this.txtCPP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtCPP_MouseMove);
            // 
            // lblTOS
            // 
            this.lblTOS.AutoSize = true;
            this.lblTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOS.Location = new System.Drawing.Point(19, 237);
            this.lblTOS.Name = "lblTOS";
            this.lblTOS.Size = new System.Drawing.Size(45, 17);
            this.lblTOS.TabIndex = 13;
            this.lblTOS.Text = "TOS:";
            // 
            // txtTOS
            // 
            this.txtTOS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOS.ForeColor = System.Drawing.Color.Red;
            this.txtTOS.Location = new System.Drawing.Point(74, 234);
            this.txtTOS.Name = "txtTOS";
            this.txtTOS.ReadOnly = true;
            this.txtTOS.Size = new System.Drawing.Size(319, 22);
            this.txtTOS.TabIndex = 12;
            this.txtTOS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtTOS_MouseMove);
            // 
            // lblOPC
            // 
            this.lblOPC.AutoSize = true;
            this.lblOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPC.Location = new System.Drawing.Point(19, 265);
            this.lblOPC.Name = "lblOPC";
            this.lblOPC.Size = new System.Drawing.Size(45, 17);
            this.lblOPC.TabIndex = 15;
            this.lblOPC.Text = "OPC:";
            // 
            // txtOPC
            // 
            this.txtOPC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPC.ForeColor = System.Drawing.Color.Red;
            this.txtOPC.Location = new System.Drawing.Point(74, 262);
            this.txtOPC.Name = "txtOPC";
            this.txtOPC.ReadOnly = true;
            this.txtOPC.Size = new System.Drawing.Size(319, 22);
            this.txtOPC.TabIndex = 14;
            this.txtOPC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOPC_MouseMove);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(19, 293);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(24, 17);
            this.lblH.TabIndex = 17;
            this.lblH.Text = "H:";
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.ForeColor = System.Drawing.Color.Red;
            this.txtH.Location = new System.Drawing.Point(74, 290);
            this.txtH.Name = "txtH";
            this.txtH.ReadOnly = true;
            this.txtH.Size = new System.Drawing.Size(319, 22);
            this.txtH.TabIndex = 16;
            this.txtH.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtH_MouseMove);
            // 
            // lblRegistri
            // 
            this.lblRegistri.AutoSize = true;
            this.lblRegistri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistri.Location = new System.Drawing.Point(19, 9);
            this.lblRegistri.Name = "lblRegistri";
            this.lblRegistri.Size = new System.Drawing.Size(64, 17);
            this.lblRegistri.TabIndex = 18;
            this.lblRegistri.Text = "Registri";
            // 
            // lstMemoriaCentrale
            // 
            this.lstMemoriaCentrale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMemoriaCentrale.ForeColor = System.Drawing.Color.Red;
            this.lstMemoriaCentrale.HideSelection = false;
            this.lstMemoriaCentrale.Location = new System.Drawing.Point(452, 41);
            this.lstMemoriaCentrale.Name = "lstMemoriaCentrale";
            this.lstMemoriaCentrale.Size = new System.Drawing.Size(590, 242);
            this.lstMemoriaCentrale.TabIndex = 19;
            this.lstMemoriaCentrale.UseCompatibleStateImageBehavior = false;
            this.lstMemoriaCentrale.View = System.Windows.Forms.View.Details;
            this.lstMemoriaCentrale.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Indirizzo";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valore";
            this.columnHeader2.Width = 280;
            // 
            // lblMemoriaCentrale
            // 
            this.lblMemoriaCentrale.AutoSize = true;
            this.lblMemoriaCentrale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoriaCentrale.Location = new System.Drawing.Point(449, 21);
            this.lblMemoriaCentrale.Name = "lblMemoriaCentrale";
            this.lblMemoriaCentrale.Size = new System.Drawing.Size(135, 17);
            this.lblMemoriaCentrale.TabIndex = 20;
            this.lblMemoriaCentrale.Text = "Memoria Centrale";
            // 
            // lblMemoriaControllo
            // 
            this.lblMemoriaControllo.AutoSize = true;
            this.lblMemoriaControllo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoriaControllo.Location = new System.Drawing.Point(19, 337);
            this.lblMemoriaControllo.Name = "lblMemoriaControllo";
            this.lblMemoriaControllo.Size = new System.Drawing.Size(157, 17);
            this.lblMemoriaControllo.TabIndex = 22;
            this.lblMemoriaControllo.Text = "Memoria di Controllo";
            // 
            // lstMemoriaControllo
            // 
            this.lstMemoriaControllo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstMemoriaControllo.ForeColor = System.Drawing.Color.Red;
            this.lstMemoriaControllo.HideSelection = false;
            this.lstMemoriaControllo.Location = new System.Drawing.Point(22, 357);
            this.lstMemoriaControllo.Name = "lstMemoriaControllo";
            this.lstMemoriaControllo.Size = new System.Drawing.Size(590, 242);
            this.lstMemoriaControllo.TabIndex = 21;
            this.lstMemoriaControllo.UseCompatibleStateImageBehavior = false;
            this.lstMemoriaControllo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Indirizzo";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valore";
            this.columnHeader4.Width = 280;
            // 
            // lblBusBop
            // 
            this.lblBusBop.AutoSize = true;
            this.lblBusBop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusBop.Location = new System.Drawing.Point(631, 364);
            this.lblBusBop.Name = "lblBusBop";
            this.lblBusBop.Size = new System.Drawing.Size(97, 17);
            this.lblBusBop.TabIndex = 24;
            this.lblBusBop.Text = "Operazione:";
            // 
            // txtBusBop
            // 
            this.txtBusBop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBusBop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusBop.ForeColor = System.Drawing.Color.Red;
            this.txtBusBop.Location = new System.Drawing.Point(734, 364);
            this.txtBusBop.Name = "txtBusBop";
            this.txtBusBop.ReadOnly = true;
            this.txtBusBop.Size = new System.Drawing.Size(137, 22);
            this.txtBusBop.TabIndex = 23;
            this.txtBusBop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBusBop_MouseMove);
            // 
            // lblBusBdato
            // 
            this.lblBusBdato.AutoSize = true;
            this.lblBusBdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusBdato.Location = new System.Drawing.Point(681, 402);
            this.lblBusBdato.Name = "lblBusBdato";
            this.lblBusBdato.Size = new System.Drawing.Size(47, 17);
            this.lblBusBdato.TabIndex = 26;
            this.lblBusBdato.Text = "Dato:";
            // 
            // txtBusBdato
            // 
            this.txtBusBdato.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBusBdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusBdato.ForeColor = System.Drawing.Color.Red;
            this.txtBusBdato.Location = new System.Drawing.Point(734, 402);
            this.txtBusBdato.Name = "txtBusBdato";
            this.txtBusBdato.ReadOnly = true;
            this.txtBusBdato.Size = new System.Drawing.Size(308, 22);
            this.txtBusBdato.TabIndex = 25;
            this.txtBusBdato.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBusBdato_MouseMove);
            // 
            // lblBusCdato
            // 
            this.lblBusCdato.AutoSize = true;
            this.lblBusCdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusCdato.Location = new System.Drawing.Point(681, 513);
            this.lblBusCdato.Name = "lblBusCdato";
            this.lblBusCdato.Size = new System.Drawing.Size(47, 17);
            this.lblBusCdato.TabIndex = 30;
            this.lblBusCdato.Text = "Dato:";
            // 
            // txtBusCdato
            // 
            this.txtBusCdato.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBusCdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusCdato.ForeColor = System.Drawing.Color.Red;
            this.txtBusCdato.Location = new System.Drawing.Point(734, 513);
            this.txtBusCdato.Name = "txtBusCdato";
            this.txtBusCdato.ReadOnly = true;
            this.txtBusCdato.Size = new System.Drawing.Size(308, 22);
            this.txtBusCdato.TabIndex = 29;
            this.txtBusCdato.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBusCdato_MouseMove);
            // 
            // lblBusCop
            // 
            this.lblBusCop.AutoSize = true;
            this.lblBusCop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusCop.Location = new System.Drawing.Point(631, 475);
            this.lblBusCop.Name = "lblBusCop";
            this.lblBusCop.Size = new System.Drawing.Size(97, 17);
            this.lblBusCop.TabIndex = 28;
            this.lblBusCop.Text = "Operazione:";
            // 
            // txtBusCop
            // 
            this.txtBusCop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBusCop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusCop.ForeColor = System.Drawing.Color.Red;
            this.txtBusCop.Location = new System.Drawing.Point(734, 475);
            this.txtBusCop.Name = "txtBusCop";
            this.txtBusCop.ReadOnly = true;
            this.txtBusCop.Size = new System.Drawing.Size(137, 22);
            this.txtBusCop.TabIndex = 27;
            this.txtBusCop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBusCop_MouseMove);
            // 
            // lblBusB
            // 
            this.lblBusB.AutoSize = true;
            this.lblBusB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusB.Location = new System.Drawing.Point(734, 337);
            this.lblBusB.Name = "lblBusB";
            this.lblBusB.Size = new System.Drawing.Size(50, 17);
            this.lblBusB.TabIndex = 31;
            this.lblBusB.Text = "Bus B";
            // 
            // lblBusC
            // 
            this.lblBusC.AutoSize = true;
            this.lblBusC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusC.Location = new System.Drawing.Point(734, 451);
            this.lblBusC.Name = "lblBusC";
            this.lblBusC.Size = new System.Drawing.Size(50, 17);
            this.lblBusC.TabIndex = 32;
            this.lblBusC.Text = "Bus C";
            // 
            // lblOpALU
            // 
            this.lblOpALU.AutoSize = true;
            this.lblOpALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpALU.Location = new System.Drawing.Point(1091, 77);
            this.lblOpALU.Name = "lblOpALU";
            this.lblOpALU.Size = new System.Drawing.Size(97, 17);
            this.lblOpALU.TabIndex = 34;
            this.lblOpALU.Text = "Operazione:";
            // 
            // txtOpALU
            // 
            this.txtOpALU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOpALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpALU.ForeColor = System.Drawing.Color.Red;
            this.txtOpALU.Location = new System.Drawing.Point(1199, 71);
            this.txtOpALU.Name = "txtOpALU";
            this.txtOpALU.ReadOnly = true;
            this.txtOpALU.Size = new System.Drawing.Size(310, 22);
            this.txtOpALU.TabIndex = 33;
            this.txtOpALU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOpALU_MouseMove);
            // 
            // lblOperand_A_ALU
            // 
            this.lblOperand_A_ALU.AutoSize = true;
            this.lblOperand_A_ALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand_A_ALU.Location = new System.Drawing.Point(1091, 105);
            this.lblOperand_A_ALU.Name = "lblOperand_A_ALU";
            this.lblOperand_A_ALU.Size = new System.Drawing.Size(100, 17);
            this.lblOperand_A_ALU.TabIndex = 36;
            this.lblOperand_A_ALU.Text = "Operando A:";
            this.lblOperand_A_ALU.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOperand_A_ALU
            // 
            this.txtOperand_A_ALU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOperand_A_ALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand_A_ALU.ForeColor = System.Drawing.Color.Red;
            this.txtOperand_A_ALU.Location = new System.Drawing.Point(1199, 99);
            this.txtOperand_A_ALU.Name = "txtOperand_A_ALU";
            this.txtOperand_A_ALU.ReadOnly = true;
            this.txtOperand_A_ALU.Size = new System.Drawing.Size(310, 22);
            this.txtOperand_A_ALU.TabIndex = 35;
            this.txtOperand_A_ALU.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtOperand_A_ALU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOperand_A_ALU_MouseMove);
            // 
            // lblOperand_B_ALU
            // 
            this.lblOperand_B_ALU.AutoSize = true;
            this.lblOperand_B_ALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand_B_ALU.Location = new System.Drawing.Point(1091, 133);
            this.lblOperand_B_ALU.Name = "lblOperand_B_ALU";
            this.lblOperand_B_ALU.Size = new System.Drawing.Size(100, 17);
            this.lblOperand_B_ALU.TabIndex = 38;
            this.lblOperand_B_ALU.Text = "Operando B:";
            // 
            // txtOperand_B_ALU
            // 
            this.txtOperand_B_ALU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOperand_B_ALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand_B_ALU.ForeColor = System.Drawing.Color.Red;
            this.txtOperand_B_ALU.Location = new System.Drawing.Point(1199, 127);
            this.txtOperand_B_ALU.Name = "txtOperand_B_ALU";
            this.txtOperand_B_ALU.ReadOnly = true;
            this.txtOperand_B_ALU.Size = new System.Drawing.Size(310, 22);
            this.txtOperand_B_ALU.TabIndex = 37;
            this.txtOperand_B_ALU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOperand_B_ALU_MouseMove);
            // 
            // lblRisultatoALU
            // 
            this.lblRisultatoALU.AutoSize = true;
            this.lblRisultatoALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultatoALU.Location = new System.Drawing.Point(1114, 161);
            this.lblRisultatoALU.Name = "lblRisultatoALU";
            this.lblRisultatoALU.Size = new System.Drawing.Size(77, 17);
            this.lblRisultatoALU.TabIndex = 40;
            this.lblRisultatoALU.Text = "Risultato:";
            // 
            // txtRisultatoALU
            // 
            this.txtRisultatoALU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRisultatoALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRisultatoALU.ForeColor = System.Drawing.Color.Red;
            this.txtRisultatoALU.Location = new System.Drawing.Point(1199, 155);
            this.txtRisultatoALU.Name = "txtRisultatoALU";
            this.txtRisultatoALU.ReadOnly = true;
            this.txtRisultatoALU.Size = new System.Drawing.Size(310, 22);
            this.txtRisultatoALU.TabIndex = 39;
            this.txtRisultatoALU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtRisultatoALU_MouseMove);
            // 
            // lblNflagALU
            // 
            this.lblNflagALU.AutoSize = true;
            this.lblNflagALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNflagALU.Location = new System.Drawing.Point(1083, 192);
            this.lblNflagALU.Name = "lblNflagALU";
            this.lblNflagALU.Size = new System.Drawing.Size(109, 17);
            this.lblNflagALU.TabIndex = 42;
            this.lblNflagALU.Text = "Negative flag:";
            // 
            // txtNflagALU
            // 
            this.txtNflagALU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNflagALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNflagALU.ForeColor = System.Drawing.Color.Red;
            this.txtNflagALU.Location = new System.Drawing.Point(1199, 186);
            this.txtNflagALU.Name = "txtNflagALU";
            this.txtNflagALU.ReadOnly = true;
            this.txtNflagALU.Size = new System.Drawing.Size(137, 22);
            this.txtNflagALU.TabIndex = 41;
            // 
            // lblZflagALU
            // 
            this.lblZflagALU.AutoSize = true;
            this.lblZflagALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZflagALU.Location = new System.Drawing.Point(1113, 224);
            this.lblZflagALU.Name = "lblZflagALU";
            this.lblZflagALU.Size = new System.Drawing.Size(79, 17);
            this.lblZflagALU.TabIndex = 44;
            this.lblZflagALU.Text = "Zero flag:";
            // 
            // txtZflagALU
            // 
            this.txtZflagALU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtZflagALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZflagALU.ForeColor = System.Drawing.Color.Red;
            this.txtZflagALU.Location = new System.Drawing.Point(1199, 218);
            this.txtZflagALU.Name = "txtZflagALU";
            this.txtZflagALU.ReadOnly = true;
            this.txtZflagALU.Size = new System.Drawing.Size(137, 22);
            this.txtZflagALU.TabIndex = 43;
            // 
            // lblALU
            // 
            this.lblALU.AutoSize = true;
            this.lblALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALU.Location = new System.Drawing.Point(1196, 38);
            this.lblALU.Name = "lblALU";
            this.lblALU.Size = new System.Drawing.Size(38, 17);
            this.lblALU.TabIndex = 45;
            this.lblALU.Text = "ALU";
            // 
            // lblOpSR
            // 
            this.lblOpSR.AutoSize = true;
            this.lblOpSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpSR.Location = new System.Drawing.Point(1091, 308);
            this.lblOpSR.Name = "lblOpSR";
            this.lblOpSR.Size = new System.Drawing.Size(97, 17);
            this.lblOpSR.TabIndex = 47;
            this.lblOpSR.Text = "Operazione:";
            // 
            // txtOpSR
            // 
            this.txtOpSR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOpSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpSR.ForeColor = System.Drawing.Color.Red;
            this.txtOpSR.Location = new System.Drawing.Point(1199, 302);
            this.txtOpSR.Name = "txtOpSR";
            this.txtOpSR.ReadOnly = true;
            this.txtOpSR.Size = new System.Drawing.Size(310, 22);
            this.txtOpSR.TabIndex = 46;
            this.txtOpSR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOpSR_MouseMove);
            // 
            // lblDatoSR
            // 
            this.lblDatoSR.AutoSize = true;
            this.lblDatoSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoSR.Location = new System.Drawing.Point(1146, 337);
            this.lblDatoSR.Name = "lblDatoSR";
            this.lblDatoSR.Size = new System.Drawing.Size(47, 17);
            this.lblDatoSR.TabIndex = 49;
            this.lblDatoSR.Text = "Dato:";
            // 
            // txtDatoSR
            // 
            this.txtDatoSR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDatoSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoSR.ForeColor = System.Drawing.Color.Red;
            this.txtDatoSR.Location = new System.Drawing.Point(1199, 337);
            this.txtDatoSR.Name = "txtDatoSR";
            this.txtDatoSR.ReadOnly = true;
            this.txtDatoSR.Size = new System.Drawing.Size(308, 22);
            this.txtDatoSR.TabIndex = 48;
            this.txtDatoSR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDatoSR_MouseMove);
            this.txtDatoSR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtDatoSR_MouseUp);
            // 
            // lblSR
            // 
            this.lblSR.AutoSize = true;
            this.lblSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSR.Location = new System.Drawing.Point(1196, 270);
            this.lblSR.Name = "lblSR";
            this.lblSR.Size = new System.Drawing.Size(107, 17);
            this.lblSR.TabIndex = 50;
            this.lblSR.Text = "Shift Register";
            // 
            // lblMBR
            // 
            this.lblMBR.AutoSize = true;
            this.lblMBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMBR.Location = new System.Drawing.Point(19, 153);
            this.lblMBR.Name = "lblMBR";
            this.lblMBR.Size = new System.Drawing.Size(46, 17);
            this.lblMBR.TabIndex = 52;
            this.lblMBR.Text = "MBR:";
            // 
            // txtMBR
            // 
            this.txtMBR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBR.ForeColor = System.Drawing.Color.Red;
            this.txtMBR.Location = new System.Drawing.Point(74, 150);
            this.txtMBR.Name = "txtMBR";
            this.txtMBR.ReadOnly = true;
            this.txtMBR.Size = new System.Drawing.Size(319, 22);
            this.txtMBR.TabIndex = 51;
            this.txtMBR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtMBR_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // cbVisualizzaRegistri
            // 
            this.cbVisualizzaRegistri.AutoSize = true;
            this.cbVisualizzaRegistri.Checked = true;
            this.cbVisualizzaRegistri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisualizzaRegistri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualizzaRegistri.Location = new System.Drawing.Point(107, 7);
            this.cbVisualizzaRegistri.Name = "cbVisualizzaRegistri";
            this.cbVisualizzaRegistri.Size = new System.Drawing.Size(164, 21);
            this.cbVisualizzaRegistri.TabIndex = 53;
            this.cbVisualizzaRegistri.Text = "Visualizza Registri";
            this.cbVisualizzaRegistri.UseVisualStyleBackColor = true;
            this.cbVisualizzaRegistri.CheckedChanged += new System.EventHandler(this.cbVisualizzaRegistri_CheckedChanged);
            // 
            // cbVisualizzaMemoriaCentrale
            // 
            this.cbVisualizzaMemoriaCentrale.AutoSize = true;
            this.cbVisualizzaMemoriaCentrale.Checked = true;
            this.cbVisualizzaMemoriaCentrale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisualizzaMemoriaCentrale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualizzaMemoriaCentrale.Location = new System.Drawing.Point(602, 17);
            this.cbVisualizzaMemoriaCentrale.Name = "cbVisualizzaMemoriaCentrale";
            this.cbVisualizzaMemoriaCentrale.Size = new System.Drawing.Size(235, 21);
            this.cbVisualizzaMemoriaCentrale.TabIndex = 54;
            this.cbVisualizzaMemoriaCentrale.Text = "Visualizza Memoria Centrale";
            this.cbVisualizzaMemoriaCentrale.UseVisualStyleBackColor = true;
            this.cbVisualizzaMemoriaCentrale.CheckedChanged += new System.EventHandler(this.cbVisualizzaMemoriaCentrale_CheckedChanged);
            // 
            // cbVisualizzaMemoriaControllo
            // 
            this.cbVisualizzaMemoriaControllo.AutoSize = true;
            this.cbVisualizzaMemoriaControllo.Checked = true;
            this.cbVisualizzaMemoriaControllo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisualizzaMemoriaControllo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualizzaMemoriaControllo.Location = new System.Drawing.Point(193, 333);
            this.cbVisualizzaMemoriaControllo.Name = "cbVisualizzaMemoriaControllo";
            this.cbVisualizzaMemoriaControllo.Size = new System.Drawing.Size(239, 21);
            this.cbVisualizzaMemoriaControllo.TabIndex = 55;
            this.cbVisualizzaMemoriaControllo.Text = "Visualizza Memoria Controllo";
            this.cbVisualizzaMemoriaControllo.UseVisualStyleBackColor = true;
            this.cbVisualizzaMemoriaControllo.CheckedChanged += new System.EventHandler(this.cbVisualizzaMemoriaControllo_CheckedChanged);
            // 
            // cbVisualizzaBusB
            // 
            this.cbVisualizzaBusB.AutoSize = true;
            this.cbVisualizzaBusB.Checked = true;
            this.cbVisualizzaBusB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisualizzaBusB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualizzaBusB.Location = new System.Drawing.Point(803, 336);
            this.cbVisualizzaBusB.Name = "cbVisualizzaBusB";
            this.cbVisualizzaBusB.Size = new System.Drawing.Size(150, 21);
            this.cbVisualizzaBusB.TabIndex = 56;
            this.cbVisualizzaBusB.Text = "Visualizza Bus B";
            this.cbVisualizzaBusB.UseVisualStyleBackColor = true;
            this.cbVisualizzaBusB.CheckedChanged += new System.EventHandler(this.cbVisualizzaBusB_CheckedChanged);
            // 
            // cbVisualizzaBusC
            // 
            this.cbVisualizzaBusC.AutoSize = true;
            this.cbVisualizzaBusC.Checked = true;
            this.cbVisualizzaBusC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisualizzaBusC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualizzaBusC.Location = new System.Drawing.Point(803, 448);
            this.cbVisualizzaBusC.Name = "cbVisualizzaBusC";
            this.cbVisualizzaBusC.Size = new System.Drawing.Size(150, 21);
            this.cbVisualizzaBusC.TabIndex = 57;
            this.cbVisualizzaBusC.Text = "Visualizza Bus C";
            this.cbVisualizzaBusC.UseVisualStyleBackColor = true;
            this.cbVisualizzaBusC.CheckedChanged += new System.EventHandler(this.cbVisualizzaBusC_CheckedChanged);
            // 
            // cbVisualizzaSR
            // 
            this.cbVisualizzaSR.AutoSize = true;
            this.cbVisualizzaSR.Checked = true;
            this.cbVisualizzaSR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisualizzaSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualizzaSR.Location = new System.Drawing.Point(1322, 270);
            this.cbVisualizzaSR.Name = "cbVisualizzaSR";
            this.cbVisualizzaSR.Size = new System.Drawing.Size(207, 21);
            this.cbVisualizzaSR.TabIndex = 58;
            this.cbVisualizzaSR.Text = "Visualizza Shift Register";
            this.cbVisualizzaSR.UseVisualStyleBackColor = true;
            this.cbVisualizzaSR.CheckedChanged += new System.EventHandler(this.cbVisualizzaSR_CheckedChanged);
            // 
            // cbVisualizzaALU
            // 
            this.cbVisualizzaALU.AutoSize = true;
            this.cbVisualizzaALU.Checked = true;
            this.cbVisualizzaALU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisualizzaALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualizzaALU.Location = new System.Drawing.Point(1322, 38);
            this.cbVisualizzaALU.Name = "cbVisualizzaALU";
            this.cbVisualizzaALU.Size = new System.Drawing.Size(138, 21);
            this.cbVisualizzaALU.TabIndex = 59;
            this.cbVisualizzaALU.Text = "Visualizza ALU";
            this.cbVisualizzaALU.UseVisualStyleBackColor = true;
            this.cbVisualizzaALU.CheckedChanged += new System.EventHandler(this.cbVisualizzaALU_CheckedChanged);
            // 
            // BoundVisualizzazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 665);
            this.ControlBox = false;
            this.Controls.Add(this.cbVisualizzaALU);
            this.Controls.Add(this.cbVisualizzaSR);
            this.Controls.Add(this.cbVisualizzaBusC);
            this.Controls.Add(this.cbVisualizzaBusB);
            this.Controls.Add(this.cbVisualizzaMemoriaControllo);
            this.Controls.Add(this.cbVisualizzaMemoriaCentrale);
            this.Controls.Add(this.cbVisualizzaRegistri);
            this.Controls.Add(this.lblMBR);
            this.Controls.Add(this.txtMBR);
            this.Controls.Add(this.lblSR);
            this.Controls.Add(this.lblDatoSR);
            this.Controls.Add(this.txtDatoSR);
            this.Controls.Add(this.lblOpSR);
            this.Controls.Add(this.txtOpSR);
            this.Controls.Add(this.lblALU);
            this.Controls.Add(this.lblZflagALU);
            this.Controls.Add(this.txtZflagALU);
            this.Controls.Add(this.lblNflagALU);
            this.Controls.Add(this.txtNflagALU);
            this.Controls.Add(this.lblRisultatoALU);
            this.Controls.Add(this.txtRisultatoALU);
            this.Controls.Add(this.lblOperand_B_ALU);
            this.Controls.Add(this.txtOperand_B_ALU);
            this.Controls.Add(this.lblOperand_A_ALU);
            this.Controls.Add(this.txtOperand_A_ALU);
            this.Controls.Add(this.lblOpALU);
            this.Controls.Add(this.txtOpALU);
            this.Controls.Add(this.lblBusC);
            this.Controls.Add(this.lblBusB);
            this.Controls.Add(this.lblBusCdato);
            this.Controls.Add(this.txtBusCdato);
            this.Controls.Add(this.lblBusCop);
            this.Controls.Add(this.txtBusCop);
            this.Controls.Add(this.lblBusBdato);
            this.Controls.Add(this.txtBusBdato);
            this.Controls.Add(this.lblBusBop);
            this.Controls.Add(this.txtBusBop);
            this.Controls.Add(this.lblMemoriaControllo);
            this.Controls.Add(this.lstMemoriaControllo);
            this.Controls.Add(this.lblMemoriaCentrale);
            this.Controls.Add(this.lstMemoriaCentrale);
            this.Controls.Add(this.lblRegistri);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblOPC);
            this.Controls.Add(this.txtOPC);
            this.Controls.Add(this.lblTOS);
            this.Controls.Add(this.txtTOS);
            this.Controls.Add(this.lblCPP);
            this.Controls.Add(this.txtCPP);
            this.Controls.Add(this.lblLV);
            this.Controls.Add(this.txtLV);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.lblMDR);
            this.Controls.Add(this.txtMDR);
            this.Controls.Add(this.lblMAR);
            this.Controls.Add(this.txtMAR);
            this.Controls.Add(this.lblSP);
            this.Controls.Add(this.txtSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BoundVisualizzazione";
            this.Text = "Stato Architettura";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoundVisualizzazione_FormClosing);
            this.Load += new System.EventHandler(this.BoundVisualizzazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblMAR;
        private System.Windows.Forms.TextBox txtMAR;
        private System.Windows.Forms.Label lblMDR;
        private System.Windows.Forms.TextBox txtMDR;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label lblLV;
        private System.Windows.Forms.TextBox txtLV;
        private System.Windows.Forms.Label lblCPP;
        private System.Windows.Forms.TextBox txtCPP;
        private System.Windows.Forms.Label lblTOS;
        private System.Windows.Forms.TextBox txtTOS;
        private System.Windows.Forms.Label lblOPC;
        private System.Windows.Forms.TextBox txtOPC;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblRegistri;
        private System.Windows.Forms.ListView lstMemoriaCentrale;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblMemoriaCentrale;
        private System.Windows.Forms.Label lblMemoriaControllo;
        private System.Windows.Forms.ListView lstMemoriaControllo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblBusBop;
        private System.Windows.Forms.TextBox txtBusBop;
        private System.Windows.Forms.Label lblBusBdato;
        private System.Windows.Forms.TextBox txtBusBdato;
        private System.Windows.Forms.Label lblBusCdato;
        private System.Windows.Forms.TextBox txtBusCdato;
        private System.Windows.Forms.Label lblBusCop;
        private System.Windows.Forms.TextBox txtBusCop;
        private System.Windows.Forms.Label lblBusB;
        private System.Windows.Forms.Label lblBusC;
        private System.Windows.Forms.Label lblOpALU;
        private System.Windows.Forms.TextBox txtOpALU;
        private System.Windows.Forms.Label lblOperand_A_ALU;
        private System.Windows.Forms.TextBox txtOperand_A_ALU;
        private System.Windows.Forms.Label lblOperand_B_ALU;
        private System.Windows.Forms.TextBox txtOperand_B_ALU;
        private System.Windows.Forms.Label lblRisultatoALU;
        private System.Windows.Forms.TextBox txtRisultatoALU;
        private System.Windows.Forms.Label lblNflagALU;
        private System.Windows.Forms.TextBox txtNflagALU;
        private System.Windows.Forms.Label lblZflagALU;
        private System.Windows.Forms.TextBox txtZflagALU;
        private System.Windows.Forms.Label lblALU;
        private System.Windows.Forms.Label lblOpSR;
        private System.Windows.Forms.TextBox txtOpSR;
        private System.Windows.Forms.Label lblDatoSR;
        private System.Windows.Forms.TextBox txtDatoSR;
        private System.Windows.Forms.Label lblSR;
        private System.Windows.Forms.Label lblMBR;
        private System.Windows.Forms.TextBox txtMBR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbVisualizzaRegistri;
        private System.Windows.Forms.CheckBox cbVisualizzaMemoriaCentrale;
        private System.Windows.Forms.CheckBox cbVisualizzaMemoriaControllo;
        private System.Windows.Forms.CheckBox cbVisualizzaBusB;
        private System.Windows.Forms.CheckBox cbVisualizzaBusC;
        private System.Windows.Forms.CheckBox cbVisualizzaSR;
        private System.Windows.Forms.CheckBox cbVisualizzaALU;
    }
}