using Manager.interfaces;
using Manager.model;
using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.form
{
    public partial class LoginFrom : Form, ILoginView
    {
        LoginPresenter databasePresenter;
        private AccountManager account;
        private LoginListener loginListener;

        public LoginFrom()
        {
            InitializeComponent();
            databasePresenter = new LoginPresenter(this);
        }

        public LoginFrom(LoginListener loginListener)
        {
            this.loginListener = loginListener;
            InitializeComponent();
           
            databasePresenter = new LoginPresenter(this);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string pass = tbPass.Text.Trim();
            account = new AccountManager();
            account.setUserName(username);
            account.setPassword(pass);
            databasePresenter.login(account);
        }

        private void signup_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void remember_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }

        public void onLoginSuccess(object data)
        {
            CurrentAccount.getInstance().setAccount((UserAccount)data);
            if (remember.Checked)
            {
                Const.saveData(account);
            }
            if (loginListener != null)
            {
                loginListener.loginSuccess();
            }
        }

        public void onLoginFailure(string message)
        {
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
