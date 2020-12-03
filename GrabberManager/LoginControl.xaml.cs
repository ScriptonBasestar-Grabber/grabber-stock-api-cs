using DataLib.model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace GrabberManager
{
    /// <summary>
    /// LoginControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public delegate void LoginClickCallback(string username, string userpas, string certpass);

        private LoginClickCallback _callback;

        public LoginControl(LoginModel loginModel, LoginClickCallback callback)
        {
            InitializeComponent();

            TxtUserName.Text = loginModel.UserName;
            TxtUserPass.Password = loginModel.UserPass;
            TxtCertPass.Password = loginModel.CertPass;
            _callback = callback;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Login Button Click");
            _callback(TxtUserName.Text, TxtUserPass.Password, TxtCertPass.Password);
        }
    }
}
