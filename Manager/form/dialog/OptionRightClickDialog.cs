using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.form.dialog
{
    public partial class OptionRightClickDialog : Form
    {
        private Point point;
        private OnOptionClick onOptionClick;
        public OptionRightClickDialog(Point point, OnOptionClick onOptionClick)
        {

            this.point = point;
            this.onOptionClick = onOptionClick;
            InitializeComponent();
            this.Load += onFormLoad;
            

        }

        private void onFormLoad(object sender, EventArgs e)
        {
            this.Location = point;
            this.update.Click += Update_Click;
            this.lbUpdate.Click += Update_Click;
            this.ptUpdate.Click += Update_Click;
            this.delete.Click += Delete_Click;
            this.lbDelete.Click += Delete_Click;
            this.ptDelete.Click += Delete_Click;
            this.BackColor = Color.Gray;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            onOptionClick.onDelete();
            Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            onOptionClick.onUpdate();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public interface OnOptionClick
        {
            void onUpdate();
            void onDelete();
        }
    }
}
