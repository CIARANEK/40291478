using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40291478
{
    //Ciaran McMahon
    //40191478
    public class Attendee 
    {
        //Declare private variables
        private string attendeeref;
        private string firstname;
        private string secondname;
        private string institution;
        private string confer_name;
        private string registration;
        private string paid;
        private string pres;
        private string papertitle;

        public string AttendeeRef
        {
            //GetSet the Attendee Reference and validate it
            get { return attendeeref; }
            set
            {
                try
                {
                    int attendeeInt = Convert.ToInt32(value);
                    if (attendeeInt >= 40000 && attendeeInt <= 60000)
                    {
                        attendeeref = value;
                    }
                    else
                    {
                        throw new Exception("Please enter a value between 40000 and 60000");
                    }
                }
                catch (FormatException)
                {
                    
                    throw new ArgumentException("Please enter a number in Attendee Refference");
                }
            }
        }
        public string FirstName
        {
            //GetSet the First name and validate it
            get { return firstname; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    firstname = value;
                }
                else
                {
                    throw new Exception("Please enter a valid First name");
                }
            }
        }
        public string SecondName
        {
            ////GetSet the second name and validate it
            get { return secondname; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    secondname = value;
                }
                else
                {
                    throw new Exception("Please enter a valid second name");
                }
            }
        }
        public string Institution
        {
            //GetSet the Institution 
            get { return institution; }
            set { institution = value; }
        }
        public string Confer_Name
        {
            //GetSet the Conference name and validate it
            get { return confer_name; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    confer_name = value;
                }
                else
                {
                    throw new Exception("Please enter a valid Conference name");
                }
            }
        }
        public string Registration
        {
            //GetSet the Registration type 
            get { return registration; }
            set { registration = value; }
        }
        public string Paid
        {
            //GetSet if the attendee has paid and validate it
            get { return paid; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    paid = value;
                }
                else
                {
                    throw new Exception("Please select a registration type");
                }
            }
        }
        public string Pres
        {
            //GetSet if the attdendee is presenting and validate it
            get { return pres; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    pres = value;
                }
                else
                {
                    throw new Exception("Please if you have paid or not");
                }
            }
        }
        public string PaperTitle
        {
            //GetSet the paper title and validate it
            get { return papertitle; }
            set 
            {
                if (pres == "Yes" && !String.IsNullOrEmpty(value) )
                {
                    papertitle = value;
                }
                else if (pres == "Yes" && String.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid papertitle");
                }
                
            }
        }
       
    }
}