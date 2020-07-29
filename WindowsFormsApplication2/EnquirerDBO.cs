using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class EnquirerDBO
    {
        SqlConnection conn = null;
        public EnquirerDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void enquirerInfo(Enquirer enquirer)
        {
            try{
            string eid = enquirer.getEnquirerID();
            string esid = enquirer.getSalesPersonID();
            string ename = enquirer.getCustomerName();
            string ecompany = enquirer.getCompany();
            string eaddress = enquirer.getAddress();
            int econtactno = enquirer.getContactNo();
            string eemailaddress = enquirer.getEmailAddress();
            string edateofenquiry = enquirer.getDateOfEnquiry();
            string einterestedvehiclemodel = enquirer.getInterestedVehicleModel();
            string eenquirerstatus = enquirer.getEnquirerStatus();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into enquirer_information2 (enquirerid,salespersonid,customername,company,address,contactno,emailaddress,dateofenquiry,dateoffollowup,interestedvehiclemodel,enquirerstatus) values('" + eid + "','" + esid + "','" + ename + "','" + ecompany + "','" + eaddress + "','" + econtactno + "','" + eemailaddress + "','" + edateofenquiry + "', DATEADD(week,2,'" + edateofenquiry + "'),'" + einterestedvehiclemodel + "','" + eenquirerstatus + "')", conn);
   

            cmd.ExecuteNonQuery();

        }
            catch (Exception ex)
            {
                var sqlException = ex.InnerException as System.Data.SqlClient.SqlException;

                if (sqlException.Number == 2601 || sqlException.Number == 2627)
                {
                }
                conn.Close();
            }    
        }

        

       public void updateEnquirerInfo(Enquirer enquirer)
        {
            string eid = enquirer.getEnquirerID();
            string esid = enquirer.getSalesPersonID();
            string ename = enquirer.getCustomerName();
            string ecompany = enquirer.getCompany();
            string eaddress = enquirer.getAddress();
            int econtactno = enquirer.getContactNo();
            string eemailaddress = enquirer.getEmailAddress();
            string edateofenquiry = enquirer.getDateOfEnquiry();
            string einterestedvehiclemodel = enquirer.getInterestedVehicleModel();
            string eenquirerstatus = enquirer.getEnquirerStatus();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update enquirer_information2 set enquirerid='" + eid + "',salespersonid='" + esid + "',customername='" + ename + "',company='" + ecompany + "',address='" + eaddress + "',contactno='" + econtactno + "',emailaddress='" + eemailaddress + "',dateofenquiry='" + edateofenquiry + "',dateoffollowup=DATEADD(week,2,'" + edateofenquiry + "'),interestedvehiclemodel='" + einterestedvehiclemodel + "',enquirerstatus='" + eenquirerstatus + "' where enquirerid='" + eid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }



       public Enquirer findEnquirer(string enquirerid)
      {

          conn.Open();

          SqlCommand cmd = new SqlCommand("select enquirerid,salespersonid,customername,company,address,contactno,emailaddress,dateofenquiry,interestedvehiclemodel,enquirerstatus from enquirer_information2 where enquirerid='" + enquirerid + "'", conn);

           SqlDataReader rd = cmd.ExecuteReader();

           Enquirer enquirer = null;

           while (rd.Read())
           {
               string eid = rd[0].ToString();
               string esid =rd[1].ToString();
               string ename = rd[2].ToString();
               string ecompany = rd[3].ToString();
               string eaddress = rd[4].ToString();
               int econtactno = int.Parse(rd[5].ToString());
               string eemailaddress = rd[6].ToString();
               string edateofenquiry = rd[7].ToString();
               string einterestedvehiclemodel = rd[8].ToString();
               string eenquirerstatus = rd[9].ToString();

               enquirer = new Enquirer(eid, esid, ename, ecompany, eaddress, econtactno, eemailaddress, edateofenquiry, einterestedvehiclemodel, eenquirerstatus);
           }
           conn.Close();
           return enquirer;
      }



       public void deleteEnquirerInfo(Enquirer enquirer)
       {
           string eid = enquirer.getEnquirerID();
           string esid = enquirer.getSalesPersonID();
           string ename = enquirer.getCustomerName();
           string ecompany = enquirer.getCompany();
           string eaddress = enquirer.getAddress();
           int econtactno = enquirer.getContactNo();
           string eemailaddress = enquirer.getEmailAddress();
           string edateofenquiry = enquirer.getDateOfEnquiry();
           string einterestedvehiclemodel = enquirer.getInterestedVehicleModel();
           string eenquirerstatus = enquirer.getEnquirerStatus();

           conn.Open();

           SqlCommand cmd = new SqlCommand("delete from enquirer_information2 where enquirerid='" + eid + "'", conn);

           cmd.ExecuteNonQuery();

           conn.Close();
       }




    }
}
