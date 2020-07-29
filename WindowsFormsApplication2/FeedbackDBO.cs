using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class FeedbackDBO
    {

          SqlConnection conn = null;
        public FeedbackDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void custFeedback(Feedback feedback)
        {
            string fid = feedback.getFeedbackID();
            string feid = feedback.getEnquirerID();
            string fname = feedback.getCustomerName();
            string fleadsource = feedback.getLeadSource();
            string fsatisfactionrating = feedback.getSatisfactionRating();
            string fontimedelivery = feedback.getOnTimeDelivery();
            string fimportantelements = feedback.getImportantElements();
            string fotherfeedback = feedback.getOtherFeedback();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into customer_feedback values('" + fid + "','" + feid + "','" + fname + "','" + fleadsource + "','" + fsatisfactionrating + "','" + fontimedelivery + "','" + fimportantelements + "','" + fotherfeedback + "')", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updatecustFeedback(Feedback feedback)
        {
            string fid = feedback.getFeedbackID();
            string feid = feedback.getEnquirerID();
            string fname = feedback.getCustomerName();
            string fleadsource = feedback.getLeadSource();
            string fsatisfactionrating = feedback.getSatisfactionRating();
            string fontimedelivery = feedback.getOnTimeDelivery();
            string fimportantelements = feedback.getImportantElements();
            string fotherfeedback = feedback.getOtherFeedback();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update customer_feedback set feedbackid='" + fid + "',enquirerid='" + feid + "',customername='" + fname + "',leadsource='" + fleadsource + "',satisfactionrating='" + fsatisfactionrating + "',ontimedelivery='" + fontimedelivery + "',importantelements='" + fimportantelements + "',otherfeedback='" + fotherfeedback + "' where feedbackid='" + fid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }



        public void deletecustFeedback(Feedback feedback)
        {
            string fid = feedback.getFeedbackID();
            string feid = feedback.getEnquirerID();
            string fname = feedback.getCustomerName();
            string fleadsource = feedback.getLeadSource();
            string fsatisfactionrating = feedback.getSatisfactionRating();
            string fontimedelivery = feedback.getOnTimeDelivery();
            string fimportantelements = feedback.getImportantElements();
            string fotherfeedback = feedback.getOtherFeedback();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from customer_feedback where feedbackid='" + fid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }



        public Feedback findFeedback(string enquirerid)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from customer_feedback where enquirerid='" + enquirerid + "'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Feedback feedback = null;

            while (rd.Read())
            {
                string fid = rd[0].ToString();
                string feid = rd[1].ToString();
                string fname = rd[2].ToString();
                string fleadsource = rd[3].ToString();
                string fsatisfactionrating = rd[4].ToString();
                string fontimedelivery = rd[5].ToString();
                string fimportantelements = rd[6].ToString();
                string fotherfeedback = rd[7].ToString();

                feedback = new Feedback(fid, feid, fname, fleadsource, fsatisfactionrating, fontimedelivery,fimportantelements, fotherfeedback);
            }
            conn.Close();
            return feedback;



        }




        public Feedback findFeedback2 (string enquirerid)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from enquirer_information2 where enquirerid='" + enquirerid + "'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Feedback feedback = null;

           while (rd.Read())
            {
                string fid = rd[0].ToString();
                string feid = rd[1].ToString();
                string fname = rd[2].ToString();
                string fleadsource = rd[3].ToString();
                string fsatisfactionrating = rd[4].ToString();
                string fontimedelivery = rd[5].ToString();
                string fimportantelements = rd[6].ToString();
                string fotherfeedback = rd[7].ToString();

                feedback = new Feedback(fid, feid, fname, fleadsource, fsatisfactionrating, fontimedelivery,fimportantelements, fotherfeedback);
            } 
            conn.Close();
            return feedback;



        }






    }
}
