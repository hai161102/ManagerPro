using Manager.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public class Const
    {
        public static string SIGN_IN = "sign_in";
        public static string SIGN_IN_ACC = "SIGN_IN_ACC";
        public static string SIGN_UP_ACC = "SIGN_UP_ACC";
        public static string NOTIFY_TEXT = "NOTIFY_TEXT";
        public static string VIEW_LOGIN = "VIEW_LOGIN";
        public static string SIGN_UP_NEW_ACC = "SIGN_UP_NEW_ACC";
        public static string SIGNUP_SUCCESS = "Signup Success";

        public static string EXIT_SIGNUP = "EXIT_SIGNUP";
        public static string VIEW_SIGNUP = "VIEW_SIGNUP";
        public static FontFamily FONT_FAMILY = null;
        internal static string MAIN_ACTIVITY = "MAIN_ACTIVITY";
        public static string FILE_NAME = @"D:\\visual\\Manager\\Manager\\account.txt";

        public static PrivateFontCollection getFont(byte[] font)
        {

            PrivateFontCollection fontCollection = new PrivateFontCollection();

            int fontLenght = font.Length;

            byte[] fontData = font;


            IntPtr memory = Marshal.AllocCoTaskMem(fontLenght);

            Marshal.Copy(fontData, 0, memory, fontLenght);

            fontCollection.AddMemoryFont(memory, fontLenght);


            return fontCollection;
        }
        public static AccountManager readDataSave()
        {
            AccountManager accountF = new AccountManager();
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(FILE_NAME)) 
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                int i = 0;
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (i == 0)
                    {
                        accountF.setUserName(line.Trim());
                    }
                    if (i == 1)
                    {
                        accountF.setPassword(line.Trim());
                    }
                    i++;
                }
            }
            return accountF;
        }
        public static void saveData(AccountManager accountManager)
        {

            if (accountManager.getUserName() == readDataSave().getUserName() && accountManager.getPassword() == readDataSave().getPassword())
            {
                return;
            }
            using (var fileStream = new FileStream(FILE_NAME, FileMode.Truncate))
            using (var streamWriter = new StreamWriter(fileStream))
            {

                streamWriter.WriteLine(accountManager.getUserName());
                streamWriter.WriteLine(accountManager.getPassword());
            }

        }
    }
}
