using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40291478
{
    class Attendee : MainWindow
    {
        private int attendeeref;
        private string firstname;
        private string secondname;
        private string institution;
        private string confer_name;
        private string registration;
        private string paid;
        private string pres;
        private string papertitle;


        public int AttendeeRef
        {
            get { return attendeeref; }
            set { attendeeref = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string SecondName
        {
            get { return secondname; }
            set { secondname = value; }
        }
        public string Institution
        {
            get { return institution; }
            set { institution = value; }
        }
        public string Confer_Name
        {
            get { return confer_name; }
            set { confer_name = value; }
        }
        public string Registration
        {
            get { return registration; }
            set { registration = value; }
        }
        public string Paid
        {
            get { return paid; }
            set { paid = value; }
        }
        public string Pres
        {
            get { return pres; }
            set { pres = value; }
        }
        public string PaperTitle
        {
            get { return papertitle; }
            set { papertitle = value; }
        }
    }
}