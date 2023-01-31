namespace CineComplex
{
    public class LoginDetails
    {
        private string ?LoginID;
        private string ?Password;
        private string ?LoginType;
        public LoginDetails(){
            Console.WriteLine("I am LoginDetails");
        }

        public LoginDetails(string lid, string pwd, string loginType){
            LoginID = lid;
            LoginType = loginType;
            Password = pwd;
        }

        public void setLoginID(string lid){
            LoginID = lid;
        }
        public string ?getLoginID(){
            return LoginID;
        }

        public void setLoginType(string loginType){
            LoginType = loginType;
        }

        public string ?getLogintype(){
            return LoginType;
        }

        public void setPassword(string pwd){
            Password = pwd;
        }
        public string ?getPassowrd(){
            return Password;
        }
    }
}