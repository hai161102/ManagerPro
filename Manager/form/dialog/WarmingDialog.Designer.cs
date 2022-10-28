using System;
using System.Drawing;
using System.Windows.Forms;

namespace Manager.form.dialog
{
    partial class WarmingDialog
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

        private Label titleDialog;
        private Label text;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            setupView();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "WarmingDialog";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void setupView()
        {
            
            this.SuspendLayout();
        }

        private void setupLabel(Label label, int fontSize, FontFamily fontFamily, Color color)
        {
            label.Font = new System.Drawing.Font(fontFamily, fontSize);
            label.ForeColor = color;
        }

        #endregion
    }
}