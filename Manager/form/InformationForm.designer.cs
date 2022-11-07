namespace Manager.form
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnLeftADay = new System.Windows.Forms.Button();
            this.btnCalculatorSalary = new System.Windows.Forms.Button();
            this.btnManagerInfo = new System.Windows.Forms.Button();
            this.manager = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.infoManagerID = new System.Windows.Forms.Label();
            this.infoManagerHometown = new System.Windows.Forms.Label();
            this.infoManagerDOB = new System.Windows.Forms.Label();
            this.infoManagerSex = new System.Windows.Forms.Label();
            this.infoManagerState = new System.Windows.Forms.Label();
            this.infoManagerLevel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoManagerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangePass);
            this.groupBox2.Controls.Add(this.btnLeftADay);
            this.groupBox2.Controls.Add(this.btnCalculatorSalary);
            this.groupBox2.Controls.Add(this.btnManagerInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 372);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnChangePass
            // 
            this.btnChangePass.AutoSize = true;
            this.btnChangePass.Location = new System.Drawing.Point(0, 217);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(10);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(160, 33);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnLeftADay
            // 
            this.btnLeftADay.AutoSize = true;
            this.btnLeftADay.Location = new System.Drawing.Point(0, 178);
            this.btnLeftADay.Margin = new System.Windows.Forms.Padding(10);
            this.btnLeftADay.Name = "btnLeftADay";
            this.btnLeftADay.Size = new System.Drawing.Size(160, 33);
            this.btnLeftADay.TabIndex = 2;
            this.btnLeftADay.Text = "Xin nghỉ phép";
            this.btnLeftADay.UseVisualStyleBackColor = true;
            // 
            // btnCalculatorSalary
            // 
            this.btnCalculatorSalary.AutoSize = true;
            this.btnCalculatorSalary.Location = new System.Drawing.Point(0, 139);
            this.btnCalculatorSalary.Margin = new System.Windows.Forms.Padding(10);
            this.btnCalculatorSalary.Name = "btnCalculatorSalary";
            this.btnCalculatorSalary.Size = new System.Drawing.Size(160, 33);
            this.btnCalculatorSalary.TabIndex = 1;
            this.btnCalculatorSalary.Text = "Tính Lương";
            this.btnCalculatorSalary.UseVisualStyleBackColor = true;
            this.btnCalculatorSalary.Click += new System.EventHandler(this.bt_tinhluong_Click);
            // 
            // btnManagerInfo
            // 
            this.btnManagerInfo.AutoSize = true;
            this.btnManagerInfo.Location = new System.Drawing.Point(0, 100);
            this.btnManagerInfo.Margin = new System.Windows.Forms.Padding(10);
            this.btnManagerInfo.Name = "btnManagerInfo";
            this.btnManagerInfo.Size = new System.Drawing.Size(160, 33);
            this.btnManagerInfo.TabIndex = 0;
            this.btnManagerInfo.Text = "Hồ sơ NV";
            this.btnManagerInfo.UseVisualStyleBackColor = true;
            this.btnManagerInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // manager
            // 
            this.manager.BackColor = System.Drawing.Color.LightGray;
            this.manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manager.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.manager.Location = new System.Drawing.Point(0, 0);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(1056, 100);
            this.manager.TabIndex = 17;
            this.manager.Text = "Manager";
            this.manager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma NV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ho Ten";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Que Quan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngay Sinh";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gioi tinh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chi Nhanh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Chuc Vu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoManagerID
            // 
            this.infoManagerID.AutoSize = true;
            this.infoManagerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoManagerID.Location = new System.Drawing.Point(132, 46);
            this.infoManagerID.Name = "infoManagerID";
            this.infoManagerID.Size = new System.Drawing.Size(58, 21);
            this.infoManagerID.TabIndex = 8;
            this.infoManagerID.Text = "Ma NV";
            this.infoManagerID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoManagerHometown
            // 
            this.infoManagerHometown.AutoSize = true;
            this.infoManagerHometown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoManagerHometown.Location = new System.Drawing.Point(133, 161);
            this.infoManagerHometown.Name = "infoManagerHometown";
            this.infoManagerHometown.Size = new System.Drawing.Size(81, 21);
            this.infoManagerHometown.TabIndex = 10;
            this.infoManagerHometown.Text = "Que Quan";
            this.infoManagerHometown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoManagerDOB
            // 
            this.infoManagerDOB.AutoSize = true;
            this.infoManagerDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoManagerDOB.Location = new System.Drawing.Point(418, 85);
            this.infoManagerDOB.Name = "infoManagerDOB";
            this.infoManagerDOB.Size = new System.Drawing.Size(82, 21);
            this.infoManagerDOB.TabIndex = 11;
            this.infoManagerDOB.Text = "Ngay Sinh";
            this.infoManagerDOB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoManagerSex
            // 
            this.infoManagerSex.AutoSize = true;
            this.infoManagerSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoManagerSex.Location = new System.Drawing.Point(418, 124);
            this.infoManagerSex.Name = "infoManagerSex";
            this.infoManagerSex.Size = new System.Drawing.Size(69, 21);
            this.infoManagerSex.TabIndex = 12;
            this.infoManagerSex.Text = "Gioi tinh";
            this.infoManagerSex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoManagerState
            // 
            this.infoManagerState.AutoSize = true;
            this.infoManagerState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoManagerState.Location = new System.Drawing.Point(416, 46);
            this.infoManagerState.Name = "infoManagerState";
            this.infoManagerState.Size = new System.Drawing.Size(84, 21);
            this.infoManagerState.TabIndex = 13;
            this.infoManagerState.Text = "Chi Nhanh";
            this.infoManagerState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoManagerLevel
            // 
            this.infoManagerLevel.AutoSize = true;
            this.infoManagerLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoManagerLevel.Location = new System.Drawing.Point(132, 124);
            this.infoManagerLevel.Name = "infoManagerLevel";
            this.infoManagerLevel.Size = new System.Drawing.Size(68, 21);
            this.infoManagerLevel.TabIndex = 14;
            this.infoManagerLevel.Text = "Chuc Vu";
            this.infoManagerLevel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.infoManagerLevel);
            this.groupBox1.Controls.Add(this.infoManagerState);
            this.groupBox1.Controls.Add(this.infoManagerSex);
            this.groupBox1.Controls.Add(this.infoManagerDOB);
            this.groupBox1.Controls.Add(this.infoManagerHometown);
            this.groupBox1.Controls.Add(this.infoManagerName);
            this.groupBox1.Controls.Add(this.infoManagerID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(816, 372);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // infoManagerName
            // 
            this.infoManagerName.AutoSize = true;
            this.infoManagerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoManagerName.Location = new System.Drawing.Point(133, 85);
            this.infoManagerName.Name = "infoManagerName";
            this.infoManagerName.Size = new System.Drawing.Size(57, 21);
            this.infoManagerName.TabIndex = 9;
            this.infoManagerName.Text = "Ho Ten";
            this.infoManagerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(200, 412);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 512);
            this.panel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 100);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(856, 412);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.manager);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 100);
            this.panel3.TabIndex = 18;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hồ sơ nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformationForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnLeftADay;
        private System.Windows.Forms.Button btnCalculatorSalary;
        private System.Windows.Forms.Button btnManagerInfo;
        private System.Windows.Forms.Label manager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label infoManagerID;
        private System.Windows.Forms.Label infoManagerHometown;
        private System.Windows.Forms.Label infoManagerDOB;
        private System.Windows.Forms.Label infoManagerSex;
        private System.Windows.Forms.Label infoManagerState;
        private System.Windows.Forms.Label infoManagerLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label infoManagerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}