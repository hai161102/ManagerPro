using Manager.db;
using Manager.form;
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
        public static List<NhanVien> listNhanVien;
        [STAThread]
        static void Main()
        {

            Const.FONT_FAMILY = Const.getFont(Properties.Resources.Roboto_Regular).Families[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            if (Const.readDataSave().getUserName() != "" && Const.readDataSave().getPassword() != ""
                && Const.readDataSave().getUserName() != null && Const.readDataSave().getPassword() != null)
            {
                LoginPresenter login = new LoginPresenter(new ViewLogin());
                login.login(Const.readDataSave());
            }
            else
            {
                Application.Run(new LoginFrom());
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
