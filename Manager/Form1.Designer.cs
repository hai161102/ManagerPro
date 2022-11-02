using System.Collections.Generic;
using System.Windows.Forms;

namespace Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ListView listView;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
       

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.option = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.update = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.account = new System.Windows.Forms.ToolStripMenuItem();
            this.accountOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountOption2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.signin = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.title_login = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option,
            this.account});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // option
            // 
            this.option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search,
            this.add,
            this.update,
            this.delete,
            this.view,
            this.exit,
            this.toolStripSeparator4});
            resources.ApplyResources(this.option, "option");
            this.option.Name = "option";
            this.option.Click += new System.EventHandler(this.toolStripMenuItem1_Click_2);
            // 
            // search
            // 
            this.search.Name = "search";
            resources.ApplyResources(this.search, "search");
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            this.add.Name = "add";
            resources.ApplyResources(this.add, "add");
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Name = "update";
            resources.ApplyResources(this.update, "update");
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            resources.ApplyResources(this.delete, "delete");
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // view
            // 
            this.view.Name = "view";
            resources.ApplyResources(this.view, "view");
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            resources.ApplyResources(this.exit, "exit");
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // account
            // 
            this.account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountOption1,
            this.accountOption2});
            resources.ApplyResources(this.account, "account");
            this.account.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.account.Name = "account";
            this.account.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // accountOption1
            // 
            this.accountOption1.Name = "accountOption1";
            resources.ApplyResources(this.accountOption1, "accountOption1");
            this.accountOption1.Click += new System.EventHandler(this.accountOption1_Click);
            // 
            // accountOption2
            // 
            this.accountOption2.Name = "accountOption2";
            resources.ApplyResources(this.accountOption2, "accountOption2");
            this.accountOption2.Click += new System.EventHandler(this.accountOption2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // noAccount
            // 
            this.noAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.noAccount, "noAccount");
            this.noAccount.Name = "noAccount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_pass);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.title_login);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlAdded);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.signup);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // signup
            // 
            resources.ApplyResources(this.signup, "signup");
            this.signup.Name = "signup";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.signin);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // signin
            // 
            resources.ApplyResources(this.signin, "signin");
            this.signin.Name = "signin";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // tb_pass
            // 
            resources.ApplyResources(this.tb_pass, "tb_pass");
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            // 
            // tb_user
            // 
            resources.ApplyResources(this.tb_user, "tb_user");
            this.tb_user.Name = "tb_user";
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // pass
            // 
            resources.ApplyResources(this.pass, "pass");
            this.pass.Name = "pass";
            // 
            // user_name
            // 
            resources.ApplyResources(this.user_name, "user_name");
            this.user_name.Name = "user_name";
            // 
            // title_login
            // 
            resources.ApplyResources(this.title_login, "title_login");
            this.title_login.Name = "title_login";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noAccount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void setupListView()
        //{
        //    List<ColumnHeader> list = new List<ColumnHeader>();
        //    foreach (var item in getListHeaderItem())
        //    {
        //        list.Add(new ColumnHeader(item));
        //    }
        //    list.ForEach(item =>
        //    {
        //        this.listView1.Columns.Add(item);
        //    });
        //    this.SuspendLayout();
        //}
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem option;
        private ToolStripMenuItem search;
        private ToolStripMenuItem add;
        private ToolStripMenuItem update;
        private ToolStripMenuItem delete;
        private ToolStripMenuItem view;
        private ToolStripMenuItem exit;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem account;
        private ToolStripMenuItem accountOption1;
        private ToolStripMenuItem accountOption2;
        private DataGridView dataGridView1;
        private Label noAccount;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button signin;
        private TextBox tb_pass;
        private TextBox tb_user;
        private Label pass;
        private Label user_name;
        private Label title_login;
        private Button signup;
    }
}

