using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class frmCustomerFeedback : Form
    {
        SqlConnection conn = null;
        public frmCustomerFeedback()
        {
            InitializeComponent();
            conn = DbConnection.getConnection();
        }

        private void txtEnqAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCustomerFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.enquirer_information2' table. You can move, or remove it, as needed.
            this.enquirer_information2TableAdapter.Fill(this.dataSet3.enquirer_information2);
            btnFeedbackFind.Location = new Point(425, 234);
            // TODO: This line of code loads data into the 'dataSet1.enquirer_information' table. You can move, or remove it, as needed.
            this.enquirer_informationTableAdapter.Fill(this.dataSet1.enquirer_information);
            txtFeedbackEnquirerID.ResetText();
            txtFeedbackEnquirerID.ResetText();
            btnFeedbackFind.Location = new Point(425, 234);
            btnFeedbackFind.Location = new Point(425, 234);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to clear entered contents?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmCustomerFeedback frmCustomerFeedback = new frmCustomerFeedback();
                frmCustomerFeedback.Show();
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

        private void btnFeedbackSave_Click(object sender, EventArgs e)
        {

        }

        private void btnFeedbackSave_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnFeedbackFind_Click(object sender, EventArgs e)
        {
            try
            {
            string enquirerid = txtFeedbackEnquirerID.Text;
            FeedbackDBO fdbo = new FeedbackDBO();
            Feedback feedback = fdbo.findFeedback(enquirerid);

            txtFeedbackFeedbackID.Text = feedback.getFeedbackID();
            txtFeedbackCustName.Text = feedback.getCustomerName();
            cmbboxFeedbackLeadSource.Text = feedback.getLeadSource();
            string SatisfactionRating=feedback.getSatisfactionRating();
            if (SatisfactionRating == "Excellent") { rdobtnFeedbackExcellent.Checked = true; } else if (SatisfactionRating == "Neutral") { rdobtnFeedbackNeutral.Checked = true; } else if (SatisfactionRating == "Poor") { rdobtnFeedbackPoor.Checked = true; } else if (SatisfactionRating == "Very Poor") { rdobtnFeedbackVeryPoor.Checked = true; }
            string OnTimeDelivery= feedback.getOnTimeDelivery();
            if (OnTimeDelivery == "No") { rdobtnFeedbackNo.Checked = true; } else if (OnTimeDelivery == "Yes") { rdobtnFeedbackYes.Checked = true; } 
            string ImportantElements = feedback.getImportantElements();
            if (ImportantElements.Contains("Price")) { chkboxFeedbackPrice.Checked = true; } else { chkboxFeedbackPrice.Checked = false; };
            if (ImportantElements.Contains("Fuel")) { chkboxFeedbackFuelConsumption.Checked = true; } else { chkboxFeedbackFuelConsumption.Checked = false; };
            if (ImportantElements.Contains("Brand")) { chkboxFeedbackBrandName.Checked = true; } else { chkboxFeedbackBrandName.Checked = false; };
            if (ImportantElements.Contains("Interior")) { chkboxInteriorAndComfort.Checked = true; } else { chkboxInteriorAndComfort.Checked = false; };
            if (ImportantElements.Contains("Service")) { chkboxFeedbackAfterSalesService.Checked = true; } else { chkboxFeedbackAfterSalesService.Checked = false; };
            if (ImportantElements.Contains("Maintenance")) { chkboxFeedbackMaintenanceCost.Checked = true; } else { chkboxFeedbackMaintenanceCost.Checked = false; };
            if (ImportantElements.Contains("Safety")) { chkboxFeedbackSafetyAndReliability.Checked = true; } else { chkboxFeedbackSafetyAndReliability.Checked = false; };
            if (ImportantElements.Contains("Exterior")) { chkboxFeedbackxteriorDesign.Checked = true; } else { chkboxFeedbackxteriorDesign.Checked = false; };
            txtFeedbackOtherFeedbackForImprovements.Text = feedback.getOtherFeedback();


        }
     catch (Exception ex)
            {
                MessageBox.Show("Couldn't find any feedback records of such a Sales Enquirer.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFeedbackUpdate_Click(object sender, EventArgs e)
        {
           

        }

        private void txtFeedbackEnquirerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string enquirerid = txtFeedbackEnquirerID.Text;
                FeedbackDBO fdbo = new FeedbackDBO();
                Feedback feedback = fdbo.findFeedback2(enquirerid);
                txtFeedbackCustName.Text = feedback.getCustomerName();
            }
            catch
            {
                txtFeedbackCustName.Text = "";
            }

        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void chkboxFeedbackPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxFeedbackPrice.Checked == true)
            {

            }

            else if (chkboxFeedbackPrice.Checked == false)
            {

            }




        }

        private void btnFeedbackDelete_Click(object sender, EventArgs e)
        {
            }

        private void btnFeedbackSave1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedbackFeedbackID.Text))
            {
                MessageBox.Show("A feedback ID should be generated.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtFeedbackEnquirerID.Text))
            {
                MessageBox.Show("The enquirer's ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                try
                {
                    FeedbackDBO fdbo = new FeedbackDBO();
                    string feedbackid = txtFeedbackFeedbackID.Text;
                    string enquirerid = txtFeedbackEnquirerID.Text;
                    string customername = txtFeedbackCustName.Text;
                    string leadsource = cmbboxFeedbackLeadSource.Text;
                    string satisfactionrating = "no rating"; if (rdobtnFeedbackExcellent.Checked == true) { satisfactionrating = "Excellent"; } else if (rdobtnFeedbackNeutral.Checked == true) { satisfactionrating = "Neutral"; } else if (rdobtnFeedbackPoor.Checked == true) { satisfactionrating = "Poor"; } else if (rdobtnFeedbackVeryPoor.Checked == true) { satisfactionrating = "Very Poor"; };
                    string ontimedelivery = "null"; if (rdobtnFeedbackYes.Checked == true) { ontimedelivery = "Yes"; } else if (rdobtnFeedbackNo.Checked == true) { ontimedelivery = "No"; };
                    string importantelements = "";
                    if (chkboxFeedbackPrice.Checked == true) { importantelements = importantelements + chkboxFeedbackPrice.Text + ","; }
                    if (chkboxFeedbackFuelConsumption.Checked == true) { importantelements = importantelements + chkboxFeedbackFuelConsumption.Text + ","; };
                    if (chkboxFeedbackBrandName.Checked == true) { importantelements = importantelements + chkboxFeedbackBrandName.Text + ","; }
                    if (chkboxInteriorAndComfort.Checked == true) { importantelements = importantelements + chkboxInteriorAndComfort.Text + ","; };
                    if (chkboxFeedbackAfterSalesService.Checked == true) { importantelements = importantelements + chkboxFeedbackAfterSalesService.Text + ","; }
                    if (chkboxFeedbackMaintenanceCost.Checked == true) { importantelements = importantelements + chkboxFeedbackMaintenanceCost.Text + ","; };
                    if (chkboxFeedbackSafetyAndReliability.Checked == true) { importantelements = importantelements + chkboxFeedbackSafetyAndReliability.Text + ","; }
                    if (chkboxFeedbackxteriorDesign.Checked == true) { importantelements = importantelements + chkboxFeedbackxteriorDesign.Text + ","; };
                    string otherfeedback = txtFeedbackOtherFeedbackForImprovements.Text;


                    Feedback feedback = new Feedback(feedbackid, enquirerid, customername, leadsource, satisfactionrating, ontimedelivery, importantelements, otherfeedback);
                    fdbo.custFeedback(feedback);
                    MessageBox.Show("The customer's feedback/voice has been recorded. Thank You!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("This Feedback ID has already been generated.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnFeedbackDelete1_Click(object sender, EventArgs e)
        {
            FeedbackDBO fdbo = new FeedbackDBO();
            string feedbackid = txtFeedbackFeedbackID.Text;
            string enquirerid = txtFeedbackEnquirerID.Text;
            string customername = txtFeedbackCustName.Text;
            string leadsource = cmbboxFeedbackLeadSource.Text;
            string satisfactionrating = "no rating"; if (rdobtnFeedbackExcellent.Checked == true) { satisfactionrating = "Excellent"; } else if (rdobtnFeedbackNeutral.Checked == true) { satisfactionrating = "Neutral"; } else if (rdobtnFeedbackPoor.Checked == true) { satisfactionrating = "Poor"; } else if (rdobtnFeedbackVeryPoor.Checked == true) { satisfactionrating = "Very Poor"; };
            string ontimedelivery = "null"; if (rdobtnFeedbackYes.Checked == true) { ontimedelivery = "Yes"; } else if (rdobtnFeedbackNo.Checked == true) { ontimedelivery = "No"; };
            string importantelements = "";
            if (chkboxFeedbackPrice.Checked == true) { importantelements = importantelements + chkboxFeedbackPrice.Text + ","; }
            if (chkboxFeedbackFuelConsumption.Checked == true) { importantelements = importantelements + chkboxFeedbackFuelConsumption.Text + ","; };
            if (chkboxFeedbackBrandName.Checked == true) { importantelements = importantelements + chkboxFeedbackBrandName.Text + ","; }
            if (chkboxInteriorAndComfort.Checked == true) { importantelements = importantelements + chkboxInteriorAndComfort.Text + ","; };
            if (chkboxFeedbackAfterSalesService.Checked == true) { importantelements = importantelements + chkboxFeedbackAfterSalesService.Text + ","; }
            if (chkboxFeedbackMaintenanceCost.Checked == true) { importantelements = importantelements + chkboxFeedbackMaintenanceCost.Text + ","; };
            if (chkboxFeedbackSafetyAndReliability.Checked == true) { importantelements = importantelements + chkboxFeedbackSafetyAndReliability.Text + ","; }
            if (chkboxFeedbackxteriorDesign.Checked == true) { importantelements = importantelements + chkboxFeedbackxteriorDesign.Text + ","; };
            string otherfeedback = txtFeedbackOtherFeedbackForImprovements.Text;

            Feedback feedback = new Feedback(feedbackid, enquirerid, customername, leadsource, satisfactionrating, ontimedelivery, importantelements, otherfeedback);
            fdbo.deletecustFeedback(feedback);
            MessageBox.Show("The customer's feedback record has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtFeedbackFeedbackID.Text = ""; txtFeedbackEnquirerID.Text = ""; txtFeedbackCustName.Text = ""; cmbboxFeedbackLeadSource.Text = ""; rdobtnFeedbackExcellent.Checked = false; rdobtnFeedbackNeutral.Checked = false; rdobtnFeedbackPoor.Checked = false; rdobtnFeedbackVeryPoor.Checked = false; rdobtnFeedbackYes.Checked = false; rdobtnFeedbackNo.Checked = false; chkboxFeedbackPrice.Checked = false; chkboxFeedbackFuelConsumption.Checked = false; chkboxFeedbackBrandName.Checked = false; chkboxInteriorAndComfort.Checked = false; chkboxFeedbackAfterSalesService.Checked = false; chkboxFeedbackMaintenanceCost.Checked = false; chkboxFeedbackSafetyAndReliability.Checked = false; chkboxFeedbackxteriorDesign.Checked = false; txtFeedbackOtherFeedbackForImprovements.Text = "";
        
        }

        private void btnFeedbackUpdate1_Click(object sender, EventArgs e)
        {
            FeedbackDBO fdbo = new FeedbackDBO();
            string feedbackid = txtFeedbackFeedbackID.Text;
            string enquirerid = txtFeedbackEnquirerID.Text;
            string customername = txtFeedbackCustName.Text;
            string leadsource = cmbboxFeedbackLeadSource.Text;
            string satisfactionrating = "no rating"; if (rdobtnFeedbackExcellent.Checked == true) { satisfactionrating = "Excellent"; } else if (rdobtnFeedbackNeutral.Checked == true) { satisfactionrating = "Neutral"; } else if (rdobtnFeedbackPoor.Checked == true) { satisfactionrating = "Poor"; } else if (rdobtnFeedbackVeryPoor.Checked == true) { satisfactionrating = "Very Poor"; };
            string ontimedelivery = "null"; if (rdobtnFeedbackYes.Checked == true) { ontimedelivery = "Yes"; } else if (rdobtnFeedbackNo.Checked == true) { ontimedelivery = "No"; };
            string importantelements = "";
            if (chkboxFeedbackPrice.Checked == true) { importantelements = importantelements + chkboxFeedbackPrice.Text + ","; }
            if (chkboxFeedbackFuelConsumption.Checked == true) { importantelements = importantelements + chkboxFeedbackFuelConsumption.Text + ","; };
            if (chkboxFeedbackBrandName.Checked == true) { importantelements = importantelements + chkboxFeedbackBrandName.Text + ","; }
            if (chkboxInteriorAndComfort.Checked == true) { importantelements = importantelements + chkboxInteriorAndComfort.Text + ","; };
            if (chkboxFeedbackAfterSalesService.Checked == true) { importantelements = importantelements + chkboxFeedbackAfterSalesService.Text + ","; }
            if (chkboxFeedbackMaintenanceCost.Checked == true) { importantelements = importantelements + chkboxFeedbackMaintenanceCost.Text + ","; };
            if (chkboxFeedbackSafetyAndReliability.Checked == true) { importantelements = importantelements + chkboxFeedbackSafetyAndReliability.Text + ","; }
            if (chkboxFeedbackxteriorDesign.Checked == true) { importantelements = importantelements + chkboxFeedbackxteriorDesign.Text + ","; };
            string otherfeedback = txtFeedbackOtherFeedbackForImprovements.Text;

            Feedback feedback = new Feedback(feedbackid, enquirerid, customername, leadsource, satisfactionrating, ontimedelivery, importantelements, otherfeedback);
            fdbo.updatecustFeedback(feedback);
            MessageBox.Show("Changes made to the customer feedback record has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGenerateFeedbackID_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select MAX(SUBSTRING (feedbackid,3,5)) from customer_feedback", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int tempno = int.Parse(rd[0].ToString());
                txtFeedbackFeedbackID.Text = "FB" + (tempno + 1).ToString();

            }

            conn.Close();

        }

        private void txtVisitSalesPersonID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string enquirerid = txtFeedbackEnquirerID.Text;
                FeedbackDBO fdbo = new FeedbackDBO();
                Feedback feedback = fdbo.findFeedback2(enquirerid);
                txtFeedbackCustName.Text = feedback.getCustomerName();
            }
            catch
            {
                txtFeedbackCustName.Text = "";
            }
        }

        private void btnGenerateFeedbackID_MouseHover(object sender, EventArgs e)
        {
            btnGenerateFeedbackID.BackColor = Color.Red;
        }

        private void btnGenerateFeedbackID_MouseLeave(object sender, EventArgs e)
        {
            btnGenerateFeedbackID.BackColor = Color.Gainsboro;
        }

        private void btnFeedbackFind_MouseHover(object sender, EventArgs e)
        {
            btnFeedbackFind.BackColor = Color.Red;
        }

        private void btnFeedbackFind_MouseLeave(object sender, EventArgs e)
        {
            btnFeedbackFind.BackColor = Color.Gainsboro;
        }

        private void btnFeedbackSave1_MouseHover(object sender, EventArgs e)
        {
            btnFeedbackSave1.BackColor = Color.Red;
        }

        private void btnFeedbackSave1_MouseLeave(object sender, EventArgs e)
        {
            btnFeedbackSave1.BackColor = Color.Gainsboro;
        }

        private void btnFeedbackDelete1_MouseHover(object sender, EventArgs e)
        {
            btnFeedbackDelete1.BackColor = Color.Red;
        }

        private void btnFeedbackDelete1_MouseLeave(object sender, EventArgs e)
        {
            btnFeedbackDelete1.BackColor = Color.Gainsboro;
        }

        private void btnFeedbackUpdate1_MouseHover(object sender, EventArgs e)
        {
            btnFeedbackUpdate1.BackColor = Color.Red;
        }

        private void btnFeedbackUpdate1_MouseLeave(object sender, EventArgs e)
        {
            btnFeedbackUpdate1.BackColor = Color.Gainsboro;
        }
    }
}
