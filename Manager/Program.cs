using Manager.context;
using Manager.db;
using Manager.form;
using Manager.interfaces;
using Manager.model;
using Manager.model.instance;
using Manager.presenter;
using Manager.view.interfaces;
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
        public static string CONNECTION_STRING = @"Data Source=HAI;Initial Catalog=Nhom_12;Integrated Security=True";
        public static MyApplication applicationContext;
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            applicationContext = new MyApplication();
            Application.Run(applicationContext);

        }

    }
}
