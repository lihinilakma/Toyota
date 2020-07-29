using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Visits
    {

        //properties
        private string visitid;
        private string salespersonid;
        private string visitdate;
        private string visittype;
        private string visitdetails;

        //default constructor
        public Visits()
        {
            this.visitid = null;
            this.salespersonid = null;
            this.visitdate = null;
            this.visittype = null;
            this.visitdetails = null;
        }

        //parameterized constructor
        public Visits(string vid, string vsid, string vdate, string vtype, string vdetails)
        {
            this.visitid = vid;
            this.salespersonid = vsid;
            this.visitdate = vdate;
            this.visittype = vtype;
            this.visitdetails = vdetails;

        }

        //create getter methods

        public string getVisitID()
        {
            return this.visitid;
        }

        public string getSalesPersonID()
        {
            return this.salespersonid;
        }

        public string getVisitDate()
        {
            return this.visitdate;
        }

        public string getVisitType()
        {
            return this.visittype;
        }

        public string getVisitDetails()
        {
            return this.visitdetails;
        }
    }
}
