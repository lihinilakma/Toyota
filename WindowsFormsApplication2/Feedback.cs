using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Feedback
    {
        //properties
        private string feedbackid;
        private string enquirerid;
        private string customername;
        private string leadsource;
        private string satisfactionrating;
        private string ontimedelivery;
        private string importantelements;
        private string otherfeedback;

         //default constructor
        public Feedback()
        {
            this.feedbackid = null;
            this.enquirerid = null;
            this.customername = null;
            this.leadsource = null;
            this.satisfactionrating = null;
            this.ontimedelivery = null;
            this.importantelements = null;
            this.otherfeedback = null;
        }

        //parameterized constructor
        public Feedback(string fid, string feid, string fname, string fleadsource, string fsatisfactionrating, string fontimedelivery, string fimportantelements, string fotherfeedback)
        {
            this.feedbackid = fid;
            this.enquirerid = feid;
            this.customername = fname;
            this.leadsource = fleadsource;
            this.satisfactionrating = fsatisfactionrating;
            this.ontimedelivery = fontimedelivery;
            this.importantelements = fimportantelements;
            this.otherfeedback = fotherfeedback;
        }




        //create getter methods

        public string getFeedbackID()
        {
            return this.feedbackid;
        }

        public string getEnquirerID()
        {
            return this.enquirerid;
        }

        public string getCustomerName()
        {
            return this.customername;
        }

        public string getLeadSource()
        {
            return this.leadsource;
        }
        public string getSatisfactionRating()
        {
            return this.satisfactionrating;
        }
        public string getOnTimeDelivery()
        {
            return this.ontimedelivery;
        }

        public string getImportantElements()
        {
            return this.importantelements;
        }

        public string getOtherFeedback()
        {
            return this.otherfeedback;
        }
    




    }

    





}
