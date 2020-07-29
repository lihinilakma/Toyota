using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    class QuotationsDBO
    {
         SqlConnection conn = null;
        public QuotationsDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void generateQuotation(Quotations quotations)
        {
            try{
            string qid = quotations.getQuotationID();
            string qsid = quotations.getSalesPersonID();
            string qfirstname = quotations.getFirstName();
            string qlastname = quotations.getLastName();
            string qpermitholder = quotations.getPermitHolder();
            string qbusinessorganization = quotations.getBusinessOrganization();
            int qphone = quotations.getPhone();
            string qemail = quotations.getEmail();
            string qvehiclemodel = quotations.getVehicleModel();
            string qspecurl = quotations.getSpecURL();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into generate_quotation2 values('" + qid + "','" + qsid + "','" + qfirstname + "','" + qlastname + "','" + qpermitholder + "','" + qbusinessorganization + "','" + qphone + "','" + qemail + "','" + qvehiclemodel + "','" + qspecurl + "')", conn);

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


        public void updateQuotation(Quotations quotations)
        {
            string qid = quotations.getQuotationID();
            string qsid = quotations.getSalesPersonID();
            string qfirstname = quotations.getFirstName();
            string qlastname = quotations.getLastName();
            string qpermitholder = quotations.getPermitHolder();
            string qbusinessorganization = quotations.getBusinessOrganization();
            int qphone = quotations.getPhone();
            string qemail = quotations.getEmail();
            string qvehiclemodel = quotations.getVehicleModel();
            string qspecurl = quotations.getSpecURL();
            conn.Open();

            SqlCommand cmd = new SqlCommand("update generate_quotation2 set quotationid='" + qid + "',salespersonid='" + qsid + "',firstname='" + qfirstname + "',lastname='" + qlastname + "',permitholder='" + qpermitholder + "',businessorganization='" + qbusinessorganization + "',phone='" + qphone + "',email='" + qemail + "',vehiclemodel='" + qvehiclemodel + "',url='" + qspecurl + "' where quotationid='" + qid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public void deleteQuotation(Quotations quotations)
        {
            string qid = quotations.getQuotationID();
            string qsid = quotations.getSalesPersonID();
            string qfirstname = quotations.getFirstName();
            string qlastname = quotations.getLastName();
            string qpermitholder = quotations.getPermitHolder();
            string qbusinessorganization = quotations.getBusinessOrganization();
            int qphone = quotations.getPhone();
            string qemail = quotations.getEmail();
            string qvehiclemodel = quotations.getVehicleModel();
            string qspecurl = quotations.getSpecURL();
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from generate_quotation2 where quotationid='" + qid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }





    }
}
