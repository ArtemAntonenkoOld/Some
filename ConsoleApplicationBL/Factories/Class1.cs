using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Factories
{
    public class BaseUser
    {
        protected string login;
        protected string pass;

        public string GetPass() { return pass; }
        public string GetLogin() { return login; }

        public string Login
        {
            set { login = value; }
            get { return login; }
        }

        public string Pass
        {
            set { pass = value; }
            get { return pass; }
        }

        public BaseUser(string login, string pass) { Login = login; Pass = pass; }
    }

    sealed public class SimpleUser : BaseUser
    {
        public SimpleUser(string login, string pass) : base(login, pass) { }
        public void Opera() { MessageBox.Show("SimpleUser!" + login + " -> " + pass); }
    }

    sealed public class AdminUser : BaseUser
    {
        public AdminUser(string login, string pass) : base(login, pass) { }
        public void Opera() { MessageBox.Show("AdminUser!" + login + " -> " + pass); }
    }

    public class FactoryUser
    {
        public static BaseUser CreateUser(int type, string login, string pass)
        {
            switch (type)
            {
                case 1: return new SimpleUser(login, pass);
                case 2: return new AdminUser(login, pass);
            }
            return new BaseUser("", "");
        }
    }

}
