using System;

namespace UnitTestLoginPage
{
    public class UserData
    {
       public int UserID { set; get; }
       public string LoginName { set; get; }
       public string Password { set; get; }

        public Boolean Login(String loginName, string password)
        {
            var dbUser = new DALUserInfo();
            UserID = dbUser.LogIn(loginName, password);
            if (UserID > 0)
            {
                LoginName = loginName;
                Password = password;
                return true;
            }
            else
                return false;
        }

        public Boolean IfUserNameNotBlank(String loginName)
        {
            if (loginName.Length == 0 )
            {
                return false;
            }
            return true;
        }

        public Boolean IfPasswordNotBlank(String password)
        {
            if (password.Length == 0)
                return false;
            return true;
        }

        public Boolean IfLongEnough(String password)
        {
            if (password.Length < 6 && password.Length > 0)
                return false;
            return true;
        }
    }
}