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
using log4net;
using XingBot.real;
using XingBot.tr;

namespace GrabberManager
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        protected static readonly ILog LOG = LogManager.GetLogger("MainWindow");
        private LoginModel loginModel;
        QueryCtrl _queryCtrl;
        RealCtrl _realCtrl;
        public MainWindow()
        {
            InitializeComponent();
            loginModel = new LoginModel("username", "userpass", "certpass");

            _queryCtrl = new QueryCtrl();
            _realCtrl = new RealCtrl();
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

        private void t4201_Click(object sender, RoutedEventArgs e)
        {
            _queryCtrl.QueryT4201();
        }

        private void RealStock_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("real stock click");
            _realCtrl.RealStockALL();
            _realCtrl.RealStockKOSPI();
            _realCtrl.RealStockKOSDAQ();
        }

        private void RealFutures_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RealOptions_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
