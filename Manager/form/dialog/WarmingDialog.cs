using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.form.dialog
{
    public enum WarmingType
    {
        WARMING_DIALOG,
        SUGGEST_DIALOG,
        TOAST_DIALOG
    }
    public partial class WarmingDialog : Form
    {
        
        private String title;
        private String description;
        private Image icon;
        private WarmingType type;
        private ButtonDesign yesButton;
        private ButtonDesign noButton;
        private ButtonDesign cancelButton;


        public WarmingDialog()
        {
            InitializeComponent();
        }

        public WarmingDialog(string title, string description, Image icon, WarmingType type)
        {
            this.title = title;
            this.description = description;
            this.icon = icon;
            this.type = type;
        }

        private void setButton(object v)
        {
            yesButton = new ButtonDesign();
            noButton = new ButtonDesign();
            cancelButton = new ButtonDesign();
            switch (type)
            {
                case WarmingType.WARMING_DIALOG:
                    yesButton.setVisible(false);
                    noButton.setVisible(false);
                    cancelButton.setVisible(true);
                    break;
                case WarmingType.SUGGEST_DIALOG:
                    yesButton.setVisible(true);
                    noButton.setVisible(true);
                    cancelButton.setVisible(true);
                    break;
                case WarmingType.TOAST_DIALOG:
                    yesButton.setVisible(true);
                    noButton.setVisible(false);
                    cancelButton.setVisible(false);
                    break;
                default:
                    break;
            }
            yesButton.OnClickListener = new YesClickListener();
            noButton.OnClickListener = new NoClickListener();
            cancelButton.OnClickListener = new CancelClickListener();
        }

        private class YesClickListener : OnClickListener
        {
            public void OnClick(EventArgs e)
            {
                
            }
        }

        private class NoClickListener : OnClickListener
        {
            public void OnClick(EventArgs e)
            {
                throw new NotImplementedException();
            }
        }

        private class CancelClickListener : OnClickListener
        {
            public void OnClick(EventArgs e)
            {
                throw new NotImplementedException();
            }
        }


        private class ButtonDesign : Button
        {
            private bool isShow;
            private Button button;
            private OnClickListener onClickListener;

            internal OnClickListener OnClickListener { get => onClickListener; set => onClickListener = value; }

            public ButtonDesign(bool isShow)
            {
                this.isShow = isShow;
                this.button = this;
            }

            public ButtonDesign()
            {
                this.isShow = false;
                this.button = this;
            }

            public void setVisible(bool isVisible)
            {
                this.isShow = isVisible;
            }

            public bool getVisible()
            {
                return this.isShow;
            }

            protected override void OnClick(EventArgs e)
            {
                base.OnClick(e);
                OnClickListener.OnClick(e);
            }
        }
    }
}
