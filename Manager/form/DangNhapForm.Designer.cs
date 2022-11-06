namespace Manager.form
{
    partial class DangNhapForm
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
            this.tb_tkhoan = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_quenmk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_tkhoan
            // 
            this.tb_tkhoan.Location = new System.Drawing.Point(147, 66);
            this.tb_tkhoan.Multiline = true;
            this.tb_tkhoan.Name = "tb_tkhoan";
            this.tb_tkhoan.Size = new System.Drawing.Size(231, 25);
            this.tb_tkhoan.TabIndex = 1;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(147, 129);
            this.tb_matkhau.Multiline = true;
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(231, 25);
            this.tb_matkhau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Location = new System.Drawing.Point(147, 219);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(88, 23);
            this.bt_dangnhap.TabIndex = 5;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            // 
            // bt_quenmk
            // 
            this.bt_quenmk.Location = new System.Drawing.Point(276, 219);
            this.bt_quenmk.Name = "bt_quenmk";
            this.bt_quenmk.Size = new System.Drawing.Size(102, 23);
            this.bt_quenmk.TabIndex = 6;
            this.bt_quenmk.Text = "Quên Mật Khẩu";
            this.bt_quenmk.UseVisualStyleBackColor = true;
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 308);
            this.Controls.Add(this.bt_quenmk);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_tkhoan);
            this.Controls.Add(this.label1);
            this.Name = "DangNhapForm";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tkhoan;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_quenmk;
    }
}