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

namespace CCS_EMS
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

        //----------------TextBox Section----------------
        private void RemovePlaceholderText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Username")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.White;
            }
        }

        private void RestorePlaceholderText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Username";
                textBox.Foreground = new SolidColorBrush(Color.FromRgb(125, 125, 125));
            }
        }
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPlaceholder.Visibility = Visibility.Collapsed;
            PasswordPlaceholder.IsHitTestVisible = false;
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordBox.Password))
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
                PasswordPlaceholder.IsHitTestVisible = false;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordBox.Password))
            {
                PasswordPlaceholder.Visibility = Visibility.Collapsed;
            }
            else
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }
        //-----------------------------------------------


        private void LOGIN_BUTTON_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            LOGIN_BUTTON.Background = new SolidColorBrush(Color.FromRgb(161, 120, 226));
        }

        private void LOGIN_BUTTON_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            LOGIN_BUTTON.Background = new SolidColorBrush(Color.FromRgb(149, 95, 226));
        }

        private void LOGIN_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameBox.ToString() != "" && PasswordBox.Password.ToString() != "")
            {
                var homePage = new HOME_PAGE();
                homePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the details!", "Error", MessageBoxButton.OK);
            }
        }
    }
}
