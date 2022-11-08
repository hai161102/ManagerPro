using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.form
{
    public partial class ChangePasswordForm : Form, IDataView
    {

        private DatabasePresenter databasePresenter;
        public ChangePasswordForm()
        {
            databasePresenter = new DatabasePresenter(this);
            InitializeComponent();
        }

        private void accept_change_Click(object sender, EventArgs e)
        {
            if (warnning.Visible)
            {
                return;
            }
            if (CurrentAccount.getInstance().getAccount().getPassword() == currentPass.Text)
            {
                if (newPass.Text != "" && confirmPass.Text != "")
                {
                    if (newPass.Text == confirmPass.Text)
                    {
                        databasePresenter.getManagerDao().changePassword(CurrentAccount.getInstance().getAccount(), confirmPass.Text);
                    }
                    else
                    {
                        warnning.Text = "Incorrect confirm!";
                        warnning.ForeColor = Color.Red;
                        warnning.Visible = true;
                    }
                }
                else
                {
                    warnning.Text = "Fiel is not empty!";
                    warnning.ForeColor = Color.Red;
                    warnning.Visible = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void onDoneFocus(object sender, EventArgs e)
        {
            if (CurrentAccount.getInstance().getAccount().getPassword() != currentPass.Text)
            {
                warnning.Text = "Current password incorrect!";
                warnning.ForeColor = Color.Red;
                warnning.Visible = true;
            }
            else
            {
                warnning.Visible = false;
            }
        }

        public void onResultSuccess(object data)
        {
            if (data.GetType() == typeof(string))
            {
                if (data == "updateSuccess")
                {
                    CurrentAccount.getInstance().getAccount().setPassword(confirmPass.Text);
                    Const.saveData(CurrentAccount.getInstance().getAccount());
                    this.Close();
                }
            }
        }

        public void onResultError(string message)
        {
            warnning.Text = message;
            warnning.ForeColor = Color.Red;
            warnning.Visible = true;
        }

        private void onNewPassDone(object sender, EventArgs e)
        {
            if (newPass.Text.Contains(" "))
            {
                warnning.Text = "Password can't contain space";
                warnning.ForeColor = Color.Red;
                warnning.Visible = true;
            }
            else warnning.Visible = false;
        }

        private void onConfirmDone(object sender, EventArgs e)
        {
            if (confirmPass.Text.Contains(" "))
            {
                warnning.Text = "Password can't contain space";
                warnning.ForeColor = Color.Red;
                warnning.Visible = true;
            }
            else warnning.Visible = false;
        }
    }
}
