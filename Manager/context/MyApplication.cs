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
    public class MyApplication : ApplicationContext, ILoginView, FormListener, LoginListener
    {
        private LoginFrom loginFrom;
        private HomeForm homeForm;
        private LoginPresenter loginPresenter;
        private bool isLogOut = false;


        public MyApplication()
        {
            homeForm = HomeForm.getInstance();
            homeForm.setFormListener(this);
            loginFrom = new LoginFrom(this);
            loginPresenter = new LoginPresenter(this);
            homeForm.FormClosed += HomeForm_FormClosed;
            homeForm.FormClosing += onFormClose;
            Const.FONT_FAMILY = Const.getFont(Properties.Resources.Roboto_Regular).Families[0];
            if (Const.readDataSave().getUserName() != "" && Const.readDataSave().getPassword() != ""
                && Const.readDataSave().getUserName() != null && Const.readDataSave().getPassword() != null)
            {
                loginPresenter.login(Const.readDataSave());
            }
            else
            {
                loginFrom.Show();
            }

        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            base.OnMainFormClosed(sender, e);
        }

        private void onFormClose(object sender, FormClosingEventArgs e)
        {
        }

        public void setMainForm(Form form)
        {
            this.MainForm = form;
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogOut)
            {
                ExitThread();
            }
        }

        public void onLoginSuccess(object data)
        {
            CurrentAccount.getInstance().setAccount((UserAccount)data);
            homeForm.Show();
        }

        public void onLoginFailure(string message)
        {
            MessageBox.Show(message);
        }

        public void onClose(string key, object value)
        {
            if (key == "Logout")
            {
                loginFrom = new LoginFrom(this);
                loginFrom.Show();
                isLogOut = true;
                homeForm.Close();

            }
        }

        public void loginSuccess()
        {
            homeForm.Show();
            if (loginFrom != null)
            {
                loginFrom.Close();

            }
        }

        public void gotoSignUp()
        {
            
        }

    }
}
