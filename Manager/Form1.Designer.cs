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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void setupListView()
        {
            this.listView = new ListView();
            this.SuspendLayout();
        }
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
        private DataGridView dataGridView;
    }
}

