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
    public partial class FeedbackAnalyze : Form
    {
        public FeedbackAnalyze()
        {
            InitializeComponent();
        }

        private void FeedbackAnalyze_Load(object sender, EventArgs e)
        {
            crystalReportViewer222.ReportSource = null;
            crystalReportViewer222.Refresh();



            CrystalReportsFolder.CrystalReportAnalyzeFeedback1 cr = new CrystalReportsFolder.CrystalReportAnalyzeFeedback1();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();

            conn.Open();
            string sql = "select * from enquirer_information2,customer_feedback where enquirer_information2.enquirerid = customer_feedback.enquirerid";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "feedbacklist");
            DataTable dt = ds.Tables["feedbacklist"];

            cr.SetDataSource(ds.Tables["feedbacklist"]);
            crystalReportViewer222.ReportSource = cr;
            crystalReportViewer222.Refresh();
            conn.Close();


        }

        private void crystalReportViewer222_Load(object sender, EventArgs e)
        {




        }
    }
}
