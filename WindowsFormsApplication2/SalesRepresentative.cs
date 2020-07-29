using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmSalesRepresentative : Form
    {

                SqlConnection conn = null;
                public frmSalesRepresentative()
        {
            InitializeComponent();
            conn = DbConnection.getConnection();
        }



        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEnquirer_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSet2.sales_person' table. You can move, or remove it, as needed.
            this.sales_personTableAdapter.Fill(this.dataSet2.sales_person);
            txtSalesSalesPersonID.ResetText();
            btnSalesFind.Location = new Point(469, 232);
            rectangleShape1.Hide();
            btnSalesFind.Location = new Point(469, 232);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                frmSalesRepresentative frmSalesRepresentative = new frmSalesRepresentative();
                frmSalesRepresentative.Show();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalesSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalesUpdate_Click(object sender, EventArgs e)
        {

          
        }

        private void btnSalesDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnSalesFind_Click(object sender, EventArgs e)
        {





            try
            {
                
                string salespersonid = txtSalesSalesPersonID.SelectedValue.ToString();
                SalesPersonDBO sdbo = new SalesPersonDBO();
                SalesPerson salesperson = sdbo.findSalesPerson(salespersonid);
                //txtSalesSalesPersonID.Text = salesperson.getSalesPersonID();

                txtSalesMonthlyTarget.Text = salesperson.getMonthlyTarget().ToString();
                lblSalesOrderTaken1.Text = salesperson.getOrdersTaken().ToString();
                lblSalesCustomerVisits1.Text = salesperson.getCustomerVisits().ToString();
                lblSalesNewLeads1.Text = salesperson.getNewLeads().ToString();



                conn.Open();
                string salespersonid2 = txtSalesSalesPersonID.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand("select photo from sales_person where salespersonid='" + salespersonid2 + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);
                    pictureBox1.Image = new Bitmap(ms);
                    rectangleShape1.Show();
                }
                conn.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't find any records or details of such a Sales Person.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

     






        }

        private void txtSalesMonthlyTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalesSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalesMonthlyTarget.Text))
            {
                MessageBox.Show("The monthly target should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtSalesSalesPersonID.Text))
            {
                MessageBox.Show("A sales person ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    SalesPersonDBO sdbo = new SalesPersonDBO();
                    string salespersonid = txtSalesSalesPersonID.SelectedValue.ToString();
                    string employeename = txtSalesSalesPersonID.Text;
                    int monthlytarget = int.Parse(txtSalesMonthlyTarget.Text);
                    int orderstaken = int.Parse(lblSalesOrderTaken1.Text);
                    int customervisits = int.Parse(lblSalesCustomerVisits1.Text);
                    int newleads = int.Parse(lblSalesNewLeads1.Text);

                    SalesPerson salesperson = new SalesPerson(salespersonid, employeename, monthlytarget, orderstaken, customervisits, newleads);
                    sdbo.salesstaffDetails(salesperson);
                    MessageBox.Show("New employee assigned as sales person successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("This Sales Person's ID has already been entered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnSalesDelete_Click_1(object sender, EventArgs e)
        {

            SalesPersonDBO sdbo = new SalesPersonDBO();
            string salespersonid = txtSalesSalesPersonID.SelectedValue.ToString();
            string employeename = txtSalesSalesPersonID.Text;
            int monthlytarget = int.Parse(txtSalesMonthlyTarget.Text);
            int orderstaken = int.Parse(lblSalesOrderTaken1.Text);
            int customervisits = int.Parse(lblSalesCustomerVisits1.Text);
            int newleads = int.Parse(lblSalesNewLeads1.Text);


            SalesPerson salesperson = new SalesPerson(salespersonid, employeename, monthlytarget, orderstaken, customervisits, newleads);
            sdbo.deleteSalesPerson(salesperson);
            MessageBox.Show("The employee record has been removed from sales division.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


        }

        private void btnSalesUpdate_Click_1(object sender, EventArgs e)
        {
            SalesPersonDBO sdbo = new SalesPersonDBO();
            string salespersonid = txtSalesSalesPersonID.SelectedValue.ToString();
            string employeename = txtSalesSalesPersonID.Text;
            int monthlytarget = int.Parse(txtSalesMonthlyTarget.Text);
            int orderstaken = int.Parse(lblSalesOrderTaken1.Text);
            int customervisits = int.Parse(lblSalesCustomerVisits1.Text);
            int newleads = int.Parse(lblSalesNewLeads1.Text);

            SalesPerson salesperson = new SalesPerson(salespersonid, employeename, monthlytarget, orderstaken, customervisits, newleads);
            sdbo.updateSalesStaff(salesperson);
            MessageBox.Show("Changes made to the sales person details has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSalesFind_MouseHover(object sender, EventArgs e)
        {
            btnSalesFind.BackColor = Color.Red;
        }

        private void btnSalesFind_MouseLeave(object sender, EventArgs e)
        {
            btnSalesFind.BackColor = Color.Gainsboro;
        }

        private void btnSalesSave_MouseHover(object sender, EventArgs e)
        {
            btnSalesSave.BackColor = Color.Red;
        }

        private void btnSalesSave_MouseLeave(object sender, EventArgs e)
        {
            btnSalesSave.BackColor = Color.Gainsboro;
        }

        private void btnSalesDelete_MouseHover(object sender, EventArgs e)
        {
            btnSalesDelete.BackColor = Color.Red;
        }

        private void btnSalesDelete_MouseLeave(object sender, EventArgs e)
        {
            btnSalesDelete.BackColor = Color.Gainsboro;
        }

        private void btnSalesUpdate_MouseHover(object sender, EventArgs e)
        {
            btnSalesUpdate.BackColor = Color.Red;
        }

        private void btnSalesUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnSalesUpdate.BackColor = Color.Gainsboro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrystalReportsFolder.VehicleOrdersTaken VehicleOrdersTaken = new CrystalReportsFolder.VehicleOrdersTaken();
            VehicleOrdersTaken.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrystalReportsFolder.EnquirerFollowup EnquirerFollowup = new CrystalReportsFolder.EnquirerFollowup();
            EnquirerFollowup.Show();
        }




      

    }
}
