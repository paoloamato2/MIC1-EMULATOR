using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MIC1_SYS.Emulatore.Controllo;

namespace MIC1_SYS.Emulatore.InterfacciaUtente.BoundVisualizzazione
{
    public partial class BoundVisualizzazione : Form
    {
        public bool Modprogrammatore = false;


        public BoundVisualizzazione()
        {
            InitializeComponent();
        }


        private void BoundVisualizzazione_Load(object sender, EventArgs e)
        {
            foreach (var txt in Controls.OfType<TextBox>())
                txt.Text = "00000000000000000000";

            for (var i = 0; i < 511; i++)
            {
                lstMemoriaCentrale.Items.Add(new ListViewItem(new[]
                    {i.ToString(), "00000000000000000000000000000000"}));

                lstMemoriaControllo.Items.Add(new ListViewItem(new[]
                    {i.ToString(), "000000000000000000000000000000000000"}));
            }

            if (Modprogrammatore) return;
            {
                Size = new Size(1100, 380);
                foreach (var txt in Controls.OfType<TextBox>().Where(x => x.Name != "txtSP"))
                    txt.Hide();
                foreach (var lbl in Controls.OfType<Label>().Where(x => x.Name != "lblSP"))
                    lbl.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void AggiornaBoundVisualizzazione(StatoOttenuto ret)
        {
            CheckForIllegalCrossThreadCalls = false;
            AggiornaStatoMemoriaCentrale(ret);
            AggiornaStatoMemoriaControllo(ret);
            AggiornaStatoUnitàOperativa(ret);
        }

        private void AggiornaStatoUnitàOperativa(StatoOttenuto ret)
        {
            AggiornaStatoBusB(ret);
            AggiornaStatoBusC(ret);
            AggiornaStatoAlu(ret);
            AggiornaStatoShiftRegister(ret);
            AggiornaStatoRegistri(ret);
        }

        private void AggiornaStatoRegistri(StatoOttenuto ret)
        {
            txtMAR.Text = ret.Uoso.Rso.Mar;
            txtMDR.Text = ret.Uoso.Rso.Mdr;
            txtCPP.Text = ret.Uoso.Rso.Cpp;
            txtH.Text = ret.Uoso.Rso.H;
            txtLV.Text = ret.Uoso.Rso.Lv;
            txtOPC.Text = ret.Uoso.Rso.Opc;
            txtPC.Text = ret.Uoso.Rso.Pc;
            txtSP.Text = ret.Uoso.Rso.Sp;
            txtTOS.Text = ret.Uoso.Rso.Tos;
            txtMBR.Text = ret.Uoso.Rso.Mbr;
        }

        private void AggiornaStatoShiftRegister(StatoOttenuto ret)
        {
            txtOpSR.Text = ret.Uoso.Srso.Operation;
            txtDatoSR.Text = ret.Uoso.Srso.Dato;
        }

        private void AggiornaStatoAlu(StatoOttenuto ret)
        {
            txtOpALU.Text = ret.Uoso.Aso.Operation;
            txtOperand_A_ALU.Text = ret.Uoso.Aso.OperandA;
            txtOperand_B_ALU.Text = ret.Uoso.Aso.OperandB;
            txtRisultatoALU.Text = ret.Uoso.Aso.Risultato;
            txtNflagALU.Text = ret.Uoso.Aso.NFlag.ToString();
            txtZflagALU.Text = ret.Uoso.Aso.ZFlag.ToString();
        }

        private void AggiornaStatoBusC(StatoOttenuto ret)
        {
            txtBusCop.Text = ret.Uoso.Bcso.Operation;
            txtBusCdato.Text = ret.Uoso.Bcso.Dato;
        }

        private void AggiornaStatoBusB(StatoOttenuto ret)
        {
            txtBusBop.Text = ret.Uoso.Bbso.Operation;
            txtBusBdato.Text = ret.Uoso.Bbso.Dato;
        }

        private void AggiornaStatoMemoriaControllo(StatoOttenuto ret)
        {
            for (var i = 0; i < 511; i++)
            {
                var value = lstMemoriaControllo.Items[i].SubItems[1].Text;
                var dato = ret.Mcso.Data[i];
                if (dato != value) lstMemoriaControllo.Items[i].SubItems[1].Text = dato;
            }

            //foreach (ListViewItem item in lstMemoriaControllo.Items)
            //{
            //    lstMemoriaControllo.Items.Remove(item);
            //}
            //for (int i = 0; i < 511; i++)
            //{
            //    lstMemoriaControllo.Items.Add(new ListViewItem(new string[] {i.ToString(), ret.Mcso.Data[i]}));
            //}
        }

        private void AggiornaStatoMemoriaCentrale(StatoOttenuto ret)
        {
            for (var i = 0; i < 511; i++)
            {
                var value = lstMemoriaCentrale.Items[i].SubItems[1].Text;
                var dato = ret.Ramso.Data[i];
                if (dato != value) lstMemoriaCentrale.Items[i].SubItems[1].Text = dato;
            }

            //lstMemoriaCentrale.Items.Clear();


            //for (int i = 0; i < 511; i++)
            //{
            //    lstMemoriaCentrale.Items.Add(new ListViewItem(new string[] { i.ToString(), ret.Ramso.Data[i] }));
            //}
        }

        private void BoundVisualizzazione_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void txtSP_TextChanged(object sender, EventArgs e)
        {
            var indirizzo = Convert.ToInt32(txtSP.Text, 2);

            for (var index = 0; index < lstMemoriaCentrale.Items.Count; index++)
            {
                var item = lstMemoriaCentrale.Items[index];
                if (!item.Font.Bold) continue;
                item.Font = new Font(item.Font, FontStyle.Regular);
                lstMemoriaCentrale.Items[index] = item;
                lstMemoriaCentrale.Items[index].Selected = false;
                lstMemoriaCentrale.Select();
            }

            for (var index = 0; index < lstMemoriaCentrale.Items.Count; index++)
            {
                var item = lstMemoriaCentrale.Items[index];
                if (item.SubItems[0].Text != indirizzo.ToString()) continue;
                item.Font = new Font(item.Font, FontStyle.Bold);
                lstMemoriaCentrale.Items[index] = item;
                lstMemoriaCentrale.Items[index].Selected = true;
                lstMemoriaCentrale.Select();
                lstMemoriaCentrale.EnsureVisible(index);
            }
        }

        private void txtSP_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtSP.Text, 2);
            toolTip1.SetToolTip(txtSP, testo);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
        }

        private void txtMAR_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtMAR.Text, 2);
            toolTip1.SetToolTip(txtMAR, testo);
        }

        private void txtMDR_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtMDR.Text, 2);
            toolTip1.SetToolTip(txtMDR, testo);
        }

        private void txtPC_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtPC.Text, 2);
            toolTip1.SetToolTip(txtPC, testo);
        }

        private void txtMBR_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtMBR.Text, 2);
            toolTip1.SetToolTip(txtMBR, testo);
        }

        private void txtLV_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtLV.Text, 2);
            toolTip1.SetToolTip(txtLV, testo);
        }

        private void txtCPP_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtCPP.Text, 2);
            toolTip1.SetToolTip(txtCPP, testo);
        }

        private void txtTOS_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtTOS.Text, 2);
            toolTip1.SetToolTip(txtTOS, testo);
        }

        private void txtOPC_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtOPC.Text, 2);
            toolTip1.SetToolTip(txtOPC, testo);
        }

        private void txtH_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtH.Text, 2);
            toolTip1.SetToolTip(txtH, testo);
        }

        private void txtOperand_A_ALU_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtOperand_A_ALU.Text, 2);
            toolTip1.SetToolTip(txtOperand_A_ALU, testo);
        }

        private void txtOperand_B_ALU_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtOperand_B_ALU.Text, 2);
            toolTip1.SetToolTip(txtOperand_B_ALU, testo);
        }

        private void txtRisultatoALU_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtRisultatoALU.Text, 2);
            toolTip1.SetToolTip(txtRisultatoALU, testo);
        }

        private void txtDatoSR_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void txtDatoSR_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtDatoSR.Text, 2);
            toolTip1.SetToolTip(txtDatoSR, testo);
        }

        private void txtBusBdato_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtBusBdato.Text, 2);
            toolTip1.SetToolTip(txtBusBdato, testo);
        }

        private void txtBusCdato_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Valore decimale: " + Convert.ToInt32(txtBusCdato.Text, 2);
            toolTip1.SetToolTip(txtBusCdato, testo);
        }

        private void txtBusBop_MouseMove(object sender, MouseEventArgs e)
        {
            var operation = Convert.ToInt32(txtBusBop.Text, 2);
            var testo = "Sul BUS B è stato scritto il valore del registro ";
            switch (operation)
            {
                case 0:
                    testo += "MDR";
                    break;
                case 1:
                    testo += "PC";
                    break;
                case 2:
                    testo += "MBR";
                    break;
                case 3:
                    testo += "MBRU";
                    break;
                case 4:
                    testo += "SP";
                    break;
                case 5:
                    testo += "LV";
                    break;
                case 6:
                    testo += "CPP";
                    break;
                case 7:
                    testo += "TOS";
                    break;
                case 8:
                    testo += "OPC";
                    break;
                default:
                    testo = "Nessun registro ha scritto sul BUS B";
                    break;
            }

            toolTip1.SetToolTip(txtBusBop, testo);
        }

        private void txtBusCop_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = "Il BUS C ha scritto nei seguenti registri:\n";
            if (txtBusCop.Text[0] == '1') testo += "\u2611H\n";
            if (txtBusCop.Text[1] == '1') testo += "\u2611OPC\n";
            if (txtBusCop.Text[2] == '1') testo += "\u2611TOS\n";
            if (txtBusCop.Text[3] == '1') testo += "\u2611CPP\n";
            if (txtBusCop.Text[4] == '1') testo += "\u2611LV\n";
            if (txtBusCop.Text[5] == '1') testo += "\u2611SP\n";
            if (txtBusCop.Text[6] == '1') testo += "\u2611PC\n";
            if (txtBusCop.Text[7] == '1') testo += "\u2611MDR\n";
            if (txtBusCop.Text[8] == '1') testo += "\u2611MAR\n";

            if (testo == "Il BUS C ha scritto nei seguenti registri:\n")
                testo = "Il BUS C non ha scritto in nessun registro";
            toolTip1.SetToolTip(txtBusCop, testo);
        }

        private void txtOpSR_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = txtOpSR.Text switch
            {
                "10" => "Scorrimento logico a sinistra di 8 bit",
                "01" => "Scorrimento aritmetico a destra di 1 bit",
                _ => "Nessuna operazione: il dato di ingresso passa in uscita inalterato"
            };
            toolTip1.SetToolTip(txtOpSR, testo);
        }

        private void txtOpALU_MouseMove(object sender, MouseEventArgs e)
        {
            var testo = txtOpALU.Text switch
            {
                "011000" => "In uscita viene fornito l'operando A",
                "010100" => "In uscita viene fornito l'operando B",
                "011010" => "In uscita viene fornito l'operando A negato",
                "101100" => "In uscita viene fornito l'operando B negato",
                "111100" => "In uscita viene fornito A+B",
                "111101" => "In uscita viene fornito A+B+1",
                "111001" => "In uscita viene fornito A+1",
                "110101" => "In uscita viene fornito B+1",
                "111111" => "In uscita viene fornito B-A",
                "110110" => "In uscita viene fornito B-1",
                "111011" => "In uscita viene fornito -A",
                "001100" => "In uscita viene fornito A AND B",
                "011100" => "In uscita viene fornito A OR B",
                "010000" => "In uscita viene fornito 0",
                "110001" => "In uscita viene fornito 1",
                "110010" => "In uscita viene fornito -1",
                _ => ""
            };
            toolTip1.SetToolTip(txtOpALU, testo);
        }

        private void cbVisualizzaRegistri_CheckedChanged(object sender, EventArgs e)
        {
            lblRegistri.Visible = !lblRegistri.Visible;
            lblSP.Visible = !lblSP.Visible;
            lblMAR.Visible = !lblMAR.Visible;
            lblMDR.Visible = !lblMDR.Visible;
            lblPC.Visible = !lblPC.Visible;
            lblMBR.Visible = !lblMBR.Visible;
            lblLV.Visible = !lblLV.Visible;
            lblCPP.Visible = !lblCPP.Visible;
            lblTOS.Visible = !lblTOS.Visible;
            lblOPC.Visible = !lblOPC.Visible;
            lblH.Visible = !lblH.Visible;
            txtSP.Visible = !txtSP.Visible;
            txtMAR.Visible = !txtMAR.Visible;
            txtMDR.Visible = !txtMDR.Visible;
            txtPC.Visible = !txtPC.Visible;
            txtMBR.Visible = !txtMBR.Visible;
            txtLV.Visible = !txtLV.Visible;
            txtCPP.Visible = !txtCPP.Visible;
            txtTOS.Visible = !txtTOS.Visible;
            txtOPC.Visible = !txtOPC.Visible;
            txtH.Visible = !txtH.Visible;
        }

        private void cbVisualizzaMemoriaCentrale_CheckedChanged(object sender, EventArgs e)
        {
            lblMemoriaCentrale.Visible = !lblMemoriaCentrale.Visible;
            lstMemoriaCentrale.Visible = !lstMemoriaCentrale.Visible;
        }

        private void cbVisualizzaMemoriaControllo_CheckedChanged(object sender, EventArgs e)
        {
            lblMemoriaControllo.Visible = !lblMemoriaControllo.Visible;
            lstMemoriaControllo.Visible = !lstMemoriaControllo.Visible;
        }

        private void cbVisualizzaBusB_CheckedChanged(object sender, EventArgs e)
        {
            lblBusB.Visible = !lblBusB.Visible;
            lblBusBdato.Visible = !lblBusBdato.Visible;
            lblBusBop.Visible = !lblBusBop.Visible;
            txtBusBdato.Visible = !txtBusBdato.Visible;
            txtBusBop.Visible = !txtBusBop.Visible;
        }

        private void cbVisualizzaBusC_CheckedChanged(object sender, EventArgs e)
        {
            lblBusC.Visible = !lblBusC.Visible;
            lblBusCdato.Visible = !lblBusCdato.Visible;
            lblBusCop.Visible = !lblBusCop.Visible;
            txtBusCdato.Visible = !txtBusCdato.Visible;
            txtBusCop.Visible = !txtBusCop.Visible;
        }

        private void cbVisualizzaSR_CheckedChanged(object sender, EventArgs e)
        {
            lblSR.Visible = !lblSR.Visible;
            lblOpSR.Visible = !lblOpSR.Visible;
            lblDatoSR.Visible = !lblDatoSR.Visible;
            txtOpSR.Visible = !txtOpSR.Visible;
            txtDatoSR.Visible = !txtDatoSR.Visible;
        }

        private void cbVisualizzaALU_CheckedChanged(object sender, EventArgs e)
        {
            lblALU.Visible = !lblALU.Visible;
            lblOpALU.Visible = !lblOpALU.Visible;
            lblOperand_A_ALU.Visible = !lblOperand_A_ALU.Visible;
            lblOperand_B_ALU.Visible = !lblOperand_B_ALU.Visible;
            lblNflagALU.Visible = !lblNflagALU.Visible;
            lblZflagALU.Visible = !lblZflagALU.Visible;
            lblRisultatoALU.Visible = !lblRisultatoALU.Visible;
            txtOpALU.Visible = !txtOpALU.Visible;
            txtOperand_A_ALU.Visible = !txtOperand_A_ALU.Visible;
            txtOperand_B_ALU.Visible = !txtOperand_B_ALU.Visible;
            txtNflagALU.Visible = !txtNflagALU.Visible;
            txtRisultatoALU.Visible = !txtRisultatoALU.Visible;
            txtZflagALU.Visible = !txtZflagALU.Visible;
        }
    }
}