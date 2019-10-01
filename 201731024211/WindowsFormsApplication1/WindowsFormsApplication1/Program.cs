using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin  f1 = new FrmLogin ();
            Application.Run(f1);
            if (f1.Tag.ToString() == "验证成功")
            {
                FrmStudent  f2 = new FrmStudent ();
                Application.Run(f2);
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
