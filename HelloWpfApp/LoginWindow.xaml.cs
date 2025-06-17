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

namespace HelloWpfApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Purpose account is:
            //username: hungthanh
            //password: 10082004
            if(txtUsername.Text == "hungthanh" && txtPassword.Password == "10082004")
            {
                // MainWindow mainWindow = new MainWindow();
                //mainWindow.Show();
                //Close the login window
                //Close();
                //or call
                btnExist.RaiseEvent(e);
            }
            else
            {
                MessageBox.Show("Login failled !!");
            }
        }
    }
}
