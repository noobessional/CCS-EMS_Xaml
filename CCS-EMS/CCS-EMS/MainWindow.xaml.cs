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
            if (textBox != null && textBox.Text == "ID" || textBox.Text == "Last Name" || textBox.Text == "First Name" || textBox.Text == "Email")
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
                textBox.Text = "ID";
                textBox.Foreground = new SolidColorBrush(Color.FromRgb(125, 125, 125));
            }
        }
        private void RestorePlaceholderTextLNAME(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Last Name";
                textBox.Foreground = new SolidColorBrush(Color.FromRgb(125, 125, 125));
            }
        }
        private void RestorePlaceholderTextFNAME(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "First Name";
                textBox.Foreground = new SolidColorBrush(Color.FromRgb(125, 125, 125));
            }
        }
        private void RestorePlaceholderTextEMAIL(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Last Name";
                textBox.Foreground = new SolidColorBrush(Color.FromRgb(125, 125, 125));
            }
        }
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox != null)
            {
                if (passwordBox.Name == "PASSWORD_BOX_REG")
                {
                    PASSWORD_PLACEHOLDER_REG.Visibility = Visibility.Collapsed;
                    PASSWORD_PLACEHOLDER_REG.IsHitTestVisible = false;
                }
                else if (passwordBox.Name == "PASSWORD_BOX_REG_CON")
                {
                    PASSWORD_PLACEHOLDER_REG_CON.Visibility = Visibility.Collapsed;
                    PASSWORD_PLACEHOLDER_REG_CON.IsHitTestVisible = false;
                }
                else if (passwordBox.Name == "PASSWORD_BOX_LOGIN")
                {
                    PASSWORD_PLACEHOLDER_LOGIN.Visibility = Visibility.Collapsed;
                    PASSWORD_PLACEHOLDER_LOGIN.IsHitTestVisible = false;
                }
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox != null)
            {
                if (passwordBox.Name == "PASSWORD_BOX_REG")
                {
                    if (string.IsNullOrEmpty(passwordBox.Password))
                    {
                        PASSWORD_PLACEHOLDER_REG.Visibility = Visibility.Visible;
                        PASSWORD_PLACEHOLDER_REG.IsHitTestVisible = false;
                    }
                }
                else if (passwordBox.Name == "PASSWORD_BOX_REG_CON")
                {
                    if (string.IsNullOrEmpty(passwordBox.Password))
                    {
                        PASSWORD_PLACEHOLDER_REG_CON.Visibility = Visibility.Visible;
                        PASSWORD_PLACEHOLDER_REG_CON.IsHitTestVisible = false;
                    }
                }
                else if (passwordBox.Name == "PASSWORD_BOX_LOGIN")
                {
                    if (string.IsNullOrEmpty(passwordBox.Password))
                    {
                        PASSWORD_PLACEHOLDER_LOGIN.Visibility = Visibility.Visible;
                        PASSWORD_PLACEHOLDER_LOGIN.IsHitTestVisible = false;
                    }
                }
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox != null)
            {
                if (passwordBox.Name == "PASSWORD_BOX_REG")
                {
                    if (!string.IsNullOrEmpty(passwordBox.Password))
                    {
                        PASSWORD_PLACEHOLDER_REG.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        PASSWORD_PLACEHOLDER_REG.Visibility = Visibility.Visible;
                    }
                }
                else if (passwordBox.Name == "PASSWORD_BOX_REG_CON")
                {
                    if (!string.IsNullOrEmpty(passwordBox.Password))
                    {
                        PASSWORD_PLACEHOLDER_REG.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        PASSWORD_PLACEHOLDER_REG.Visibility = Visibility.Visible;
                    }
                }
                else if (passwordBox.Name == "PASSWORD_BOX_LOGIN")
                {
                    if (!string.IsNullOrEmpty(passwordBox.Password))
                    {
                        PASSWORD_PLACEHOLDER_LOGIN.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        PASSWORD_PLACEHOLDER_LOGIN.Visibility = Visibility.Visible;
                    }
                }
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

        private void REG_BUTTON_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LOGIN_AREA.Visibility = Visibility.Hidden;
            REGISTER_AREA.Visibility = Visibility.Visible;
        }

        private void REG_BACK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LOGIN_AREA.Visibility = Visibility.Visible;
            REGISTER_AREA.Visibility = Visibility.Hidden;
        }

        private void REG_BUTTON_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void REG_BUTTON_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
    }
}
