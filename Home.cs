using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University_management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cktu_CheckedChanged(object sender, EventArgs e)
        {
            if (cktu.Checked == true)
            {
                txttu.Enabled = true;
                txttu.Text = "3500";
            }
            if (cktu.Checked == false)
            {
                txttu.Enabled = false;
                txttu.Text = "0";
            }
        }

        private void ckho_CheckedChanged(object sender, EventArgs e)
        {
            if (ckho.Checked == true)
            {
                txtho.Enabled = true;
                txtho.Text = "4500";
            }
            if (ckho.Checked == false)
            {
                txtho.Enabled = false;
                txtho.Text = "0";
            }
        }
        
        private void TOTAL_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtad.Text = "0";
            txttu.Text = "0";
            txtli.Text = "0";
            txtin.Text = "0";
            txtvi.Text = "0";
            txtre.Text = "0";
            txtho.Text = "0";
            txtse.Text = "0";
            txtta.Text = "0";
            tbsub.Text = "0";
            tbto.Text = "0";
            tbsub.Text = "0";
            tbto.Text = "0";
            rtfReceipt.Clear();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

            txtad.Text = "0";
            txttu.Text = "0";
            txtli.Text = "0";
            txtin.Text = "0";
            txtvi.Text = "0";
            txtre.Text = "0";
            txtho.Text = "0";
            txtse.Text = "10";
            txtta.Text = "0";
            tbsub.Text = "0";
            tbto.Text = "0";


            txtad.Enabled = false;
            txttu.Enabled = false;
            txtli.Enabled = false;
            txtin.Enabled = false;
            txtvi.Enabled = false;
            txtre.Enabled = false;
            txtho.Enabled = false;
            txtse.Enabled = false;
            txtta.Enabled = false;
            

            ckad.Checked = false;
            cktu.Checked = false;
            ckli.Checked = false;
            ckin.Checked = false;
            ckvi.Checked = false;
            ckre.Checked = false;
            ckho.Checked = false;
            ckse.Checked = false;
            ckta.Checked = false;
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            rtfReceipt.Clear();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cutToolStripButton_Click_1(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void newToolStripButton_Click_1(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void openToolStripButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }

        }

        private void copyToolStripButton_Click_1(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click_1(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("Tianjin Agricutural University Receipt" + Environment.NewLine);
            rtfReceipt.AppendText("_______________________________" + Environment.NewLine + Environment.NewLine);
            rtfReceipt.AppendText("Admission Fee \t\t" + txtad.Text + Environment.NewLine);
            rtfReceipt.AppendText("Tuition Fee \t\t\t" + txttu.Text + Environment.NewLine);
            rtfReceipt.AppendText("Library Fee \t\t\t" + txtli.Text + Environment.NewLine);
            rtfReceipt.AppendText("Insurance Fee \t\t" + txtin.Text + Environment.NewLine);
            rtfReceipt.AppendText("Visa Fee \t\t\t" + txtvi.Text + Environment.NewLine);
            rtfReceipt.AppendText("Registration Fee \t\t" + txtre.Text + Environment.NewLine);
            rtfReceipt.AppendText("Hostel Fee \t\t\t" + txtho.Text + Environment.NewLine);
            rtfReceipt.AppendText("_______________________________" + Environment.NewLine);
            rtfReceipt.AppendText("Service Charge \t\t" + txtse.Text + Environment.NewLine);
            rtfReceipt.AppendText("_______________________________" + Environment.NewLine);
            rtfReceipt.AppendText("Tax + Vat \t\t\t" + txtta.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub-Total \t\t\t" + tbsub.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total \t\t\t\t" + tbto.Text + Environment.NewLine);
        }

        private void ckad_CheckedChanged(object sender, EventArgs e)
        {
            if (ckad.Checked == true)
            {
                txtad.Enabled = true;
                txtad.Text = "500";
            }
            if (ckad.Checked == false)
            {
                txtad.Enabled = false;
                txtad.Text = "0";
            }
        }

        private void ckli_CheckedChanged(object sender, EventArgs e)
        {
            if (ckli.Checked == true)
            {
                txtli.Enabled = true;
                txtli.Text = "200";
            }
            if (ckli.Checked == false)
            {
                txtli.Enabled = false;
                txtli.Text = "0";
            }
        }

        private void ckin_CheckedChanged(object sender, EventArgs e)
        {
            if (ckin.Checked == true)
            {
                txtin.Enabled = true;
                txtin.Text = "400";
            }
            if (ckin.Checked == false)
            {
                txtin.Enabled = false;
                txtin.Text = "0";
            }
        }

        private void ckvi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckvi.Checked == true)
            {
                txtvi.Enabled = true;
                txtvi.Text = "400";
            }
            if (ckvi.Checked == false)
            {
                txtvi.Enabled = false;
                txtvi.Text = "0";
            }
        }

        private void ckre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckre.Checked == true)
            {
                txtre.Enabled = true;
                txtre.Text = "10";
            }
            if (ckre.Checked == false)
            {
                txtre.Enabled = false;
                txtre.Text = "0";
            }
        }

        private void ckta_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckse_CheckedChanged(object sender, EventArgs e)
        {
            if (ckse.Checked == true)
            {
                txtse.Enabled = true;
                txtre.Text = "10";
            }
            if (ckse.Checked == false)
            {
                txtse.Enabled = false;
                txtse.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            double ad = Convert.ToDouble(txtad.Text);
            double tu = Convert.ToDouble(txttu.Text);
            double li = Convert.ToDouble(txtli.Text);
            double ins = Convert.ToDouble(txtin.Text);
            double vi = Convert.ToDouble(txtvi.Text);
            double re = Convert.ToDouble(txtre.Text);
            double ho = Convert.ToDouble(txtho.Text);
            double ta = Convert.ToDouble(txtta.Text);
            double se = Convert.ToDouble(txtse.Text);

                      
            double cost_of_university = ad + tu + li + ins + vi + re + ho + ta + se ;
            
            Double service_charge = Convert.ToDouble(txtse.Text);

            tbsub.Text = Convert.ToString(cost_of_university + service_charge);
            double tax = (((cost_of_university + service_charge) * 2)) / 100;
            string v = Convert.ToString(tax);
            txtta.Text = v;
            double itax = Convert.ToDouble(txtta.Text);
            tbto.Text = Convert.ToString(cost_of_university + itax + service_charge);

        }

        private void txtho_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsub_TextChanged(object sender, EventArgs e)
        {
           }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
