using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmQuotation : Form
    {
        SqlConnection conn = null;
        public frmQuotation()
        {
            InitializeComponent();
            conn = DbConnection.getConnection();
        }

        private void txtEnqCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbboxQuotationPermit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQuotation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.sales_person' table. You can move, or remove it, as needed.
            this.sales_personTableAdapter.Fill(this.dataSet2.sales_person);

            txtQuotationSalesPersonID.ResetText();


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
                frmQuotation frmQuotation = new frmQuotation();
                frmQuotation.Show();
            }
            else
            { } 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginscreen loginscreen = new loginscreen();
            loginscreen.Show();
        }

        private void btnQuotationSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuotationUpdate_Click(object sender, EventArgs e)
        {





        }

        private void btnQuotationDelete_Click(object sender, EventArgs e)
        {


            QuotationsDBO qdbo = new QuotationsDBO();
            string quotationid = txtQuotationQuotationID.Text;
            string salespersonid = txtQuotationSalesPersonID.Text;
            string firstname = txtQuotationFirst.Text;
            string lastname = txtQuotationLast.Text;
            string permitholder = cmbboxQuotationPermit.Text;
            string businessorganization = txtQuotationBusiness.Text;
            int phone = int.Parse(txtQuotationPhone.Text);
            string email = txtQuotationEmailAddress.Text;
            string vehiclemodel = "";
            string specurl = "";
            if (chkboxQuotationWigo.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationWigo.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\wigo.tif"; }
            if (chkboxQuotationYaris.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationYaris.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\yaris.tif"; };
            if (chkboxQuotationCoaster.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCoaster.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\coaster.tif"; }
            if (chkboxQuotationHilux.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHilux.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hilux.tif"; };
            if (chkboxQuotationCamry.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCamry.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\camry.tif"; };
            if (chkboxQuotationPriusC.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPriusC.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\priusc.tif"; }
            if (chkboxQuotationHiace.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHiace.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hiace.tif"; };
            if (chkboxQuotationPrius.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPrius.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\prius.tif"; }
            if (chkboxQuotationRush.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationRush.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\rush.tif"; };
            if (chkboxQuotationFortuner.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationFortuner.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\fortuner.tif"; };
            if (chkboxQuotationLC79.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationLC79.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\lc79.tif"; }
            if (chkboxQuotationCorolla.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCorolla.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\corolla.tif"; };
            if (chkboxQuotationPremio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPremio + ","; specurl = @"C:\Users\Abaya\Pictures\specs\premio.tif"; }
            if (chkboxQuotationAllion.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAllion.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\allion.tif"; };
            if (chkboxQuotationCHR.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCHR.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\chr.tif"; };
            if (chkboxQuotationVitz.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationVitz.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\vitz.tif"; }
            if (chkboxQuotationTank.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationTank.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\tank.tif"; };
            if (chkboxQuotationAxio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAxio.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\axio.tif"; };


            Quotations quotations = new Quotations(quotationid, salespersonid, firstname, lastname, permitholder, businessorganization, phone, email,vehiclemodel,specurl);
            qdbo.deleteQuotation(quotations);
            MessageBox.Show("The record of vehicle quotation has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtQuotationQuotationID.Text = ""; txtQuotationSalesPersonID.Text = ""; txtQuotationFirst.Text = ""; txtQuotationLast.Text = ""; cmbboxQuotationPermit.Text = ""; txtQuotationBusiness.Text = ""; txtQuotationPhone.Text = ""; txtQuotationEmailAddress.Text = ""; chkboxQuotationWigo.Checked = false; chkboxQuotationYaris.Checked = false; chkboxQuotationCoaster.Checked = false; chkboxQuotationHilux.Checked = false; chkboxQuotationCamry.Checked = false; chkboxQuotationPriusC.Checked = false; chkboxQuotationHiace.Checked = false; chkboxQuotationPrius.Checked = false; chkboxQuotationRush.Checked = false; chkboxQuotationFortuner.Checked = false; chkboxQuotationLC79.Checked = false; chkboxQuotationCorolla.Checked = false; chkboxQuotationPremio.Checked = false; chkboxQuotationAllion.Checked = false; chkboxQuotationCHR.Checked = false; chkboxQuotationVitz.Checked = false; chkboxQuotationTank.Checked = false; chkboxQuotationAxio.Checked = false;
        }

        private void txtQuotationPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnQuotationSave1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuotationQuotationID.Text))
            {
                MessageBox.Show("A quotation ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtQuotationPhone.Text))
            {
                MessageBox.Show("The contact number should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQuotationPhone.TextLength <= 9)
            {
                MessageBox.Show("The contact number should have 10 digits.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtQuotationSalesPersonID.Text))
            {
                MessageBox.Show("The sales person's ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                try
                {
                    QuotationsDBO qdbo = new QuotationsDBO();
                    string quotationid = txtQuotationQuotationID.Text;string salespersonid = txtQuotationSalesPersonID.SelectedValue.ToString();string firstname = txtQuotationFirst.Text;string lastname = txtQuotationLast.Text;string permitholder = cmbboxQuotationPermit.Text;string businessorganization = txtQuotationBusiness.Text;int phone = int.Parse(txtQuotationPhone.Text);string email = txtQuotationEmailAddress.Text;string vehiclemodel = "";string specurl = "";if (chkboxQuotationWigo.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationWigo.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\wigo.tif"; } if (chkboxQuotationYaris.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationYaris.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\yaris.tif"; };if (chkboxQuotationCoaster.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCoaster.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\coaster.tif"; }if (chkboxQuotationHilux.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHilux.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hilux.tif"; };if (chkboxQuotationCamry.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCamry.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\camry.tif"; };if (chkboxQuotationPriusC.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPriusC.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\priusc.tif"; }if (chkboxQuotationHiace.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHiace.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hiace.tif"; };if (chkboxQuotationPrius.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPrius.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\prius.tif"; }if (chkboxQuotationRush.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationRush.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\rush.tif"; };if (chkboxQuotationFortuner.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationFortuner.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\fortuner.tif"; };if (chkboxQuotationLC79.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationLC79.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\lc79.tif"; }                    if (chkboxQuotationCorolla.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCorolla.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\corolla.tif"; };if (chkboxQuotationPremio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPremio + ","; specurl = @"C:\Users\Abaya\Pictures\specs\premio.tif"; }              if (chkboxQuotationAllion.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAllion.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\allion.tif"; };             if (chkboxQuotationCHR.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCHR.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\chr.tif"; };                  if (chkboxQuotationVitz.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationVitz.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\vitz.tif"; }if (chkboxQuotationTank.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationTank.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\tank.tif"; };if (chkboxQuotationAxio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAxio.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\axio.tif"; };

                    Quotations quotations = new Quotations(quotationid, salespersonid, firstname, lastname, permitholder, businessorganization, phone, email, vehiclemodel, specurl);
                    qdbo.generateQuotation(quotations);
                    MessageBox.Show("New vehicle quotation has been generated successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("This Quotation's ID was already generated.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnQuotationDelete1_Click(object sender, EventArgs e)
        {


            QuotationsDBO qdbo = new QuotationsDBO();
            string quotationid = txtQuotationQuotationID.Text;
            string salespersonid = txtQuotationSalesPersonID.SelectedValue.ToString();
            string firstname = txtQuotationFirst.Text;
            string lastname = txtQuotationLast.Text;
            string permitholder = cmbboxQuotationPermit.Text;
            string businessorganization = txtQuotationBusiness.Text;
            int phone = int.Parse(txtQuotationPhone.Text);
            string email = txtQuotationEmailAddress.Text;
            string vehiclemodel = "";
            string specurl="";
            if (chkboxQuotationWigo.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationWigo.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\wigo.tif"; }
            if (chkboxQuotationYaris.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationYaris.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\yaris.tif"; };
            if (chkboxQuotationCoaster.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCoaster.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\coaster.tif"; }
            if (chkboxQuotationHilux.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHilux.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hilux.tif"; };
            if (chkboxQuotationCamry.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCamry.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\camry.tif"; };
            if (chkboxQuotationPriusC.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPriusC.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\priusc.tif"; }
            if (chkboxQuotationHiace.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHiace.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hiace.tif"; };
            if (chkboxQuotationPrius.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPrius.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\prius.tif"; }
            if (chkboxQuotationRush.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationRush.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\rush.tif"; };
            if (chkboxQuotationFortuner.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationFortuner.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\fortuner.tif"; };
            if (chkboxQuotationLC79.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationLC79.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\lc79.tif"; }
            if (chkboxQuotationCorolla.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCorolla.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\corolla.tif"; };
            if (chkboxQuotationPremio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPremio + ","; specurl = @"C:\Users\Abaya\Pictures\specs\premio.tif"; }
            if (chkboxQuotationAllion.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAllion.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\allion.tif"; };
            if (chkboxQuotationCHR.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCHR.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\chr.tif"; };
            if (chkboxQuotationVitz.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationVitz.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\vitz.tif"; }
            if (chkboxQuotationTank.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationTank.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\tank.tif"; };
            if (chkboxQuotationAxio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAxio.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\axio.tif"; };


            Quotations quotations = new Quotations(quotationid, salespersonid, firstname, lastname, permitholder, businessorganization, phone, email, vehiclemodel, specurl);
            qdbo.deleteQuotation(quotations);
            MessageBox.Show("The record of vehicle quotation has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtQuotationQuotationID.Text = ""; txtQuotationSalesPersonID.Text = ""; txtQuotationFirst.Text = ""; txtQuotationLast.Text = ""; cmbboxQuotationPermit.Text = ""; txtQuotationBusiness.Text = ""; txtQuotationPhone.Text = ""; txtQuotationEmailAddress.Text = ""; chkboxQuotationWigo.Checked = false; chkboxQuotationYaris.Checked = false; chkboxQuotationCoaster.Checked = false; chkboxQuotationHilux.Checked = false; chkboxQuotationCamry.Checked = false; chkboxQuotationPriusC.Checked = false; chkboxQuotationHiace.Checked = false; chkboxQuotationPrius.Checked = false; chkboxQuotationRush.Checked = false; chkboxQuotationFortuner.Checked = false; chkboxQuotationLC79.Checked = false; chkboxQuotationCorolla.Checked = false; chkboxQuotationPremio.Checked = false; chkboxQuotationAllion.Checked = false; chkboxQuotationCHR.Checked = false; chkboxQuotationVitz.Checked = false; chkboxQuotationTank.Checked = false; chkboxQuotationAxio.Checked = false;
        }



        private void btnQuotationUpdate1_Click(object sender, EventArgs e)
        {

            QuotationsDBO qdbo = new QuotationsDBO();
            string quotationid = txtQuotationQuotationID.Text;
            string salespersonid = txtQuotationSalesPersonID.SelectedValue.ToString();
            string firstname = txtQuotationFirst.Text;
            string lastname = txtQuotationLast.Text;
            string permitholder = cmbboxQuotationPermit.Text;
            string businessorganization = txtQuotationBusiness.Text;
            int phone = int.Parse(txtQuotationPhone.Text);
            string email = txtQuotationEmailAddress.Text;
            string vehiclemodel = "";
            string specurl = "";
            if (chkboxQuotationWigo.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationWigo.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\wigo.tif"; }
            if (chkboxQuotationYaris.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationYaris.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\yaris.tif"; };
            if (chkboxQuotationCoaster.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCoaster.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\coaster.tif"; }
            if (chkboxQuotationHilux.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHilux.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hilux.tif"; };
            if (chkboxQuotationCamry.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCamry.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\camry.tif"; };
            if (chkboxQuotationPriusC.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPriusC.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\priusc.tif"; }
            if (chkboxQuotationHiace.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationHiace.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\hiace.tif"; };
            if (chkboxQuotationPrius.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPrius.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\prius.tif"; }
            if (chkboxQuotationRush.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationRush.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\rush.tif"; };
            if (chkboxQuotationFortuner.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationFortuner.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\fortuner.tif"; };
            if (chkboxQuotationLC79.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationLC79.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\lc79.tif"; }
            if (chkboxQuotationCorolla.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCorolla.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\corolla.tif"; };
            if (chkboxQuotationPremio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationPremio + ","; specurl = @"C:\Users\Abaya\Pictures\specs\premio.tif"; }
            if (chkboxQuotationAllion.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAllion.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\allion.tif"; };
            if (chkboxQuotationCHR.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationCHR.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\chr.tif"; };
            if (chkboxQuotationVitz.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationVitz.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\vitz.tif"; }
            if (chkboxQuotationTank.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationTank.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\tank.tif"; };
            if (chkboxQuotationAxio.Checked == true) { vehiclemodel = vehiclemodel + chkboxQuotationAxio.Text + ","; specurl = @"C:\Users\Abaya\Pictures\specs\axio.tif"; };


            Quotations quotations = new Quotations(quotationid, salespersonid, firstname, lastname, permitholder, businessorganization, phone, email, vehiclemodel, specurl);
            qdbo.updateQuotation(quotations);
            MessageBox.Show("Changes made to the vehicle quotation has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void txtQuotationSalesPersonID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateVisitID_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select MAX(SUBSTRING (quotationid,3,5)) from generate_quotation2", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int tempno = int.Parse(rd[0].ToString());
                txtQuotationQuotationID.Text = "QT" + (tempno + 1).ToString();

            }

            conn.Close();

        }

        private void btnQuotationPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuotationQuotationID.Text))
            {
                MessageBox.Show("A quotation ID should be available.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                QuotationCrystalReport QuotationCrystalReport = new QuotationCrystalReport();
                QuotationCrystalReport.Show();
                string qid = txtQuotationQuotationID.Text;
                QuotationCrystalReport.txtQuotationQuotationID.Text = qid.ToString();

            }
        }

        private void btnQuotationDelete_MouseHover(object sender, EventArgs e)
        {
            btnQuotationDelete.BackColor = Color.Red;
        }

        private void btnGenerateQuotationID_MouseHover(object sender, EventArgs e)
        {
            btnGenerateQuotationID.BackColor = Color.Red;
        }

        private void btnGenerateQuotationID_MouseLeave(object sender, EventArgs e)
        {
            btnGenerateQuotationID.BackColor = Color.Gainsboro;
        }

        private void btnQuotationSave_MouseHover(object sender, EventArgs e)
        {
            btnQuotationSave.BackColor = Color.Red;
        }

        private void btnQuotationSave_MouseLeave(object sender, EventArgs e)
        {
            btnQuotationSave.BackColor = Color.Gainsboro;
        }

        private void btnQuotationDelete_MouseLeave(object sender, EventArgs e)
        {
            btnQuotationDelete.BackColor = Color.Gainsboro;
        }

        private void btnQuotationUpdate_MouseHover(object sender, EventArgs e)
        {
            btnQuotationUpdate.BackColor = Color.Red;
        }

        private void btnQuotationUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnQuotationUpdate.BackColor = Color.Gainsboro;
        }

        private void btnQuotationPrint_MouseHover(object sender, EventArgs e)
        {
            btnQuotationPrint.BackColor = Color.Red;
        }

        private void btnQuotationPrint_MouseLeave(object sender, EventArgs e)
        {
            btnQuotationPrint.BackColor = Color.Gainsboro;
        }
    }
}
