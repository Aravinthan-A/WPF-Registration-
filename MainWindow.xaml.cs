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

namespace Error
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String First = "Aravinthan";
        String Second = "5555";
        int retry = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtname.Text == First && pwdpassword.Password == Second)
            {
                MessageBox.Show("Sucessfully Login", "Registration");
            }
            else
            {
                if (retry == 0)
                {
                    MessageBoxResult msgresult = MessageBox.Show("Your User ID and Password is Wrong, Do You Want to Try Again", "Error", MessageBoxButton.YesNoCancel, MessageBoxImage.Error);
                    if (msgresult == MessageBoxResult.Yes)
                    {
                        retry = retry + 1;
                    }
                }
                else if (retry == 1)
                {
                    MessageBoxResult msgresult = MessageBox.Show("Your User ID and Password is Wrong, Do You Want to Try Again", "Error", MessageBoxButton.YesNoCancel, MessageBoxImage.Error);
                    if (msgresult == MessageBoxResult.Yes)
                    {
                        retry = retry + 1;
                    }
                }
                else if (retry == 2)
                {
                    MessageBoxResult msgresult = MessageBox.Show("Your User ID and Password is Wrong,Last 1 Attempt", "Error", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
                    if (msgresult == MessageBoxResult.Yes)
                    {
                        retry = retry + 1;
                    }
                }
                else if (retry == 3)
                {
                    MessageBoxResult msgresult = MessageBox.Show("To Many Attempt Try Again Later", "Error" , MessageBoxButton.YesNoCancel,MessageBoxImage.Error);
                    if (msgresult == MessageBoxResult.Yes)
                    {
                        txtname.Visibility = Visibility.Hidden;
                        pwdpassword.Visibility = Visibility.Hidden;
                        btnlogin.IsEnabled = false;
                        btnsignup.IsEnabled = false;
                    }

                }
            }
        }
    }
}
    

                

                

            
        
    

