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
            LoginStack.Children.Add(new LoginControl(_xingMain.getLoginModel(), (string username, string userpas, string certpass) =>
            {
                _xingMain.login(username, userpas, certpass);
                LoginStack.Children.Clear();
            }));
        }
        
        private void t4201_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("real stock click");
            _xingMain.chartT4201();
        }

        private void t4203_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("real stock click");
            _xingMain.chartT4203();
        }

        private void t8414_Click(object sender, RoutedEventArgs e)
        {
            LOG.Info("real stock click");
            _xingMain.chartT8414();
        }

    }
}
