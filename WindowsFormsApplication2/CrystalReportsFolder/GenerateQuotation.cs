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
    public partial class QuotationCrystalReport : Form
    {
        public QuotationCrystalReport()
        {
            InitializeComponent();
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuotationQuotationID.Text))
            {
                MessageBox.Show("The quotation number should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                CrystalReportsFolder.CrystalReportGenerateQuotation cr = new CrystalReportsFolder.CrystalReportGenerateQuotation();
                SqlConnection conn = new SqlConnection();
                conn = DbConnection.getConnection();

                string qid = txtQuotationQuotationID.Text;

                conn.Open();
                string sql = "select * from printquotation where quotationid='" + qid + "'";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "printquotation");
                DataTable dt = ds.Tables["printquotation"];

                cr.SetDataSource(ds.Tables["printquotation"]);
                crystalReportViewer2.ReportSource = cr;
                crystalReportViewer2.Refresh();
                conn.Close();

            }
        }

        private void QuotationCrystalReport_Load(object sender, EventArgs e)
        {
            crystalReportViewer2.ReportSource = null;
            crystalReportViewer2.Refresh();
        }

        private void btnSearchInvoice_MouseHover(object sender, EventArgs e)
        {
            btnSearchQuotation.BackColor = Color.Red;
        }

        private void btnSearchQuotation_MouseLeave(object sender, EventArgs e)
        {
            btnSearchQuotation.BackColor = Color.Gainsboro;
        }
    }
}
