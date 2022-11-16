using Manager.interfaces;
using Manager.model;
using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Manager.form
{
    public partial class AddForm : Form, IDataView
    {
        private OnViewControlListener onViewControlListener;
        private ChiNhanh chiNhanh;
        private ChucVu chuc;
        private Luong luong;
        private DatabasePresenter databasePresenter;
        private List<ChiNhanh> chiNhanhs = new List<ChiNhanh>();
        private List<Luong> luongList = new List<Luong>();
        private List<ChucVu> chucVuList = new List<ChucVu>();
        private NhanVien nhanvien;

        public AddForm(OnViewControlListener viewControlListener)
        {
            databasePresenter = new DatabasePresenter(this);
            this.onViewControlListener = viewControlListener;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            databasePresenter.getManagerDao().getListChiNhanh();
            databasePresenter.getManagerDao().getListChucVu();
            databasePresenter.getManagerDao().getListLuong();
            userGenerate.Text = "";
            passGenerate.Text = "";
            setViewComboPermission();
            
        }

        private void setViewComboPermission()
        {
            permissionGenerate.Items.Add(Permission.MANAGER);
            permissionGenerate.Items.Add(Permission.COMPANY_BRANCH);
            permissionGenerate.Items.Add(Permission.COMPANY);
            permissionGenerate.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            radio.Checked = maleRadio.Checked;
            femaleRadio.Checked = !maleRadio.Checked;
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            maleRadio.Checked = !femaleRadio.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            onViewControlListener.onCancel();
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addButton.Text == "OK")
            {
                onViewControlListener.onAgree(new NhanVien[] {nhanvien});
                return;
            }
            if (isFullFeil() )
            {

                string sex = (maleRadio.Checked) ? "Nam" : "Nữ";
                chiNhanh = new ChiNhanh();
                chiNhanh.MaChiNhanh = chiNhanhs[cbBranch.SelectedIndex].MaChiNhanh;

                chuc = new ChucVu();
                chuc.MaChucVu = chucVuList[cbPosition.SelectedIndex].MaChucVu;

                
                luong = new Luong();
                luong.BacLuong = luongList[cbSalaryLevel.SelectedIndex].BacLuong;


                nhanvien = new NhanVien(
                        -1,
                        tbName.Text.Trim(),
                        tbNumber.Text.Trim(),
                        dateOfBirth.Value,
                        sex,
                        tbHometown.Text.Trim(),
                        chiNhanh,
                        chuc,
                        luong
                    );
                databasePresenter.addMember(nhanvien);
            }
            
        }

        private bool isFullFeil()
        {
            return (maleRadio.Checked || femaleRadio.Checked)
                && tbName.Text != ""
                && tbNumber.Text != ""
                && tbHometown.Text != ""
                ;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbNumber.Clear();
            tbHometown.Clear();
            
        }

        public void onResultSuccess(object data)
        {
        }

        public void onResultError(string message)
        {
            MessageBox.Show(message);
        }

        public void onResultSuccess(object data, string key)
        {
            
            if (key == "all_chi_nhanh")
            {
                chiNhanhs.AddRange((IEnumerable<ChiNhanh>)data);
                cbBranch.Items.Clear();
                cbBranch.Items.AddRange(chiNhanhs.ToArray());
                cbBranch.SelectedIndex = 0;
            }
            else if (key == "all_chuc_vu")
            {
                chucVuList.AddRange((IEnumerable<ChucVu>)data);
                cbPosition.Items.Clear();
                cbPosition.Items.AddRange(chucVuList.ToArray());
                cbPosition.SelectedIndex = 0;

            }
            else if (key == "all_luong")
            {
                luongList.AddRange((IEnumerable<Luong>)data);
                cbSalaryLevel.Items.Clear();
                cbSalaryLevel.Items.AddRange(luongList.ToArray());
                cbSalaryLevel.SelectedIndex = 0;
            }
            else if (key == "insert_success")
            {
                addButton.Enabled = false;
                NhanVien nhan = data as NhanVien;
                if (nhan != null)
                {

                    userGenerate.Text = $"manager{nhan.Id}";
                    passGenerate.Text = userGenerate.Text;
                    UserAccount user = new UserAccount(userGenerate.Text, passGenerate.Text, permissionGenerate.SelectedText, nhan);
                    databasePresenter.getManagerDao().createAccount(user);
                }
            }
            else if (key == "add_account_done")
            {

                addButton.Enabled = true;
                addButton.Text = "OK";
            }

        }
    }
}
