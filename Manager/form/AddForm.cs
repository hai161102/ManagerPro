using Manager.interfaces;
using Manager.model;
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
    public partial class AddForm : Form
    {
        private OnViewControlListener onViewControlListener;
        public AddForm(OnViewControlListener viewControlListener)
        {
            this.onViewControlListener = viewControlListener;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

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
            string sex = (maleRadio.Checked) ? "Nam" : "Nu";
            ChiNhanh chiNhanh = new ChiNhanh();
            chiNhanh.MaChiNhanh = tbMaChiNhanh.Text.Trim();
            ChucVu chuc = new ChucVu();
            chuc.MaChucVu = tbLevel.Text.Trim();
            Luong luong = new Luong();
            luong.BacLuong = Int32.Parse(tbBacluong.Text);
            NhanVien nhanvien = new NhanVien(
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
            onViewControlListener.onAgree(new object[] { nhanvien });
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onViewControlListener.onCancel();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            onViewControlListener.onCancel();
        }
    }
}
