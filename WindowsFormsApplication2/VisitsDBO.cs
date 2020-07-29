using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class VisitsDBO
    {
        SqlConnection conn = null;
        public VisitsDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void VisitDetails(Visits visits)
        {
            string vid = visits.getVisitID();
            string vsid = visits.getSalesPersonID();
            string vdate = visits.getVisitDate();
            string vtype = visits.getVisitType();
            string vdetails = visits.getVisitDetails();


            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into visit_details values('" + vid + "','" + vsid + "','" + vdate + "','" + vtype + "','" + vdetails + "')", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateVisitDetails(Visits visits)
        {
            string vid = visits.getVisitID();
            string vsid = visits.getSalesPersonID();
            string vdate = visits.getVisitDate();
            string vtype = visits.getVisitType();
            string vdetails = visits.getVisitDetails();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update visit_details set visitid='" + vid + "',salespersonid='" + vsid + "',visitdate='" + vdate + "',visittype='" + vtype + "',visitdetails='" + vdetails + "' where visitid='" + vid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void deleteVisitDetails(Visits visits)
        {
            string vid = visits.getVisitID();
            string vsid = visits.getSalesPersonID();
            string vdate = visits.getVisitDate();
            string vtype = visits.getVisitType();
            string vdetails = visits.getVisitDetails();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from visit_details where visitid='" + vid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }





          





    }
}
