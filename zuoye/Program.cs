using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zuoye
{
    static class Program
    {
        public static string mypath { get; set; }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 
        [STAThread]

        static void Main()
        {
           Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());
            List<String> ls = new List<string>();
            filecz cz = new filecz();
            ls  = cz.getFromXml();

        }
    }
}
