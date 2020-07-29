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
    public partial class EnquirerFollowup : Form
    {
        public EnquirerFollowup()
        {
            InitializeComponent();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {

            CrystalReportsFolder.CrystalReportEnquirerFollowup cr = new CrystalReportsFolder.CrystalReportEnquirerFollowup();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();
            string followupdate = txtFollowupDate.Value.ToString("yyyy MMM dd");

            conn.Open();
            string sql = "select * from enquirer_information2 where dateoffollowup='" + followupdate + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "EnquirerFollowupList");
            DataTable dt = ds.Tables["EnquirerFollowupList"];

            cr.SetDataSource(ds.Tables["EnquirerFollowupList"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
        }

        private void EnquirerFollowup_Load(object sender, EventArgs e)
        {
            CrystalReportsFolder.CrystalReportEnquirerFollowup cr = new CrystalReportsFolder.CrystalReportEnquirerFollowup();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();
            string followupdate = txtFollowupDate.Value.ToString("yyyy MMM dd");

            conn.Open();
            string sql = "select * from enquirer_information2 where dateoffollowup='" + followupdate + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "EnquirerFollowupList");
            DataTable dt = ds.Tables["EnquirerFollowupList"];

            cr.SetDataSource(ds.Tables["EnquirerFollowupList"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
        }

        private void btnSearchDate_MouseHover(object sender, EventArgs e)
        {
            btnSearchDate.BackColor = Color.Red;
        }

        private void btnSearchDate_MouseLeave(object sender, EventArgs e)
        {
            btnSearchDate.BackColor = Color.Gainsboro;
        }
    }
}
