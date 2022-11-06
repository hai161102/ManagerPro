using Manager.form;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.view
{
    
    public class ButtonView : Button
    {
        private int width1;
        private int height1;
        private int x;
        private int y;
        private OnClickListener onClickListener;
        private IntPtr resID;

        public int Width1 { get => width1; set => width1 = value; }
        public int Height1 { get => height1; set => height1 = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public OnClickListener OnClickListener { get => onClickListener; set => onClickListener = value; }
        public IntPtr ResID { get => resID; set => resID = value; }

        private ButtonView()
        {

        }
        public ButtonView(Image image, int x, int y, OnClickListener onClickListener)
        {
            this.Image = image;
            if (image != null)
            {
                this.Width1 = image.Width;
                this.Height1 = image.Height;
                this.Width = this.Width1;
                this.Height = this.Height1;
                this.BackgroundImage = image;

            }

            this.X = x;
            this.Y = y;
            this.Location = new Point(this.X, this.Y);
            this.OnClickListener = onClickListener;

            this.BackColor = Color.Transparent;

        }


        public ButtonView(IntPtr resId)
        {
            this.ResID = resId;
            this.Width1 = Image.Width;
            this.Height1 = Image.Height;
            this.Width = Image.Width;
            this.Height= Image.Height;
            this.Layout += ButtonView_Layout;
            this.X = 0;
            this.Y = 0;
            this.Location = new Point(this.X, this.Y);
            this.OnClickListener = null;
            this.BackColor = Color.Transparent;
            this.BackgroundImage = Image.FromHbitmap(resId);
        }

        private void ButtonView_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            onClickListener.OnClick(e);
            InformationForm formHSNV = new InformationForm();
            formHSNV.Show();
            //LoginForm.Close();
        }

        public ButtonView getDefaultView()
        {
            return new ButtonView();
        }
        
    }
}
