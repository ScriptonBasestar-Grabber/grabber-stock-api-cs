using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using XingBot.real;
using XingBot.res;
using XingBot.tr;

namespace GrabberManager
{
    /// <summary>
    /// LoginControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginControl : UserControl
    {
        private string _company;
        private Tr_t4201 _queryTr4201;

        public LoginControl(string company, LoginModel loginModel)
        {
            InitializeComponent();

            this._company = company;

            TxtUserName.Text = loginModel.UserName;
            TxtUserPass.Password = loginModel.UserPass;
            TxtCertPass.Password = loginModel.CertPass;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((StackPanel)this.Parent).Children.Clear();
            if (_company == "xing")
            {
            } else if (_company == "cybos")
            {

            }
        }
    }
}