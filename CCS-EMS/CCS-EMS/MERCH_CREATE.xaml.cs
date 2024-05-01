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

namespace CCS_EMS
{
    /// <summary>
    /// Interaction logic for MERCH_CREATE.xaml
    /// </summary>
    public partial class MERCH_CREATE : Window
    {
        private HOME_PAGE hp;
        public MERCH_CREATE(HOME_PAGE hp)
        {
            InitializeComponent();
            this.hp = hp;
            loadAll();
        }
        private static string GetCurrentDateFormatted()
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Format the date as "MMM dd, yyyy"
            string formattedDate = currentDate.ToString("MMM dd, yyyy");

            return formattedDate;
        }
        private void loadAll()
        {
            CREATE_END_DATE_NAME_TXT.Text = GetCurrentDateFormatted();
        }

        private void CREATE_MERCH_CANCEL_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            // Use the reference to HOME_PAGE to access its DARK_BACKGROUND element and change its visibility
            if (hp != null)
            {
                hp.DARK_BACKGROUND.Visibility = Visibility.Hidden;
            }
        }
    }
}
