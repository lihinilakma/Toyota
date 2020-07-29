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

namespace WindowsFormsApplication2.CrystalReportsFolder
{
    public partial class VehicleOrdersTaken : Form
    {
        public VehicleOrdersTaken()
        {
            InitializeComponent();
        }

        private void VehicleOrdersTaken_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.sales_person' table. You can move, or remove it, as needed.
            this.sales_personTableAdapter.Fill(this.dataSet2.sales_person);

            crystalReportViewer5.ReportSource = null;
            crystalReportViewer5.Refresh();
            comboBox1.ResetText();


        }

        private void btnSearchSalesPersonID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("A sales person should be selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                CrystalReportsFolder.CrystalReportVehicleOrdersTaken cr = new CrystalReportsFolder.CrystalReportVehicleOrdersTaken();
                SqlConnection conn = new SqlConnection();
                conn = DbConnection.getConnection();

                string salespersonid = comboBox1.SelectedValue.ToString();

                conn.Open();
                string sql = "select * from VehicleOrdersTaken where salespersonid='" + salespersonid + "'";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "vehicleorderstaken");
                DataTable dt = ds.Tables["vehicleorderstaken"];

                cr.SetDataSource(ds.Tables["vehicleorderstaken"]);
                crystalReportViewer5.ReportSource = cr;
                crystalReportViewer5.Refresh();
                conn.Close();
            }
        }

        private void btnSearchSalesPersonID_MouseHover(object sender, EventArgs e)
        {
            btnSearchSalesPersonID.BackColor = Color.Red;
        }

        private void btnSearchSalesPersonID_MouseLeave(object sender, EventArgs e)
        {
            btnSearchSalesPersonID.BackColor = Color.Gainsboro;
        }
    }
}
