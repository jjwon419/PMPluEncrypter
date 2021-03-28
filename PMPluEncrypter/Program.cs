using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMPluEncrypter
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DirectoryInfo sourcesFolder = new DirectoryInfo("./sources/");
            if (!sourcesFolder.Exists)
            {
                sourcesFolder.Create();
            }

            DirectoryInfo encryptedFolder = new DirectoryInfo("./encrypted/");
            if (!encryptedFolder.Exists)
            {
                encryptedFolder.Create();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
