using Syntra.Services;
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

namespace SyntraDesktop
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            txtUsername.Focus();
        }
        
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Wilt u zeker de applicatie afsluiten?", "Applicatie afsluiten", 
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string _username = txtUsername.Text;
                string _pwd = txtPassword.Password;
                
                if (AuthServices.Authenticate(_username, _pwd))
                {
                    MainWindow _main = new MainWindow();
                    _main.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("De logingegevens zijn incorrect");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Fout bij inloggen", MessageBoxButton.OK, MessageBoxImage.Error);
                txtUsername.Focus();
            }
        }
    }
}
