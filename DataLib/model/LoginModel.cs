namespace GrabberManager.model
{
    public class LoginModel
    {
        public LoginModel(string userName, string userPass, string certPass)
        {
            this.UserName = userName;
            this.UserPass = userPass;
            this.CertPass = certPass;
        }

        public string UserName { get; private set; }
        public string UserPass { get; private set; }
        public string CertPass { get; private set; }
    }
}