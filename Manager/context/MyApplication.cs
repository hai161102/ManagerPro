using Manager.form;
using Manager.interfaces;
using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.context
{
    public class MyApplication : ApplicationContext
    {
        private static LoginFrom loginFrom;
        private static MainForm mainForm;
        private LoginPresenter loginPresenter;

        public MyApplication()
        {
            mainForm = new MainForm();
            mainForm.FormClosed += MainForm_FormClosed;
            Const.FONT_FAMILY = Const.getFont(Properties.Resources.Roboto_Regular).Families[0];
            if (Const.readDataSave().getUserName() != "" && Const.readDataSave().getPassword() != ""
                && Const.readDataSave().getUserName() != null && Const.readDataSave().getPassword() != null)
            {
                loginPresenter = new LoginPresenter(new ViewLogin());
                loginPresenter.login(Const.readDataSave());
            }
            else
            {
                loginFrom = new LoginFrom(new LoginFromListener());
                loginFrom.Show();
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ExitThread();
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
                mainForm.Show();
            }
        }

        private class LoginFromListener : LoginListener
        {


            public void gotoSignUp()
            {
            }

            public void loginSuccess()
            {
                mainForm.Show();
                if (loginFrom != null)
                {
                    loginFrom.Close();

                }

            }
        }
    }
}
