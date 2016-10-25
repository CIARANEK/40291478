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

            //Adds items to the types of registration 
            cmbreg.Items.Add("Full");
            cmbreg.Items.Add("Student");
            cmbreg.Items.Add("Organiser");
        }
        private void btninvoice_Click(object sender, RoutedEventArgs e)
        {
            // Shows the Invoice window once the button is clicked
            Invoice newWin = new Invoice();
            newWin.Show();
        }

        private void btncert_Click(object sender, RoutedEventArgs e)
        {
            //Shows the Certificate window once the button is clicked
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
            txtpaper_title.Text = string.Empty;
           
        }

        private void btnset_Click(object sender, RoutedEventArgs e)
        {
            //Creates new attendee instance
            myAttendee = new Attendee();

            myAttendee.AttendeeRef = int.Parse(txtattend_ref.Text);
            myAttendee.FirstName = txtfirst_name.Text;
            myAttendee.SecondName = txtsecond_name.Text;
            myAttendee.Institution = txtinsti.Text;
            myAttendee.Confer_Name = txtcon_name.Text;
            myAttendee.Registration = Convert.ToString(cmbreg.SelectedItem);
            if (rbpaid_yes.IsChecked == true)
                myAttendee.Paid = Convert.ToString(rbpaid_yes.Content);
            else
                if (rbpaid_no.IsChecked == true)
                    myAttendee.Paid = Convert.ToString(rbpaid_no.Content);
            if (rbpres_yes.IsChecked == true)
               myAttendee.Pres = Convert.ToString(rbpaid_yes.Content);
            else
                if (rbpres_no.IsChecked == true)
                   myAttendee.Pres = Convert.ToString(rbpres_no.Content);
            myAttendee.PaperTitle = txtpaper_title.Text;
        }

        private void btnget_Click(object sender, RoutedEventArgs e)
        {
            txtattend_ref.Text = Convert.ToString(myAttendee.AttendeeRef);
            txtfirst_name.Text = myAttendee.FirstName;
            txtsecond_name.Text = myAttendee.SecondName;
            txtinsti.Text = myAttendee.Institution;
            txtcon_name.Text = myAttendee.Confer_Name;
            //cmbreg.SelectedItem = myAttendee.Institution;
            //
            //
            txtpaper_title.Text = myAttendee.PaperTitle;

        }
    }
    
}
