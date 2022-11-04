using Manager.form;
using Manager.interfaces;
using Manager.model;
using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Windows.Forms;

namespace Manager
{
    public partial class MainForm : Form, IDataView, LoginListener, ILoginView
    {
        private string LOGIN = "Login";
        private string SIGN_UP = "Sign Up";
        private string NORMAL = "Normal";
        private string ADMIN = "Admin";
        private DatabasePresenter databasePresenter;
        private LoginPresenter loginPresenter;
        private List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>(); 
        private BindingSource bindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void showSignInView(object sender, EventArgs e)
        {
            
        }

        private void showLoginView(object sender, EventArgs e)
        {
            loginPresenter = new LoginPresenter(this);
            dataGridView1.Visible = false;
            noAccount.Visible = false;
            panel1.Visible = true;
        }
        //{
        //    loginForm = new LoginForm(this);
        //    loginForm.onCloseClick = new AfterCLoseView(this);
        //    loginForm.Show();
        //    this.Enabled = false;

        private void setViewNormal()
        {
            this.Enabled = true;
            if (CurrentAccount.getInstance().getAccount() == null)
            {
                this.accountOption1.Text = LOGIN;
                this.accountOption1.Name = LOGIN;
                this.accountOption2.Text = SIGN_UP;
                this.accountOption2.Name = SIGN_UP;
                noAccount.Visible = true;
                dataGridView1.Visible = false;
            }
            else
            {
                this.accountOption1.Text = NORMAL;
                this.accountOption1.Name = NORMAL;
                this.accountOption2.Text = ADMIN;
                this.accountOption2.Name = ADMIN;
                noAccount.Visible = false;
                dataGridView1.Visible = true;
                if (databasePresenter == null)
                {
                    databasePresenter = new DatabasePresenter(this);
                }
                switch (CurrentAccount.getInstance().getAccount().getPermission())
                {
                    case 1:
                        setViewAdmin();
                        break;
                    case 2:
                        setViewNormalUser();
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void setViewNormalUser()
        {

        }

        private void setViewAdmin()
        {

        }

        private class AfterCLoseView : OnClickListener
        {
            private MainForm form1;

            public AfterCLoseView(MainForm form1)
            {
                this.form1 = form1;
            }

            public void OnClick(EventArgs e)
            {
                form1.setViewNormal();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deletMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        public static PropertyInfo[] GetAuthors<T>()
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            return props;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            databasePresenter.search(menuItem.Name);
        }

        public void onResultSuccess(object data)
        {
            List<NhanVien> nhanViens = (List<NhanVien>)data;
            setDataSource(nhanViens);
        }

        public void onResultError(string message)
        {
            MessageBox.Show(message);
        }

        private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm(new ViewControlAddForm(this));
            add.Show();
        }
        private void update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            setViewNormal();
            
        }

        private List<ToolStripMenuItem> getListMenu(Type propertyInfo)
        {
            List<ToolStripMenuItem> listMenu = new List<ToolStripMenuItem>();

            if (propertyInfo.IsClass && propertyInfo != typeof(string))
            {
                foreach (PropertyInfo item in propertyInfo.GetProperties())
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(item.Name);
                    toolStripMenuItem.Name = item.Name;
                    toolStripMenuItem.DropDownItems.AddRange(getListMenu(item.PropertyType).ToArray());
                    listMenu.Add(toolStripMenuItem);
                }
            }
            return listMenu;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loginSuccess()
        {
            //setDataSource(CurrentAccount.getInstance().getAccount().getNhanVien());
            if (databasePresenter == null)
            {
                databasePresenter = new DatabasePresenter(this);
            }
            databasePresenter.getManagerDao().getNhanVienList(CurrentAccount.getInstance().getAccount().getNhanVien().Id);
        }

        public void gotoSignUp()
        {

        }
        private void setDataSource<T>(List<T> datas)
        {
            bindingSource.Clear();
            foreach (T item in datas)
            {
                bindingSource.Add(item);
            }
            this.search.DropDownItems.Clear();
            menuItems.Clear();
            menuItems.AddRange(getListMenu(typeof(T)));
            this.search.DropDownItems.AddRange(menuItems.ToArray());
            dataGridView1.DataSource = bindingSource;
            setViewNormal();
        }
        private void setDataSource<T>(T datas)
        {
            bindingSource.Clear();
            bindingSource.Add(datas);

            this.search.DropDownItems.Clear();
            menuItems.Clear();
            menuItems.AddRange(getListMenu(typeof(T)));
            this.search.DropDownItems.AddRange(menuItems.ToArray());
            dataGridView1.DataSource = bindingSource;
            setViewNormal();
        }

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            AccountManager account = new AccountManager();
            account.setUserName(tb_user.Text.Trim());
            account.setPassword(tb_pass.Text.Trim());
            loginPresenter.login(account);
        }

        private void signup_Click(object sender, EventArgs e)
        {

        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        public void onLoginSuccess(object data)
        {
            this.panel1.Visible = false;
            this.dataGridView1.Visible = true;
            CurrentAccount.getInstance().setAccount((UserAccount)data);
            if (databasePresenter == null)
            {
                databasePresenter = new DatabasePresenter(this);
            }

            databasePresenter.getManagerDao().getNhanVienList(CurrentAccount.getInstance().getAccount().getNhanVien().Id);
        }

        public void onLoginFailure(string message)
        {
        }

        private void accountOption2_Click(object sender, EventArgs e)
        {
            if (accountOption2.Name == ADMIN)
            {
                databasePresenter.getManagerDao().getNhanVienList();
            }
            if (accountOption2.Name == SIGN_UP)
            {

            }
        }

        private void accountOption1_Click(object sender, EventArgs e)
        {
            if (accountOption1.Name == LOGIN)
            {
                //showLoginView(sender, e);
                LoginFrom login = new LoginFrom();
                login.Show();
            }
            if (accountOption1.Name == NORMAL)
            {

            }
        }

        private class ViewControlAddForm : OnViewControlListener
        {
            MainForm form;

            public ViewControlAddForm(MainForm form)
            {
                this.form = form;
            }


            public void onAgree(object[] datas)
            {
                form.databasePresenter.addMember(datas[0]);
            }

            public void onCancel()
            {
                
            }
        }
    }
}
