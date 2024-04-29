namespace CineComplex.models
{
    public class Credential
    {
        private string? _loginID;
        private string? _password;
        public Credential()
        {
            Console.WriteLine("I am LoginDetails");
        }

        public Credential(string lid, string pwd, string loginType)
        {
            LoginID = lid;
            Password = pwd;
        }

        public string? LoginID { get => _loginID; set => _loginID = value; }
        public string? Password { get => _password; set => _password = value; }
    }
}