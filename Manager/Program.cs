using Manager.db;
using Manager.form;
using Manager.interfaces;
using Manager.model;
using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string CONNECTION_STRING = @"Data Source=HAI;Initial Catalog=Nhom_12;Integrated Security=True";
        static LoginFrom login;

        [STAThread]
        static void Main()
        {

            Const.FONT_FAMILY = Const.getFont(Properties.Resources.Roboto_Regular).Families[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Const.readDataSave().getUserName() != "" && Const.readDataSave().getPassword() != ""
                && Const.readDataSave().getUserName() != null && Const.readDataSave().getPassword() != null)
            {
                LoginPresenter login = new LoginPresenter(new ViewLogin());
                login.login(Const.readDataSave());
            }
            else
            {
                login = new LoginFrom(new LoginListen());
                Application.Run(login);

            }

        }

        public class LoginListen : LoginListener
        {
            public void gotoSignUp()
            {
            }

            public void loginSuccess()
            {
                login.Close();
                Application.Restart();
                Application.Run(new MainForm());
            }
        }
        public class ViewLogin : ILoginView
        {
            public void onLoginFailure(string message)
            {
                MessageBox.Show(message);
            }

            public void onLoginSuccess(object data)
            {
                CurrentAccount.getInstance().setAccount((UserAccount)data);
                Application.Run(new MainForm());
            }
        }
    }
}
