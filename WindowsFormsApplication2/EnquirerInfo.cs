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
    public partial class frmEnquirerInformation : Form
    {
        SqlConnection conn = null;
        public frmEnquirerInformation()
        {
            InitializeComponent();
            conn = DbConnection.getConnection();
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkboxEnqTestDrive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmEnquirerInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.sales_person' table. You can move, or remove it, as needed.
            this.sales_personTableAdapter.Fill(this.dataSet2.sales_person);
            txtEnqSalesPersonID1.ResetText();
            btnEnqFind.Location = new Point(435, 174);
            panel1.Location = new Point(19, 588);
            
        }

        private void btnEnqSave_Click(object sender, EventArgs e)
        {
           
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
                frmEnquirerInformation frmEnquirerInformation = new frmEnquirerInformation();
                frmEnquirerInformation.Show();
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

        private void btnEnqDelete_Click(object sender, EventArgs e)
        {

        }



        private void btnEnqUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string enquirerid = txtEnqEnquireID.Text;
                EnquirerDBO edbo = new EnquirerDBO();
                Enquirer enquirer = edbo.findEnquirer(enquirerid);

                string salespersonid1 = enquirer.getSalesPersonID();
                txtEnqCustName.Text = enquirer.getCustomerName();
                txtEnqCompany.Text = enquirer.getCompany();
                txtEnqAddress.Text = enquirer.getAddress();
                txtEnqContactNo.Text = enquirer.getContactNo().ToString();
                txtEnqEmailAddress.Text = enquirer.getEmailAddress();
                txtEnqDateOfEnquiry.Text = enquirer.getDateOfEnquiry();
                comboBoxEnqVehicleModel.Text = enquirer.getInterestedVehicleModel();
                string EnquirerStatus = enquirer.getEnquirerStatus();
                if (EnquirerStatus.Contains("Lead")) { chkboxEnqNewLead.Checked = true; } else { chkboxEnqNewLead.Checked = false; };
                if (EnquirerStatus.Contains("Quotation")) { chkboxEnqQuotationSubmitted.Checked = true; } else { chkboxEnqQuotationSubmitted.Checked = false; };
                if (EnquirerStatus.Contains("Prospect")) { chkboxEnqHotProspect.Checked = true; } else { chkboxEnqHotProspect.Checked = false; };
                if (EnquirerStatus.Contains("Test")) { chkboxEnqTestDrive.Checked = true; } else { chkboxEnqTestDrive.Checked = false; };
                if (EnquirerStatus.Contains("Order")) { chkboxEnqOrderTaken.Checked = true; } else { chkboxEnqOrderTaken.Checked = false; };


                string salespersonid = salespersonid1;
                SalesPersonDBO sdbo = new SalesPersonDBO();
                SalesPerson salesperson = sdbo.findSalesPerson(salespersonid);
                txtEnqSalesPersonID1.Text = salesperson.getEmployeeName();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't find any records or details of such a Sales Enquirer.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtEnqContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnVisitUpdate_Click(object sender, EventArgs e)
        {            EnquirerDBO edbo = new EnquirerDBO();
            string enquirerid = txtEnqEnquireID.Text;
            string salespersonid = txtEnqSalesPersonID1.SelectedValue.ToString();
            string customername = txtEnqCustName.Text;
            string company = txtEnqCompany.Text;
            string address = txtEnqAddress.Text;
            int contactno = int.Parse(txtEnqContactNo.Text.Trim());
            string emailaddress = txtEnqEmailAddress.Text;
            string dateofenquiry = txtEnqDateOfEnquiry.Value.ToString("yyyy-MM-dd");
            string interestedvehiclemodel = comboBoxEnqVehicleModel.Text;
            string enquirerstatus = "";
            if (chkboxEnqNewLead.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqNewLead.Text + ","; }
            if (chkboxEnqHotProspect.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqHotProspect.Text + ","; };
            if (chkboxEnqQuotationSubmitted.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqQuotationSubmitted.Text + ","; }
            if (chkboxEnqTestDrive.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqTestDrive.Text + ","; };
            if (chkboxEnqOrderTaken.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqOrderTaken.Text + ","; };



            Enquirer enquirer = new Enquirer(enquirerid, salespersonid, customername, company, address, contactno, emailaddress, dateofenquiry, interestedvehiclemodel, enquirerstatus);
            edbo.updateEnquirerInfo(enquirer);
            MessageBox.Show("Changes made to the sales enquirer record has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void btnEnqDelete_Click_1(object sender, EventArgs e)
        {

            EnquirerDBO edbo = new EnquirerDBO();
            string enquirerid = txtEnqEnquireID.Text;
            string salespersonid = txtEnqSalesPersonID1.SelectedValue.ToString();
            string customername = txtEnqCustName.Text;
            string company = txtEnqCompany.Text;
            string address = txtEnqAddress.Text;
            int contactno = int.Parse(txtEnqContactNo.Text.Trim());
            string emailaddress = txtEnqEmailAddress.Text;
            string dateofenquiry = txtEnqDateOfEnquiry.Value.ToString("yyyy-MM-dd");
            string interestedvehiclemodel = comboBoxEnqVehicleModel.Text;
            string enquirerstatus = "";
            if (chkboxEnqNewLead.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqNewLead.Text + ","; }
            if (chkboxEnqHotProspect.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqHotProspect.Text + ","; };
            if (chkboxEnqQuotationSubmitted.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqQuotationSubmitted.Text + ","; }
            if (chkboxEnqTestDrive.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqTestDrive.Text + ","; };
            if (chkboxEnqOrderTaken.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqOrderTaken.Text + ","; };



            Enquirer enquirer = new Enquirer(enquirerid, salespersonid, customername, company, address, contactno, emailaddress, dateofenquiry, interestedvehiclemodel, enquirerstatus);
            edbo.deleteEnquirerInfo(enquirer);
            MessageBox.Show("The sales enquirer record & it's information has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtEnqEnquireID.Text = ""; txtEnqSalesPersonID1.Text = ""; txtEnqCustName.Text = ""; txtEnqCompany.Text = ""; txtEnqAddress.Text = ""; txtEnqContactNo.Text = ""; txtEnqEmailAddress.Text = ""; txtEnqDateOfEnquiry.Text = ""; comboBoxEnqVehicleModel.Text = ""; chkboxEnqNewLead.Checked = false; chkboxEnqHotProspect.Checked = false; chkboxEnqQuotationSubmitted.Checked = false; chkboxEnqTestDrive.Checked = false; chkboxEnqOrderTaken.Checked = false;
        

        }

        private void btnEnqSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEnqContactNo.Text))
            {
                MessageBox.Show("The contact number should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEnqContactNo.TextLength <= 9)
            {
                MessageBox.Show("The contact number should have 10 digits.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtEnqEnquireID.Text))
            {
                MessageBox.Show("An enquirer ID should be generated.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtEnqSalesPersonID1.Text))
            {
                MessageBox.Show("A sales person ID should be selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try{
                    EnquirerDBO edbo = new EnquirerDBO();
                    string enquirerid = txtEnqEnquireID.Text;
                    string salespersonid = txtEnqSalesPersonID1.SelectedValue.ToString();
                    string customername = txtEnqCustName.Text;
                    string company = txtEnqCompany.Text;
                    string address = txtEnqAddress.Text;
                    int contactno = int.Parse(txtEnqContactNo.Text.Trim());
                    string emailaddress = txtEnqEmailAddress.Text;
                    string dateofenquiry = txtEnqDateOfEnquiry.Value.ToString("yyyy-MM-dd");
                    string interestedvehiclemodel = comboBoxEnqVehicleModel.Text;
                    string enquirerstatus = "";
                    if (chkboxEnqNewLead.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqNewLead.Text + ","; }
                    if (chkboxEnqHotProspect.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqHotProspect.Text + ","; };
                    if (chkboxEnqQuotationSubmitted.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqQuotationSubmitted.Text + ","; }
                    if (chkboxEnqTestDrive.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqTestDrive.Text + ","; };
                    if (chkboxEnqOrderTaken.Checked == true) { enquirerstatus = enquirerstatus + chkboxEnqOrderTaken.Text + ","; };


                    Enquirer enquirer = new Enquirer(enquirerid, salespersonid, customername, company, address, contactno, emailaddress, dateofenquiry, interestedvehiclemodel, enquirerstatus);
                    edbo.enquirerInfo(enquirer);
                    MessageBox.Show("The new sales enquirer information was added successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex2) { MessageBox.Show("This Enquirer's ID has already been entered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);}

            }
        }

        private void btnGenerateVisitID_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select MAX(SUBSTRING (enquirerid,3,5)) from enquirer_information2", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int tempno = int.Parse(rd[0].ToString());
                txtEnqEnquireID.Text = "EQ" + (tempno + 1).ToString();

            }

            conn.Close();
        }

        private void txtEnqEnquireID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnqSave_MouseHover(object sender, EventArgs e)
        {
            btnEnqSave.BackColor = Color.Red;
        }

        private void btnEnqSave_MouseLeave(object sender, EventArgs e)
        {
            btnEnqSave.BackColor = Color.Gainsboro;
        }

        private void btnEnqDelete_MouseHover(object sender, EventArgs e)
        {
            btnEnqDelete.BackColor = Color.Red;
        }

        private void btnEnqDelete_MouseLeave(object sender, EventArgs e)
        {
            btnEnqDelete.BackColor = Color.Gainsboro;
        }

        private void btnEnqUpdate_MouseHover(object sender, EventArgs e)
        {
            btnEnqUpdate.BackColor = Color.Red;
        }

        private void btnEnqUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnEnqUpdate.BackColor = Color.Gainsboro;
        }

        private void btnGenerateEnquirerID_MouseHover(object sender, EventArgs e)
        {
            btnGenerateEnquirerID.BackColor = Color.Red;
        }

        private void btnGenerateEnquirerID_MouseLeave(object sender, EventArgs e)
        {
            btnGenerateEnquirerID.BackColor = Color.Gainsboro;
        }

        private void btnEnqFind_MouseHover(object sender, EventArgs e)
        {
            btnEnqFind.BackColor = Color.Red;
        }

        private void btnEnqFind_MouseLeave(object sender, EventArgs e)
        {
            btnEnqFind.BackColor = Color.Gainsboro;
        }

      

    }
}
