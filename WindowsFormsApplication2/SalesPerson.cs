using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class SalesPerson
    {

        //properties
        private string salespersonid;
        private string employeename;
        private int monthlytarget;
        private int orderstaken;
        private int customervisits;
        private int newleads;

        //default constructor
        public SalesPerson()
        {
            this.salespersonid = null;
            this.employeename = null;
            this.monthlytarget = 0;
            this.orderstaken = 0;
            this.customervisits = 0;
            this.newleads = 0;
        }

        
        //parameterized constructor
        public SalesPerson(string ssid, string seid, int smonthlytarget, int sorderstaken, int scustomervisits, int snewleads)
        {
            this.salespersonid = ssid;
            this.employeename = seid;
            this.monthlytarget = smonthlytarget;
            this.orderstaken = sorderstaken;
            this.customervisits = scustomervisits;
            this.newleads = snewleads;
        }



        //create getter methods

        public string getSalesPersonID()
        {
            return this.salespersonid;
        }

        public string getEmployeeName()
        {
            return this.employeename;
        }

        public int getMonthlyTarget()
        {
            return this.monthlytarget;
        }

        public int getOrdersTaken()
        {
            return this.orderstaken;
        }
        public int getCustomerVisits()
        {
            return this.customervisits;
        }
        public int getNewLeads()
        {
            return this.newleads;
        }

    }
}
