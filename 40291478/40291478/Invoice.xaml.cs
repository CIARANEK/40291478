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
    /// Interaction logic for Invoice.xaml
    /// </summary>
    /// //Ciaran McMahon
    /// //40291478
    public partial class Invoice : Window
    {
        public Invoice(string frst,string sec, string inst, string conf,decimal cost)
        {
            
            InitializeComponent();
            //Fills the labels
           lblname.Content = frst;
           lblsecn.Content = sec;
           lblinsti.Content = inst;
           lblcon.Content = conf;
           lblprice.Content = cost;


        }
     

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            //Closes the Invoice window
            this.Close();
        }
    }
}
