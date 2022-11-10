namespace Manager.form.dialog
{
    partial class OptionRightClickDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionRightClickDialog));
            this.update = new System.Windows.Forms.Panel();
            this.ptUpdate = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Panel();
            this.ptDelete = new System.Windows.Forms.PictureBox();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptUpdate)).BeginInit();
            this.delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Controls.Add(this.lbUpdate);
            this.update.Controls.Add(this.ptUpdate);
            this.update.Dock = System.Windows.Forms.DockStyle.Top;
            this.update.Location = new System.Drawing.Point(0, 0);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(4);
            this.update.Size = new System.Drawing.Size(200, 36);
            this.update.TabIndex = 0;
            // 
            // ptUpdate
            // 
            this.ptUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptUpdate.Image = ((System.Drawing.Image)(resources.GetObject("ptUpdate.Image")));
            this.ptUpdate.Location = new System.Drawing.Point(4, 4);
            this.ptUpdate.Name = "ptUpdate";
            this.ptUpdate.Size = new System.Drawing.Size(24, 28);
            this.ptUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptUpdate.TabIndex = 0;
            this.ptUpdate.TabStop = false;
            // 
            // delete
            // 
            this.delete.Controls.Add(this.lbDelete);
            this.delete.Controls.Add(this.ptDelete);
            this.delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(0, 38);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(4);
            this.delete.Size = new System.Drawing.Size(200, 36);
            this.delete.TabIndex = 1;
            // 
            // ptDelete
            // 
            this.ptDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptDelete.Image")));
            this.ptDelete.Location = new System.Drawing.Point(4, 4);
            this.ptDelete.Name = "ptDelete";
            this.ptDelete.Size = new System.Drawing.Size(24, 28);
            this.ptDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptDelete.TabIndex = 0;
            this.ptDelete.TabStop = false;
            // 
            // lbUpdate
            // 
            this.lbUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.Location = new System.Drawing.Point(28, 4);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(168, 28);
            this.lbUpdate.TabIndex = 1;
            this.lbUpdate.Text = "Update";
            this.lbUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUpdate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDelete.Location = new System.Drawing.Point(28, 4);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(168, 28);
            this.lbDelete.TabIndex = 1;
            this.lbDelete.Text = "Delete";
            this.lbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionRightClickDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 74);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionRightClickDialog";
            this.Text = "OptionRightClickDialog";
            this.update.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptUpdate)).EndInit();
            this.delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel update;
        private System.Windows.Forms.PictureBox ptUpdate;
        private System.Windows.Forms.Panel delete;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.PictureBox ptDelete;
    }
}