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

        #region Windows Form Designer generated code
        
        

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Image bgImage = Image.FromHbitmap(Properties.Resources.login_bg.GetHbitmap());
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "LoginForm";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.TransparencyKey = Color.Magenta;
            //this.BackColor = Color.Magenta;
            this.SetStyle(ControlStyles.UserPaint, true);

            this.CenterToParent();
            initView();
        }

        private void initView()
        {
            addTitle();
            addViewCancel();
            addViewSignIn();
        }

        private void addTitle()
        {
            Label label = new Label();
            label.Text = "Sign in";
            label.BackColor = System.Drawing.Color.Transparent;
            label.Size = new System.Drawing.Size(100, 50);
            label.Font = new Font(Const.FONT_FAMILY, 18, FontStyle.Bold);
            label.Location = new Point(this.Width / 2 - label.Width / 2, 10);
            label.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(label);
        }

        private void addViewSignIn()
        {
            createNewInputBox("Username", "Username", 0, 100);
            createNewInputBox("Password", "Password", 0, 150);
            setupButtonSignIn("Sign In", this.Width / 2, 250, new OnSignInClick(this));
            setupButtonSignUp("Sign up", this.Width / 2, 300, new OnSignUpClick(this));
        }


        private void createNewInputBox(String titleName, String hintName, int x, int y)
        {

            Panel panel = new Panel();
            panel.SetBounds(x, y, this.Width, 50);
            Label label = new Label();
            label.Text = titleName;
            label.Size = new System.Drawing.Size(100, panel.Height);
            label.Font = new Font(Const.FONT_FAMILY, 12, FontStyle.Regular);
            label.Location = new Point(50, 0);
            label.Name = titleName;
            label.TextAlign = ContentAlignment.MiddleLeft;

            TextBox textBox = new TextBox();
            textBox.Size = new Size(panel.Width - label.Width - label.Location.X * 2, panel.Height);
            textBox.Font = new Font(Const.FONT_FAMILY, 12, FontStyle.Regular);
            textBox.Location = new Point(label.Location.X + label.Width, panel.Height/2 - textBox.Height / 2);
            textBox.Name = hintName;
            textBox.TextAlign = HorizontalAlignment.Left;
            textBox.Dock = DockStyle.None;
            panel.Controls.Add(label);
            panel.Controls.Add(textBox);
            panel.BackColor = Color.Transparent;
            panel.Name = titleName + hintName;
            this.Controls.Add(panel);
        }

        private void addViewCancel()
        {
            image = Image.FromHbitmap(Properties.Resources.cancel.GetHbitmap());
            imageView = new ButtonView(image, this.Width - image.Width - 10, 10, new OnCancelClick(this));
            imageView.Name = CANCEL_BUTTON;
            this.Controls.Add(imageView);
        }


        private void setupButtonSignIn(String name, int x, int y, OnClickListener onClickListener)
        {

            signInButton = new ButtonView(null, x - ((this.Width / 4) / 2), y, onClickListener);
            signInButton.Name = name;
            signInButton.Width = this.Width / 5;
            signInButton.Height = 30;
            signInButton.Text = name;
            signInButton.Font = new Font(Const.FONT_FAMILY, 12, FontStyle.Regular);
            this.Controls.Add((signInButton));
        }

        private void setupButtonSignUp(String name, int x, int y, OnClickListener onClickListener)
        {

            signUpButton = new ButtonView(null, x - ((this.Width / 4) / 2), y, onClickListener);
            signUpButton.Name = name;
            signUpButton.Width = this.Width / 5;
            signUpButton.Height = 30;
            signUpButton.Text = name;
            signUpButton.Font = new Font(Const.FONT_FAMILY, 12, FontStyle.Regular);
            this.Controls.Add(signUpButton);
        }

        private class OnCancelClick : OnClickListener
        {
            private Form form;

            public OnCancelClick(Form form)
            {
                this.form = form;
            }

            public void OnClick(EventArgs e)
            {
                ((LoginForm)form).onCloseClick.OnClick(e);
                form.Close();
            }

        }

        private class OnSignInClick : OnClickListener
        {
            private Form Form;

            public OnSignInClick(Form form)
            {
                Form = form;
            }

            public void OnClick(EventArgs e)
            {

            }
        }

        private class OnSignUpClick : OnClickListener
        {
            private Form form;

            public OnSignUpClick(Form form)
            {
                this.form = form;
            }

            public void OnClick(EventArgs e)
            {

            }
        }
        #endregion
    }
}