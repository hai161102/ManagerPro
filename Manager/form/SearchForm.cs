using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.form
{
    public partial class SearchForm : Form
    {

        private SearchListener _listener;
        public SearchForm(SearchListener searchListener)
        {
            this._listener = searchListener;
            InitializeComponent();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this._listener.onSearchClick(tbSearch.Text);
            this.Close();
        }



        public interface SearchListener
        {
            void onSearchClick(String text);
            void onTextChange(String text);

            void onCancel();
        }

        private void onTextChange(object sender, EventArgs e)
        {
            this._listener.onTextChange(tbSearch.Text);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this._listener.onCancel();
            this.Close();
        }
    }
}
