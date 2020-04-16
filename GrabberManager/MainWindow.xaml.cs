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
using XingBot.tr;

namespace GrabberManager
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginModel loginModel;
        QueryCtrl queryCtrl;
        public MainWindow()
        {
            InitializeComponent();
            loginModel = new LoginModel("username", "userpass", "certpass");
        }

        private void CybosLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginStack.Children.Clear();
            // TODO set saved value
            LoginStack.Children.Add(new LoginControl("cybos", loginModel));
        }

        private void XingLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginStack.Children.Clear();
            // TODO set saved value
            LoginStack.Children.Add(new LoginControl("xing", loginModel));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            queryCtrl = new QueryCtrl();
            queryCtrl.QueryT4201();
        }
    }
}
