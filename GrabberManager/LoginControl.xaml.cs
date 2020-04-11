﻿using System;
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
using XingBot.tr;

namespace GrabberManager
{
    /// <summary>
    /// LoginControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginControl : UserControl
    {
        private string _company;
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
            //TODO Login action parameter
            ((StackPanel) (this.Parent)).Children.Clear();
            // (this.Parent).Children.Clear();
            if (_company == "xing")
            {
                QueryCtrl queryCtrl;
                XingBot.real.SessionEvents session = new SessionEvents(() =>
                {
                    queryCtrl = new QueryCtrl();
                    queryCtrl.QueryInit();
                });
                session.Login(TxtUserName.Text, TxtUserPass.Password, TxtCertPass.Password);
            } else if (_company == "cybos")
            {

            }
        }
    }
}