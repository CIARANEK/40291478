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
        Invoice newWin;
        Attendee myAttendee;
        public MainWindow()
        {

            InitializeComponent();

            //Adds items to the types of registration 
            cmbreg.Items.Add("Full");
            cmbreg.Items.Add("Student");
            cmbreg.Items.Add("Organiser");
            cmbpaid.Items.Add("Yes");
            cmbpaid.Items.Add("No");
            cmbpres.Items.Add("Yes");
            cmbpres.Items.Add("No");
        }
        private void btninvoice_Click(object sender, RoutedEventArgs e)
        {
            // Shows the Invoice window once the button is clicked
            //Validates the registration type
                decimal check = getCost();
                if (check == -1)
                    MessageBox.Show("Please select a registration type");
                else
                {
                    newWin = new Invoice(txtfirst_name.Text,txtsecond_name.Text, txtinsti.Text, txtcon_name.Text, getCost());
                    newWin.Show();
                }       
        }

        private void btncert_Click(object sender, RoutedEventArgs e)
        {
            //Shows the Certificate window once the button is clicked
            Certificate newWin = new Certificate(txtfirst_name.Text, txtsecond_name.Text, txtcon_name.Text, txtpaper_title.Text, cmbpres.Text);
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
            cmbpaid.SelectedItem = null;
            cmbpres.SelectedItem = null;
            txtpaper_title.Text = string.Empty;

        }

        private void btnset_Click(object sender, RoutedEventArgs e)
        {
            //Creates new attendee instance
            try
            {
                myAttendee = new Attendee();

                myAttendee.AttendeeRef = txtattend_ref.Text;
                myAttendee.FirstName = txtfirst_name.Text;
                myAttendee.SecondName = txtsecond_name.Text;
                myAttendee.Institution = txtinsti.Text;
                myAttendee.Confer_Name = txtcon_name.Text;
                myAttendee.Registration = Convert.ToString(cmbreg.SelectedItem);
                myAttendee.Paid = Convert.ToString(cmbpaid.SelectedItem);
                myAttendee.Pres = Convert.ToString(cmbpres.SelectedItem);
                myAttendee.PaperTitle = txtpaper_title.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnget_Click(object sender, RoutedEventArgs e)
        {
            //Fills the form with data from the attendee class
            txtattend_ref.Text = Convert.ToString(myAttendee.AttendeeRef);
            txtfirst_name.Text = myAttendee.FirstName;
            txtsecond_name.Text = myAttendee.SecondName;
            txtinsti.Text = myAttendee.Institution;
            txtcon_name.Text = myAttendee.Confer_Name;
            cmbreg.Text = myAttendee.Registration;
            cmbpaid.Text = myAttendee.Paid;
            cmbpres.Text = myAttendee.Pres;
            txtpaper_title.Text = myAttendee.PaperTitle;

        }

        public decimal getCost()
        {
            //Works out the amount to be paid by the attendee
            if (cmbreg.Text == "Full")
            {
                if (cmbpres.Text == "Yes")
                {
                    return 450;
                }
                else if (cmbpres.Text == "No")
                {
                    return 500;
                }
                else
                {
                    return -1;
                }
            }
            else if (cmbreg.Text == "Student")
                {
                    if (cmbpres.Text == "Yes")
                    {
                        return 270;
                    }
                    else if (cmbpres.Text == "No")
                    {
                        return 300;
                    }
                    else
                    {
                        return -1;
                    }
                }

            else if (cmbreg.Text == "Organiser")
            {
                return 0;
            }
            else
            {
                return -1;

            }
        }      
    }
}
