using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Manager.model;
using static Manager.form.ChangePasswordForm;

namespace Manager.form
{
    public partial class InformationForm : Form, OnActionCallback
    {
        private NhanVien nhanVien = new NhanVien();
        public InformationForm()
        {
            InitializeComponent();
        }
        public InformationForm(NhanVien nhanVien)
        {
            this.nhanVien = nhanVien; 
            InitializeComponent();
        }
        static TinhLuongForm FormTinhLuong = new TinhLuongForm();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InformationForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_tinhluong_Click(object sender, EventArgs e)
        {
            FormTinhLuong.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm(this);
            this.ParentForm.Hide();
            changePassword.Show();
        }

        
        private void onLoad(object sender, EventArgs e)
        {

            infoManagerID.Text = nhanVien.Id.ToString();
            infoManagerName.Text = nhanVien.HoTen.ToString();
            infoManagerLevel.Text = nhanVien.ChucVu.ChucVuName;
            infoManagerHometown.Text = nhanVien.QueQuan;
            infoManagerSex.Text = nhanVien.GioiTinh;
            infoManagerDOB.Text = nhanVien.NgaySinh.ToString("dd/MM/yyyy");
            infoManagerState.Text = nhanVien.ChiNhanh.TenChiNhanh;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void infoManagerID_Click(object sender, EventArgs e)
        {

        }

        private void infoManagerLevel_Click(object sender, EventArgs e)
        {

        }

        public void callback(string key, object data)
        {
            if (key == "close")
            {
                this.ParentForm.Show();
            }
        }
    }
}
