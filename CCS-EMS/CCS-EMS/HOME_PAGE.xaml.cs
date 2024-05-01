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
    /// Interaction logic for HOME_PAGE.xaml
    /// </summary>
    public partial class HOME_PAGE : Window
    {
        private EVENT_VIEW ev;
        private EVENT_CREATE ec;
        private MERCH_VIEW mv;
        private MERCH_CREATE mc;
        private bool eventProc = true;
        private bool merchProc = true;
        public HOME_PAGE()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void EVENT_1_BUTTON_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ev == null)
            {
                ev = new EVENT_VIEW();
                ev.Closed += (s, args) => ev = null; // Reset ev to null when the window is closed
                ev.Show();
                this.DARK_BACKGROUND.Visibility = Visibility.Visible;
            }
            else
            {
                ev.Activate();
            }
        }

        private void DARK_BACKGROUND_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ev != null)
            {
                ev.Close();
                // No need to create a new instance of EVENT_VIEW here
                this.DARK_BACKGROUND.Visibility = Visibility.Hidden;
            }
            else if(mv != null)
            {
                mv.Close();
                // No need to create a new instance of EVENT_VIEW here
                this.DARK_BACKGROUND.Visibility = Visibility.Hidden;
            }
        }

        private void CREATE_BUTTON_EVENT_MouseEnter(object sender, MouseEventArgs e)
        {
            CREATE_BUTTON_EVENT.Background = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            this.Cursor = Cursors.Hand;
        }

        private void CREATE_BUTTON_EVENT_MouseLeave(object sender, MouseEventArgs e)
        {
            CREATE_BUTTON_EVENT.Background = new SolidColorBrush(Colors.Transparent);
            this.Cursor = Cursors.Arrow;
        }

        private void CREATE_BUTTON_EVENT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ec == null)
            {
                // Pass a reference to the HOME_PAGE window to EVENT_CREATE constructor
                ec = new EVENT_CREATE(this);
                ec.Closed += (s, args) => ec = null; // Reset ec to null when the window is closed
                ec.Show();
                this.DARK_BACKGROUND.Visibility = Visibility.Visible;
            }
            else
            {
                ec.Activate();
            }

        }

        private void EVENT_ACTION_BUTTON_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(eventProc) 
            {
                EVENT_MENU.Visibility = Visibility.Visible;
                eventProc = false;
            }
            else 
            {
                EVENT_MENU.Visibility = Visibility.Hidden;
                eventProc = true;
            }
        }

        private void MERCH_ACTION_BUTTON_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (merchProc)
            {
                MERCH_MENU.Visibility = Visibility.Visible;
                merchProc = false;
            }
            else
            {
                MERCH_MENU.Visibility = Visibility.Hidden;
                merchProc = true;
            }
        }

        private void MERCH_1_BUTTON_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (mv == null)
            {
                mv = new MERCH_VIEW();
                mv.Closed += (s, args) => mv = null; // Reset ev to null when the window is closed
                mv.Show();
                this.DARK_BACKGROUND.Visibility = Visibility.Visible;
            }
            else
            {
                mv.Activate();
            }
        }

        private void CREATE_BUTTON_MERCH_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (mc == null)
            {
                // Pass a reference to the HOME_PAGE window to EVENT_CREATE constructor
                mc = new MERCH_CREATE(this);
                mc.Closed += (s, args) => mc = null; // Reset ec to null when the window is closed
                mc.Show();
                this.DARK_BACKGROUND.Visibility = Visibility.Visible;
            }
            else
            {
                mc.Activate();
            }
        }
    }
}
