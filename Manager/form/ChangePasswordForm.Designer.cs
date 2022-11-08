using System;

namespace Manager.form
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.viewAction = new System.Windows.Forms.Panel();
            this.currentPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.Label();
            this.current_pass = new System.Windows.Forms.Label();
            this.accept_change = new System.Windows.Forms.Button();
            this.warnning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.viewAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.close1;
            this.pictureBox1.InitialImage = global::Manager.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // viewAction
            // 
            this.viewAction.Controls.Add(this.currentPass);
            this.viewAction.Controls.Add(this.newPass);
            this.viewAction.Controls.Add(this.confirmPass);
            this.viewAction.Controls.Add(this.label2);
            this.viewAction.Controls.Add(this.new_password);
            this.viewAction.Controls.Add(this.current_pass);
            this.viewAction.Location = new System.Drawing.Point(13, 184);
            this.viewAction.Name = "viewAction";
            this.viewAction.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.viewAction.Size = new System.Drawing.Size(275, 122);
            this.viewAction.TabIndex = 2;
            // 
            // currentPass
            // 
            this.currentPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPass.Location = new System.Drawing.Point(109, 14);
            this.currentPass.Name = "currentPass";
            this.currentPass.Size = new System.Drawing.Size(163, 15);
            this.currentPass.TabIndex = 5;
            this.currentPass.TextChanged += new System.EventHandler(this.currentPass_TextChanged);
            this.currentPass.Leave += new System.EventHandler(this.onDoneFocus);
            // 
            // newPass
            // 
            this.newPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(109, 55);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(163, 15);
            this.newPass.TabIndex = 4;
            this.newPass.Leave += new System.EventHandler(this.onNewPassDone);
            // 
            // confirmPass
            // 
            this.confirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.Location = new System.Drawing.Point(109, 95);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(163, 15);
            this.confirmPass.TabIndex = 3;
            this.confirmPass.Leave += new System.EventHandler(this.onConfirmDone);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm Password";
            // 
            // new_password
            // 
            this.new_password.AutoSize = true;
            this.new_password.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password.Location = new System.Drawing.Point(4, 55);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(80, 13);
            this.new_password.TabIndex = 1;
            this.new_password.Text = "New Password";
            // 
            // current_pass
            // 
            this.current_pass.AutoSize = true;
            this.current_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_pass.Location = new System.Drawing.Point(4, 14);
            this.current_pass.Name = "current_pass";
            this.current_pass.Size = new System.Drawing.Size(95, 13);
            this.current_pass.TabIndex = 0;
            this.current_pass.Text = "Current Password";
            // 
            // accept_change
            // 
            this.accept_change.BackColor = System.Drawing.Color.Chartreuse;
            this.accept_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept_change.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_change.Location = new System.Drawing.Point(13, 367);
            this.accept_change.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.accept_change.Name = "accept_change";
            this.accept_change.Size = new System.Drawing.Size(275, 30);
            this.accept_change.TabIndex = 3;
            this.accept_change.Text = "Change";
            this.accept_change.UseVisualStyleBackColor = false;
            this.accept_change.Click += new System.EventHandler(this.accept_change_Click);
            // 
            // warnning
            // 
            this.warnning.AutoSize = true;
            this.warnning.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnning.Location = new System.Drawing.Point(17, 319);
            this.warnning.Name = "warnning";
            this.warnning.Size = new System.Drawing.Size(0, 13);
            this.warnning.TabIndex = 4;
            this.warnning.Visible = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.warnning);
            this.Controls.Add(this.accept_change);
            this.Controls.Add(this.viewAction);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.viewAction.ResumeLayout(false);
            this.viewAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel viewAction;
        private System.Windows.Forms.TextBox currentPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label new_password;
        private System.Windows.Forms.Label current_pass;
        private System.Windows.Forms.Button accept_change;
        private System.Windows.Forms.Label warnning;
    }
}