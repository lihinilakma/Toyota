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
    public partial class frmVisitDetails : Form
    {
        SqlConnection conn = null;
        public frmVisitDetails()
        {
            InitializeComponent();
            conn = DbConnection.getConnection();
        }








        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVisitDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.sales_person' table. You can move, or remove it, as needed.
            this.sales_personTableAdapter.Fill(this.dataSet2.sales_person);
            txtVisitSalesPersonID.ResetText();






        }

        private void txtVisitVisitID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVisitSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVisitSalesPersonID.Text))
            {
                MessageBox.Show("The sales person should be selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtVisitVisitID.Text))
            {
                MessageBox.Show("A visit ID should be generated.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    VisitsDBO vdbo = new VisitsDBO();
                    string visitid = txtVisitVisitID.Text;
                    string salespersonid = txtVisitSalesPersonID.SelectedValue.ToString();
                    string visitdate = txtVisitDate.Text;
                    string visittype = comboBoxVisitType.Text;
                    string visitdetails = txtVisitVisitDetails.Text;



                    Visits visits = new Visits(visitid, salespersonid, visitdate, visittype, visitdetails);
                    vdbo.VisitDetails(visits);
                    MessageBox.Show("The customer visit details has been recorded. Thank You!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("This Visit ID has already been entered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnVisitUpdate_Click(object sender, EventArgs e)
        {
            VisitsDBO vdbo = new VisitsDBO();
            string visitid = txtVisitVisitID.Text;
            string salespersonid = txtVisitSalesPersonID.SelectedValue.ToString();
            string visitdate = txtVisitDate.Text;
            string visittype = comboBoxVisitType.Text;
            string visitdetails = txtVisitVisitDetails.Text;

            Visits visits = new Visits(visitid, salespersonid, visitdate, visittype, visitdetails);
            vdbo.updateVisitDetails(visits);
            MessageBox.Show("Changes made to the sales visit record has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmVisitDetails frmVisitDetails = new frmVisitDetails();
                frmVisitDetails.Show();
                 
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

        private void btnVisitDelete_Click(object sender, EventArgs e)
        {

            VisitsDBO vdbo = new VisitsDBO();
            string visitid = txtVisitVisitID.Text;
            string salespersonid = txtVisitSalesPersonID.SelectedValue.ToString();
            string visitdate = txtVisitDate.Text;
            string visittype = comboBoxVisitType.Text;
            string visitdetails = txtVisitVisitDetails.Text;

            Visits visits = new Visits(visitid, salespersonid, visitdate, visittype, visitdetails);
            vdbo.deleteVisitDetails(visits);
            MessageBox.Show("The record with the sales visit details has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtVisitVisitID.Text = ""; txtVisitSalesPersonID.Text = ""; txtVisitDate.Text = ""; comboBoxVisitType.Text = ""; txtVisitVisitDetails.Text = "";
        }

        private void btnGenerateVisitID_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select MAX(SUBSTRING (visitid,3,5)) from visit_details", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
           {
                    int tempno = int.Parse(rd[0].ToString());
                    txtVisitVisitID.Text = "VI" + (tempno + 1).ToString();

            }

            conn.Close();


        }

        private void btnGenerateVisitID_MouseHover(object sender, EventArgs e)
        {
            btnGenerateVisitID.BackColor = Color.Red;
        }

        private void btnGenerateVisitID_MouseLeave(object sender, EventArgs e)
        {
            btnGenerateVisitID.BackColor = Color.Gainsboro;
        }

        private void btnVisitSave_MouseHover(object sender, EventArgs e)
        {
            btnVisitSave.BackColor = Color.Red;
        }

        private void btnVisitSave_MouseLeave(object sender, EventArgs e)
        {
            btnVisitSave.BackColor = Color.Gainsboro;
        }

        private void btnVisitDelete_MouseHover(object sender, EventArgs e)
        {
            btnVisitDelete.BackColor = Color.Red;
        }

        private void btnVisitDelete_MouseLeave(object sender, EventArgs e)
        {
            btnVisitDelete.BackColor = Color.Gainsboro;
        }

        private void btnVisitUpdate_MouseHover(object sender, EventArgs e)
        {
            btnVisitUpdate.BackColor = Color.Red;
        }

        private void btnVisitUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnVisitUpdate.BackColor = Color.Gainsboro;
        }
    }
}
