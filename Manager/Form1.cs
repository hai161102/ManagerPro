using Manager.form;
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
    public partial class Form1 : Form, IDataView
    {
        private static LoginForm loginForm = new LoginForm();
        private string LOGIN = "Login";
        private string SIGN_IN = "Sign Up";
        private string NORMAL = "Normal";
        private string ADMIN = "Admin";
        private List<String> listSearch = new List<String>();
        private DatabasePresenter databasePresenter;
        private static string columTag = "";
        private List<string> lTableView = new List<string> ();
        private List<NhanVien> listNhanVien = new List<NhanVien> ();
        private List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>(); 

        public Form1()
        {
            InitializeComponent();
            databasePresenter = new DatabasePresenter(this);
            listNhanVien = databasePresenter.getManagerDao().getNhanVienList();
            var list = new BindingList<NhanVien>(listNhanVien);
            dataGridView.DataSource = list;
        }

        private void showSignInView(object sender, EventArgs e)
        {
            
        }

        private void showLoginView(object sender, EventArgs e)
        {
            loginForm.onCloseClick = new AfterCLoseView(this);
            loginForm.Show();
            this.Enabled = false;
        }


        private void setViewNormal()
        {
            this.Enabled = true;
            if (CurrentAccount.getInstance().getAccount() == null)
            {
                this.accountOption1.Text = LOGIN;
                this.accountOption1.Name = LOGIN;
                this.accountOption2.Text = SIGN_IN;
                this.accountOption2.Name = SIGN_IN;

                this.accountOption1.Click += showLoginView;
                this.accountOption2.Click += showSignInView;
            }
            else
            {
                this.accountOption1.Text = NORMAL;
                this.accountOption1.Name = NORMAL;
                this.accountOption2.Text = ADMIN;
                this.accountOption2.Name = ADMIN;

                this.accountOption1.Click += setUserNormalView;
                this.accountOption2.Click += setUserAdminView;

            }
        }

        private void setUserAdminView(object sender, EventArgs e)
        {
            
        }

        private void setUserNormalView(object sender, EventArgs e)
        {
            
        }

        private class AfterCLoseView : OnClickListener
        {
            private Form1 form1;

            public AfterCLoseView(Form1 form1)
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
            columTag = menuItem.Name;
            databasePresenter.search(menuItem.Name);
        }

        public void onResultSuccess(object data)
        {
            
        }

        public void onResultError(string message)
        {
            
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
            AddForm add = new AddForm();
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
            this.search.DropDownItems.Clear();
            listSearch.Clear();
            menuItems.Clear();
            PropertyInfo[] map = GetAuthors<NhanVien>();
            foreach (PropertyInfo item in map)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(item.Name);
                toolStripMenuItem.Name = item.Name;
                menuItems.Add(toolStripMenuItem);
                listSearch.Add(item.Name);
            }
            menuItems.ForEach(item =>
            {
                this.search.DropDownItems.Add(item);
            });
        }

        //private List<NhanVien> getList()
        //{
        //    return new List<NhanVien>()
        //    {
        //        new NhanVien(0, "CN1", "Tran Hai", "0946197396", "QL", new DateTime(), "Nam Dinh", 2.5f),
        //        new NhanVien(0, "CN1", "Tran Hai", "0946197396", "QL", new DateTime(), "Nam Dinh", 2.5f),
        //        new NhanVien(0, "CN1", "Tran Hai", "0946197396", "QL", new DateTime(), "Nam Dinh", 2.5f),
        //        new NhanVien(0, "CN1", "Tran Hai", "0946197396", "QL", new DateTime(), "Nam Dinh", 2.5f),
        //        new NhanVien(0, "CN1", "Tran Hai", "0946197396", "QL", new DateTime(), "Nam Dinh", 2.5f),
        //        new NhanVien(0, "CN1", "Tran Hai", "0946197396", "QL", new DateTime(), "Nam Dinh", 2.5f),
        //        new NhanVien(0, "CN1", "Tran Hai", "0946197396", "QL", new DateTime(), "Nam Dinh", 2.5f)
        //    };
        //}
    }
}
