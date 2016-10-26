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
using System.Windows.Shapes;

namespace _40291478
{
    /// <summary>
    /// Interaction logic for Certificate.xaml
    /// </summary>
    /// //Ciaran McMahon
    /// //40291478
    public partial class Certificate : Window
        
    {
        public Certificate(string frst, string sec, string con, string pap, string pres)
        {
            //Works out which message to display depending on if the attendee is presenting
            InitializeComponent();

            if (pres == "No")
            {
                lblcert.Content = ("This is to certify that " + frst +"" + sec + " attended " + con);
            }
            else
            {
                lblcert.Content = ("This is to certify that " + frst +""+ sec + " attended " + con 
                    +Environment.NewLine +"and presented a paper entitled " +pap);
            }
        }
        
        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            // Closes the certificate window
            this.Close();
        }
        }
    }

