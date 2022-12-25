using Manager.form;
using Manager.form.dialog;
using Manager.interfaces;
using Manager.model;
using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using static Manager.form.SearchForm;

namespace Manager
{
    public partial class HomeForm : Form, IDataView
    {
        private static HomeForm instance;
        private string LOGIN = "Login";
        private string SIGN_UP = "Sign Up";
        private string NORMAL = "Normal";
        private string ADMIN = "Admin";
        private string permission;
        private DatabasePresenter databasePresenter;
        private List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>(); 
        private BindingSource bindingSource = new BindingSource();
        private SearchForm searchForm;
        private static List<NhanVien> nhanViens;
        private static FormListener formListener;

        private HomeForm()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += DataGridView1_CellClick;
        }

        public static HomeForm getInstance()
        {
            if (instance == null)
            {
                instance = new HomeForm();
            }
            return instance;
        }

        public void setFormListener(FormListener listener)
        {
            formListener = listener;
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
                dataGridView1.Visible = false;
            }
            else
            {
                this.accountOption1.Text = NORMAL;
                this.accountOption1.Name = NORMAL;
                this.accountOption2.Text = ADMIN;
                this.accountOption2.Name = ADMIN;
                dataGridView1.Visible = true;
                if (databasePresenter == null)
                {
                    databasePresenter = new DatabasePresenter(this);
                    databasePresenter.getManagerDao().getManagerInformation(CurrentAccount.getInstance().getAccount().getNhanVien().Id);
                    permission = CurrentAccount.getInstance().getAccount().getPermission();
                }
                if (CurrentAccount.getInstance().getAccount().getPermission() == Permission.MANAGER)
                {
                    setViewNormalUser();

                }
                else if (CurrentAccount.getInstance().getAccount().getPermission() == Permission.COMPANY)
                {

                }
            }
        }

        

        private class OnDialogClick : OptionRightClickDialog.OnOptionClick
        {
            private HomeForm HomeForm;

            public OnDialogClick(HomeForm HomeForm)
            {
                this.HomeForm = HomeForm;
            }

            public void onDelete()
            {
            }

            public void onUpdate()
            {
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nhan = nhanViens[e.RowIndex];
            if (nhan == null) return;
            try
            {
                setViewInformation(nhan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setViewNormalUser()
        {
            this.option.Enabled = false;
            this.accountOption2.Enabled = false;
        }

        private void setViewAdmin()
        {
            databasePresenter.getManagerDao().getNhanVienList();
            panelManagerInfo.Visible = false;
            dataGridView1.Visible = true;
        }

        private class AfterCLoseView : OnClickListener
        {
            private HomeForm form1;

            public AfterCLoseView(HomeForm form1)
            {
                this.form1 = form1;
            }

            public void OnClick(EventArgs e)
            {
                form1.setViewNormal();
            }
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
            try
            {
                NhanVien nhanVien = (NhanVien)data;
                setViewInformation(nhanVien);
            }
            catch (Exception e)
            {
                try
                {
                    nhanViens = (List<NhanVien>)data;
                    setDataSource(nhanViens);
                }
                catch (Exception ex)
                {

                }
                
            }
            
        }

        private void setViewInformation(NhanVien nhanVien)
        {
            InformationForm informationForm = new InformationForm(nhanVien);
            informationForm.TopLevel = false;
            informationForm.AutoScroll = true;
            panelManagerInfo.Controls.Clear();
            panelManagerInfo.Controls.Add(informationForm);
            dataGridView1.Visible = false;
            panelManagerInfo.Visible = true;
            informationForm.Show();
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
            add.TopLevel = false;
            add.AutoScroll = true;
            panelManagerInfo.Controls.Clear();
            panelManagerInfo.Controls.Add(add);
            dataGridView1.Visible = false;
            panelManagerInfo.Visible = true;
            add.Show();
        }
        private void update_Click(object sender, EventArgs e)
        {
            setViewAdmin();
            dataGridView1.CellDoubleClick -= DataGridView1_CellClick;
            MessageBox.Show("Click row to update data");
            dataGridView1.CellClick += DataGridView1_CellClick1;

        }

        private void DataGridView1_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = false;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.ReadOnly = true;
            }
            dataGridView1.Rows[e.RowIndex].ReadOnly = false;
            //if (dataGridView1.Rows[e.RowIndex])
            //{

            //}
        }

        private void delete_Click(object sender, EventArgs e)
        {
            setViewAdmin();
            MessageBox.Show("Click row to delete data");
            dataGridView1.CellClick += CellDeleteClick;
        }

        private void CellDeleteClick(object sender, DataGridViewCellEventArgs ex)
        {
            databasePresenter.getManagerDao().deleteData(nhanViens[ex.RowIndex]);
            nhanViens.RemoveAt(ex.RowIndex);
            dataGridView1.Rows.RemoveAt(ex.RowIndex);
            dataGridView1.CellClick -= CellDeleteClick;
        }

        private void removeClickEvent(Control b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.NonPublic | BindingFlags.Instance);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events", BindingFlags.NonPublic| BindingFlags.Instance);

            EventHandlerList eventHandlerList = (EventHandlerList)pi.GetValue(obj, null);
            eventHandlerList.RemoveHandler(obj, eventHandlerList[obj]);
        }

        private void view_Click(object sender, EventArgs e)
        {
            setViewInformation(CurrentAccount.getInstance().getAccount().getNhanVien());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    toolStripMenuItem.Click += onMenuStripClick;
                    listMenu.Add(toolStripMenuItem);
                }
            }
            return listMenu;
        }

        private void onMenuStripClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            if (toolStripMenuItem.DropDownItems.Count <= 0)
            {
                searchByProperty(toolStripMenuItem.Name);
            }
        }


        //public void loginSuccess()
        //{
        //    //setDataSource(CurrentAccount.getInstance().getAccount().getNhanVien());
        //    if (databasePresenter == null)
        //    {
        //        databasePresenter = new DatabasePresenter(this);
        //    }
        //    databasePresenter.getManagerDao().getNhanVienList(CurrentAccount.getInstance().getAccount().getNhanVien().Id);
        //}

        //public void gotoSignUp()
        //{

        //}
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

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        //public void onLoginSuccess(object data)
        //{
        //    this.dataGridView1.Visible = true;
        //    CurrentAccount.getInstance().setAccount((UserAccount)data);
        //    if (databasePresenter == null)
        //    {
        //        databasePresenter = new DatabasePresenter(this);
        //    }

        //    databasePresenter.getManagerDao().getNhanVienList(CurrentAccount.getInstance().getAccount().getNhanVien().Id);
        //}

        //public void onLoginFailure(string message)
        //{
        //}

        private void accountOption2_Click(object sender, EventArgs e)
        {
            if (accountOption2.Name == ADMIN)
            {
                databasePresenter.getManagerDao().getNhanVienList();
                panelManagerInfo.Visible = false;
                dataGridView1.Visible = true;
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
                dataGridView1.Visible=false;
                panelManagerInfo.Visible=true;
            }
        }

        private class ViewControlAddForm : OnViewControlListener
        {
            HomeForm form;

            public ViewControlAddForm(HomeForm form)
            {
                this.form = form;
            }


            public void onAgree(object[] datas)
            {
                form.setViewInformation(form.databasePresenter.getManagerDao().getNhanVien((NhanVien)datas[0]) );
            }

            public void onCancel()
            {
                
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Const.clearData(Const.FILE_NAME);
            formListener.onClose("Logout", null);
        }

        private void searchByProperty(string propertyName)
        {
            List<NhanVien> list = new List<NhanVien>();
            SearchListen searchListen = new SearchListen(list, propertyName, this);
            searchForm = new SearchForm(searchListen);
            searchForm.Show();
        }

        private class SearchListen : SearchListener
        {
            private List<NhanVien> lSearch;
            private string propertySearch;
            private HomeForm form;

            public SearchListen(List<NhanVien> search, string property, HomeForm form)
            {
                this.lSearch = search;
                this.propertySearch = property;
                this.form = form;
            }

            public void onSearchClick(string text)
            {
                search(text);
            }

            public void onTextChange(string text)
            {
                search(text);
            }

            private void search(string text)
            {
                lSearch.Clear();
                nhanViens.ForEach(n => {
                    try
                    {
                        PropertyInfo property = null;
                        object value = null;
                        PropertyInfo[] propertyInfos = n.GetType().GetProperties();
                        if (n.GetType().GetProperty(propertySearch) != null)
                        {
                            property = n.GetType().GetProperty(propertySearch);
                            value = n;
                        }
                        else
                        {
                            foreach (PropertyInfo item in propertyInfos)
                            {
                                if (item.GetType().GetProperty(propertySearch) != null)
                                {
                                    property = item.GetType().GetProperty(propertySearch);
                                    value = property.GetValue(item.GetValue(n, null), null);
                                    break;
                                }
                                
                                
                            }

                        }

                        string data = property.GetValue(value, null).ToString().ToLowerInvariant();
                        data = RemoveSign4VietnameseString(data);
                        if (data.Contains(text.ToLowerInvariant()))
                        {
                            lSearch.Add(n);
                        }
                    }
                    catch (Exception exc)
                    {

                    }
                });
                form.setDataSource(lSearch);
            }

            public List<NhanVien> getList()
            {
                return this.lSearch;
            }

            public void onCancel()
            {
                form.setDataSource(nhanViens);
            }

            private string RemoveSign4VietnameseString(string str)
            {
                for (int i = 1; i < VietnameseSigns.Length; i++)
                {
                    for (int j = 0; j < VietnameseSigns[i].Length; j++)
                        str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
                }
                return str;
            }
            private readonly string[] VietnameseSigns = new string[]
            {

                "aAeEoOuUiIdDyY",

                "áàạảãâấầậẩẫăắằặẳẵ",

                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

                "éèẹẻẽêếềệểễ",

                "ÉÈẸẺẼÊẾỀỆỂỄ",

                "óòọỏõôốồộổỗơớờợởỡ",

                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

                "úùụủũưứừựửữ",

                "ÚÙỤỦŨƯỨỪỰỬỮ",

                "íìịỉĩ",

                "ÍÌỊỈĨ",

                "đ",

                "Đ",

                "ýỳỵỷỹ",

                "ÝỲỴỶỸ"
            };

        }

        private void rowClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            
        }

        public void onResultSuccess(object data, string key)
        {

        }

        private void panelManagerInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
