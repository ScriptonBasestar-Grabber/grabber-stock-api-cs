using DataLib.model;
using log4net;
using XingBot.real;
using XingBot.tr;

namespace XingBot
{
    public class Main
    {
        protected static readonly ILog LOG = LogManager.GetLogger("XingBot.Main");

        QueryCtrl _queryCtrl;
        RealCtrl _realCtrl;

        public Main()
        {
            _queryCtrl = new QueryCtrl();
            _realCtrl = new RealCtrl();
        }

        public LoginModel getLoginModel()
        {
            return new LoginModel(
                Properties.Settings.Default.username ?? "",
                Properties.Settings.Default.userpass ?? "",
                Properties.Settings.Default.certpass ?? ""
                );
        }

        public void login(string username, string userpass, string certpass)
        {
            Properties.Settings.Default.username = username;
            Properties.Settings.Default.userpass = userpass;
            Properties.Settings.Default.certpass = certpass;
            Properties.Settings.Default.Save();
            SessionEvents session = new SessionEvents(() =>
            {
                _queryCtrl = new QueryCtrl();
                _queryCtrl.QueryInit();
            });
            session.Login(username, userpass, certpass);
        }

        public void chartT4201()
        {
            _queryCtrl.QueryT4201();
        }

        public void chartT4203()
        {
            _queryCtrl.QueryT4203();
        }

        public void chartT8414()
        {
            _queryCtrl.QueryT8414();
        }

    }
}
