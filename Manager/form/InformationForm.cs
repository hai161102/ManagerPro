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
namespace Manager.form
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }
        static InformationForm FormHoSo = new InformationForm();
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
    }
}
