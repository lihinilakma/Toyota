using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;




namespace WindowsFormsApplication2
{
    class SalesPersonDBO
    {

           SqlConnection conn = null;
           public SalesPersonDBO()
        {
            conn= DbConnection.getConnection();
        }
        public static string SetValueForText2 = "";
        public void salesstaffDetails(SalesPerson salesperson)
        {
            try
            {
                string ssid = salesperson.getSalesPersonID();
                string seid = salesperson.getEmployeeName();
                int smonthlytarget = salesperson.getMonthlyTarget();
                int sorderstaken = salesperson.getOrdersTaken();
                int scustomervisits = salesperson.getCustomerVisits();
                int snewleads = salesperson.getNewLeads();


                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into sales_person values('" + ssid + "','" + seid + "','" + smonthlytarget + "','" + sorderstaken + "','" + scustomervisits + "','" + snewleads + "')", conn);
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
        


        
        









        public void updateSalesStaff(SalesPerson salesperson)
        {
            string ssid = salesperson.getSalesPersonID();
            string seid = salesperson.getEmployeeName();
            int smonthlytarget = salesperson.getMonthlyTarget();
            int sorderstaken = salesperson.getOrdersTaken();
            int scustomervisits = salesperson.getCustomerVisits();
            int snewleads = salesperson.getNewLeads();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update sales_person set salespersonid='" + ssid + "',employeename='" + seid + "',monthlytarget='" + smonthlytarget + "',orderstaken='" + sorderstaken + "',customervisits='" + scustomervisits + "',newleads='" + snewleads + "' where salespersonid='" + ssid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public SalesPerson findSalesPerson(string salespersonid)
        {
            
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("update sales_person set orderstaken=(select count (enquirerstatus) from enquirer_information2 where salespersonid='" + salespersonid + "' and enquirer_information2.enquirerstatus LIKE '%Order%') where salespersonid='" + salespersonid + "'", conn);
            cmd2.ExecuteNonQuery();


            SqlCommand cmd3 = new SqlCommand("update sales_person set customervisits=(select count (visitid) from visit_details where visit_details.salespersonid='" + salespersonid + "') where salespersonid='" + salespersonid + "'", conn);
            cmd3.ExecuteNonQuery();
            SqlCommand cmd4 = new SqlCommand("update sales_person set newleads=(select count (enquirerstatus) from enquirer_information2 where salespersonid='" + salespersonid + "' and enquirer_information2.enquirerstatus LIKE '%Lead%') where salespersonid='" + salespersonid + "'", conn);
            cmd4.ExecuteNonQuery();

            //update sales_person set orderstaken=(select count (enquirerstatus) from enquirer_information2 where salespersonid='SP002' and enquirer_information2.enquirerstatus LIKE '%Order%') where salespersonid='SP002'
            //update sales_person set customervisits = (select count (visitid) from visit_details where visit_details.salespersonid='SP001') where salespersonid='SP001'


            SqlCommand cmd = new SqlCommand("select * from sales_person where salespersonid='" + salespersonid + "'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            SalesPerson salesperson = null;

            while (rd.Read())
            {
                string ssid = rd[0].ToString();
                string seid = rd[1].ToString();
                int smonthlytarget = int.Parse(rd[2].ToString());
                int sorderstaken = int.Parse(rd[3].ToString());
                int scustomervisits = int.Parse(rd[4].ToString());
                int snewleads = int.Parse(rd[5].ToString());

                salesperson = new SalesPerson(ssid, seid, smonthlytarget, sorderstaken, scustomervisits, snewleads);
            }
            
            conn.Close();
            return salesperson;
        }


        




        public void deleteSalesPerson(SalesPerson salesperson)
        {
            string ssid = salesperson.getSalesPersonID();
            string seid = salesperson.getEmployeeName();
            int smonthlytarget = salesperson.getMonthlyTarget();
            int sorderstaken = salesperson.getOrdersTaken();
            int scustomervisits = salesperson.getCustomerVisits();
            int snewleads = salesperson.getNewLeads();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from sales_person where salespersonid='" + ssid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
















    }
}
