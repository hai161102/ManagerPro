using Manager.db;
using Manager.form;
using Manager.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static List<NhanVien> listNhanVien;
        [STAThread]
        static void Main()
        {

            Const.FONT_FAMILY = Const.getFont(Properties.Resources.Roboto_Regular).Families[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
