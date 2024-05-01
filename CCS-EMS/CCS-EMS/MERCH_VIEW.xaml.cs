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
    /// Interaction logic for MERCH_VIEW.xaml
    /// </summary>
    public partial class MERCH_VIEW : Window
    {
        private bool clickMenu = true;
        public MERCH_VIEW()
        {
            InitializeComponent();
        }

        private void EDIT_BUTTON_MouseEnter(object sender, MouseEventArgs e)
        {
            EDIT_BUTTON.Background = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            this.Cursor = Cursors.Hand;
        }

        private void EDIT_BUTTON_MouseLeave(object sender, MouseEventArgs e)
        {
            EDIT_BUTTON.Background = new SolidColorBrush(Colors.Transparent);
            this.Cursor = Cursors.Arrow;
        }

        private void EDIT_BUTTON_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MERCH_VIEW_PAN.Visibility = Visibility.Hidden;
            EDIT_PAN.Visibility = Visibility.Visible;
            MENUS.Visibility = Visibility.Hidden;
        }

        private void ARCHIVE_BUTTON_MouseEnter(object sender, MouseEventArgs e)
        {
            ARCHIVE_BUTTON.Background = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            this.Cursor = Cursors.Hand;
        }

        private void ARCHIVE_BUTTON_MouseLeave(object sender, MouseEventArgs e)
        {
            ARCHIVE_BUTTON.Background = new SolidColorBrush(Colors.Transparent);
            this.Cursor = Cursors.Arrow;
        }

        private void MERCH_ACTION_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            if (clickMenu)
            {
                MENUS.Visibility = Visibility.Visible;
                clickMenu = false;
            }
            else
            {
                MENUS.Visibility = Visibility.Hidden;
                clickMenu = true;
            }
        }

        private void EDIT_MERCH_CANCEL_BUTTON_Click(object sender, RoutedEventArgs e)
        {
                MERCH_VIEW_PAN.Visibility = Visibility.Visible;
                EDIT_PAN.Visibility = Visibility.Hidden;
        }
    }
}
