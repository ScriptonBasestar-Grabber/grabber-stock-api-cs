using log4net;
using System.Windows;

namespace GrabberManager
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        protected static readonly ILog LOG = LogManager.GetLogger("MainWindow");

        private XingBot.Main _xingMain;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CybosLogin_Click(object sender, RoutedEventArgs e)
        {
            //LoginStack.Children.Clear();
            //TODO set saved value
            //LoginStack.Children.Add(new LoginControl("cybos", loginModel));
        }

        private void XingLogin_Click(object sender, RoutedEventArgs e)
        {
            _xingMain = new XingBot.Main();
            LoginStack.Children.Clear();
            LoginStack.Children.Add(new LoginControl(_xingMain.getLoginModel(), (string username, string userpass, string certpass) =>
            {
                _xingMain.login(username, userpass, certpass, delegate
                {
                    t4201.IsEnabled = true;
                    t4203.IsEnabled = true;
                    t8414.IsEnabled = true;
                });
                LoginStack.Children.Clear();
            }));
        }

        private void t4201_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("query stock click");
            _xingMain.ChartT4201();
        }

        private void t4203_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("query upjong click");
            _xingMain.ChartT4203();
        }

        private void t8414_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("query fuop click");
            _xingMain.ChartT8414();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("real futures click");
            _xingMain.RealFutures();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LOG.Info("real options click");
            _xingMain.RealOptions();
        }
    }
}
