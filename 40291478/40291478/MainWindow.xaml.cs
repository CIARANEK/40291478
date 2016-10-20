using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _40291478
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Ciaran McMahon
    /// 40291478
    public partial class MainWindow : Window
    {
        Attendee myAttendee;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btninvoice_Click(object sender, RoutedEventArgs e)
        {
            // Creates the Invoice window once the button is clicked
            Invoice newWin = new Invoice();
            newWin.Show();
        }

        private void btncert_Click(object sender, RoutedEventArgs e)
        {
            //Creates the Certificate window once the button is clicked
            Certificate newWin = new Certificate();
            newWin.Show();
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            //Clears all data the user has selected/inputted
            txtattend_ref.Text = string.Empty;
            txtfirst_name.Text = string.Empty;
            txtsecond_name.Text = string.Empty;
            txtinsti.Text = string.Empty;
            txtcon_name.Text = string.Empty;
            cmbreg.SelectedItem = null;
            rbpaid_yes.IsChecked = false;
            rbpaid_no.IsChecked = false;
            rbpres_yes.IsChecked = false;
            rbpres_no.IsChecked = false;
           
        }

        private void btnset_Click(object sender, RoutedEventArgs e)
        {
            //Creates new attendee instance
            myAttendee = new Attendee();

            myAttendee.AttendeeRef = txtattend_ref.Text;
            myAttendee.FirstName = txtfirst_name.Text;
            myAttendee.SecondName = txtfirst_name.Text;
            myAttendee.Institution = txtinsti.Text;
            myAttendee.Confer_Name = txtcon_name.Text;
            myAttendee.Registration = cmbreg.SelectedItem;
        }
        
       
    }
    class Attendee : MainWindow
    {
        private string attendeeref;
        private string firstname;
        private string secondname;
        private string institution;
        private string confer_name;
        private string registration;
        private bool paid;
        private bool pres;
        private string papertitle;
       
        
        public string AttendeeRef
        {
            get{return attendeeref;}
            set{attendeeref= value;}
            
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string SecondName
        {
            get{return secondname; }
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
    }
}
