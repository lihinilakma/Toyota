using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Quotations
    {

          //properties
        private string quotationid;
        private string salespersonid;
        private string firstname;
        private string lastname;
        private string permitholder;
        private string businessorganization;
        private int phone;
        private string email;
        private string vehiclemodel;
        private string specurl;



        //default constructor
        public Quotations()
        {
            this.quotationid = null;
            this.salespersonid = null;
            this.firstname = null;
            this.lastname = null;
            this.permitholder = null;
            this.businessorganization = null;
            this.phone = 0;
            this.email = null;
            this.vehiclemodel = null;
            this.specurl = null;
        }

        //parameterized constructor
        public Quotations(string qid, string qsid, string qfirstname, string qlastname, string qpermitholder, string qbusinessorganization, int qphone, string qemail, string qvehiclemodel, string qspecurl)
        {
            this.quotationid = qid;
            this.salespersonid = qsid;
            this.firstname = qfirstname;
            this.lastname = qlastname;
            this.permitholder = qpermitholder;
            this.businessorganization = qbusinessorganization;
            this.phone = qphone;
            this.email = qemail;
            this.vehiclemodel = qvehiclemodel;
            this.specurl = qspecurl;
        }

        //create getter methods

        public string getQuotationID()
        {
            return this.quotationid;
        }

        public string getSalesPersonID()
        {
            return this.salespersonid;
        }

        public string getFirstName()
        {
            return this.firstname;
        }

        public string getLastName()
        {
            return this.lastname;
        }

        public string getPermitHolder()
        {
            return this.permitholder;
        }

        public string getBusinessOrganization()
        {
            return this.businessorganization;
        }

        public int getPhone()
        {
            return this.phone;
        }

        public string getEmail()
        {
            return this.email;
        }
        public string getVehicleModel()
        {
            return this.vehiclemodel;
        }
        public string getSpecURL()
        {
            return this.specurl;
        }

    }
}
