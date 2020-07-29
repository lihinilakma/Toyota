using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to clear entered contents?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmReport frmReport = new frmReport();
                frmReport.Show();
            }
            else
            { } 
        }

        private void exitApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { } 
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginscreen loginscreen = new loginscreen();
            loginscreen.Show();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.enquirer_information' table. You can move, or remove it, as needed.
            this.enquirer_informationTableAdapter.Fill(this.dataSet1.enquirer_information);

            //this.reportViewer1.RefreshReport();


            btnAnalyzeFeedback.Size = new Size(147, 153);

          //  new Size(147, 153);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnVehicleOrdersTaken_Click(object sender, EventArgs e)
        {
            CrystalReportsFolder.VehicleOrdersTaken EnquirerFollowup = new CrystalReportsFolder.VehicleOrdersTaken();
            EnquirerFollowup.Show();
        }

        private void btnAnalyzeFeedback_Click(object sender, EventArgs e)
        {
            CrystalReportsFolder.FeedbackAnalyze FeedbackAnalyze = new CrystalReportsFolder.FeedbackAnalyze();
            FeedbackAnalyze.Show();
        }

        private void btnGenerateQuotation_Click(object sender, EventArgs e)
        {
            QuotationCrystalReport QuotationCrystalReport = new QuotationCrystalReport();
            QuotationCrystalReport.Show();
        }

        private void btnEnquirerFollowup_Click(object sender, EventArgs e)
        {
            CrystalReportsFolder.EnquirerFollowup EnquirerFollowup = new CrystalReportsFolder.EnquirerFollowup();
            EnquirerFollowup.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
