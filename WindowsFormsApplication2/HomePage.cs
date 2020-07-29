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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }


        private void btnHomeCustomerFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerFeedback frmCustomerFeedback = new frmCustomerFeedback();
            frmCustomerFeedback.Show();
        }

        private void btnHomeSalesStaffDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesRepresentative frmSalesRepresentative = new frmSalesRepresentative();
            frmSalesRepresentative.Show();
        }

        private void btnHomeSalesEnquiry_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnquirerInformation frmEnquirerInformation = new frmEnquirerInformation();
            frmEnquirerInformation.Show();
            
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            lblHomepageWelcome.Text = "Welcome " + loginscreen.SetValueForText1;




        }

        private void btnHomeGenerateQuotation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuotation frmQuotation = new frmQuotation();
            frmQuotation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReport frmReport = new frmReport();
            frmReport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmVisitDetails frmVisitDetails = new frmVisitDetails();
            frmVisitDetails.Show();
        }

        private void pictureBox2222_Click(object sender, EventArgs e)
        {

        }

        private void lblHomepageWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuotationCrystalReport QuotationCrystalReport = new QuotationCrystalReport();
            QuotationCrystalReport.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
