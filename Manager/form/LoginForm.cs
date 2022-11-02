using Manager.interfaces;
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
    public partial class LoginForm : Form
    {
        private LoginListener loginListener;
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(LoginListener loginListener)
        {
            this.loginListener = loginListener;
            InitializeComponent();
        }
    }
}
