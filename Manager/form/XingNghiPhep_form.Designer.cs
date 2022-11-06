namespace Manager.form
{
    partial class XingNghiPhep_form
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
            this.tbox_maNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lydo = new System.Windows.Forms.TextBox();
            this.bt_guidon = new System.Windows.Forms.Button();
            this.dtime_ngaynghi = new System.Windows.Forms.DateTimePicker();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(225, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn xin nghỉ";
            // 
            // tbox_maNV
            // 
            this.tbox_maNV.Location = new System.Drawing.Point(177, 72);
            this.tbox_maNV.Name = "tbox_maNV";
            this.tbox_maNV.Size = new System.Drawing.Size(300, 20);
            this.tbox_maNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã NV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày xin nghỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lý do";
            // 
            // tb_lydo
            // 
            this.tb_lydo.Location = new System.Drawing.Point(177, 189);
            this.tb_lydo.Multiline = true;
            this.tb_lydo.Name = "tb_lydo";
            this.tb_lydo.Size = new System.Drawing.Size(300, 59);
            this.tb_lydo.TabIndex = 6;
            // 
            // bt_guidon
            // 
            this.bt_guidon.Location = new System.Drawing.Point(402, 287);
            this.bt_guidon.Name = "bt_guidon";
            this.bt_guidon.Size = new System.Drawing.Size(75, 23);
            this.bt_guidon.TabIndex = 7;
            this.bt_guidon.Text = "Gửi Đơn";
            this.bt_guidon.UseVisualStyleBackColor = true;
            // 
            // dtime_ngaynghi
            // 
            this.dtime_ngaynghi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_ngaynghi.Location = new System.Drawing.Point(177, 134);
            this.dtime_ngaynghi.Name = "dtime_ngaynghi";
            this.dtime_ngaynghi.Size = new System.Drawing.Size(300, 20);
            this.dtime_ngaynghi.TabIndex = 8;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Location = new System.Drawing.Point(177, 287);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 23);
            this.bt_quaylai.TabIndex = 9;
            this.bt_quaylai.Text = "Quay Lại";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            // 
            // XingNghiPhep_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 382);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.dtime_ngaynghi);
            this.Controls.Add(this.bt_guidon);
            this.Controls.Add(this.tb_lydo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_maNV);
            this.Controls.Add(this.label1);
            this.Name = "XingNghiPhep_form";
            this.Text = "Xin nghỉ Phép";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_maNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lydo;
        private System.Windows.Forms.Button bt_guidon;
        private System.Windows.Forms.DateTimePicker dtime_ngaynghi;
        private System.Windows.Forms.Button bt_quaylai;
    }
}