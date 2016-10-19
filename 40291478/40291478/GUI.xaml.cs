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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Ciaran McMahon
        //40291478
        //Coursework1
        
       
        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            //Clears all data the user has inputted 
            txtattend_ref.Text = string.Empty;
            txtfirst_name.Text = string.Empty;
            txtsecond_name.Text = string.Empty;
            txtinsti_name.Text = string.Empty;
            txtcon_name.Text = string.Empty;
            cmbreg_type.Items.Clear();
            rbpaid_yes.Checked = false;
            rbpaid_no.Checked = false;
            rbpres_yes.Checked = false;
            rbpres_no.Checked = false;
            txtpaper_title.Text = string.Empty;
        }

    }     
}
