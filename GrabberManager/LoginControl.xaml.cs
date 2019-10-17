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
using GrabberManager.model;

namespace GrabberManager
{
    /// <summary>
    /// LoginControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl(LoginModel loginModel)
        {
            InitializeComponent();
            TxtUserName.Text = loginModel.UserName;
            TxtUserPass.Text = loginModel.UserPass;
            TxtCertPass.Text = loginModel.CertPass;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO Login action parameter
            ((StackPanel) (this.Parent)).Children.Clear();
            // (this.Parent).Children.Clear();
        }
    }
}