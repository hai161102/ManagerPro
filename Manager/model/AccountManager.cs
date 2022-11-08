using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class AccountManager
    {
        public static string NORMAL_PERMISSION = "normal";
        public static string ADMIN_PERMISSION = "admin";
        private string username;
        private string password;
        private string permission = NORMAL_PERMISSION;

        public AccountManager(string username, string password, string permission)
        {
            this.username = username;
            this.password = password;
            this.permission = permission;
        }

        public AccountManager()
        {
        }

        public void setUserName(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getUserName()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getPermission()
        {
            return this.permission;
        }
    }
}
