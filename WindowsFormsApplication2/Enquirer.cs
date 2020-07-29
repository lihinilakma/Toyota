using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Enquirer
    {
        //properties
        private string enquirerid;
        private string salespersonid;
        private string customername;
        private string company;
        private string address;
        private int contactno;
        private string emailaddress;
        private string dateofenquiry;
        private string interestedvehiclemodel;
        private string enquirerstatus;

        //default constructor
        public Enquirer()
        {
            this.enquirerid = null;
            this.salespersonid = null;
            this.customername = null;
            this.company = null;
            this.address = null;
            this.contactno = 0;
            this.emailaddress = null;
            this.dateofenquiry = null;
            this.interestedvehiclemodel = null;
            this.enquirerstatus=null;
        }

        //parameterized constructor
        public Enquirer(string eid, string esid, string ename, string ecompany, string eaddress, int econtactno, string eemailaddress, string edateofenquiry, string einterestedvehiclemodel, string eenquirerstatus)
        {
            this.enquirerid = eid;
            this.salespersonid = esid;
            this.customername = ename;
            this.company = ecompany;
            this.address = eaddress;
            this.contactno = econtactno;
            this.emailaddress = eemailaddress;
            this.dateofenquiry = edateofenquiry;
            this.interestedvehiclemodel = einterestedvehiclemodel;
            this.enquirerstatus = eenquirerstatus;
        }

        
        //create getter methods

        public string getEnquirerID()
        {
            return this.enquirerid;
        }

        public string getSalesPersonID()
        {
            return this.salespersonid;
        }

        public string getCustomerName()
        {
            return this.customername;
        }

        public string getCompany()
        {
            return this.company;
        }
        public string getAddress()
        {
            return this.address;
        }
        public int getContactNo()
        {
            return this.contactno;
        }
        public string getEmailAddress()
        {
            return this.emailaddress;
        }
        public string getDateOfEnquiry()
        {
            return this.dateofenquiry;
        }
        public string getInterestedVehicleModel()
        {
            return this.interestedvehiclemodel;
        }

        public string getEnquirerStatus()
        {
            return this.enquirerstatus;
        }
}
    
}
