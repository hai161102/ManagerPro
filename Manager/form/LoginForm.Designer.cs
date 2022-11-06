using Manager.view;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Manager.form
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ButtonView imageView;
        private Image image;
        private ButtonView signInButton;
        private ButtonView signUpButton;
        public const string CANCEL_BUTTON = "CANCEL_BUTTON";
        public OnClickListener onCloseClick;
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
    }
}
