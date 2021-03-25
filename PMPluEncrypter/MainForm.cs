using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMPluEncrypter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            printLog("  _____            __  __                     ____     __    __   _          _           _ ");
            printLog(" |  __ \\          |  \\/  |                   / __ \\   / _|  / _| (_)        (_)         | |");
            printLog(" | |__) |   ___   | \\  / |   ___            | |  | | | |_  | |_   _    ___   _    __ _  | |");
            printLog(" |  _  /   / _ \\  | |\\/| |  / _ \\           | |  | | |  _| |  _| | |  / __| | |  / _` | | |");
            printLog(" | | \\ \\  | (_) | | |  | | | (_) |          | |__| | | |   | |   | | | (__  | | | (_| | | |");
            printLog(" |_|  \\_\\  \\___/  |_|  |_|  \\___/            \\____/  |_|   |_|   |_|  \\___| |_|  \\__,_| |_|");
            printLog("                                    ______                                                 ");
            printLog("                                   |______|                                                ");
            printLog("");
            printLog("프로그램이 정상 실행 되었습니다");
        }

        private void button_Click(object sender, EventArgs e)
        {
            int encryptCount = 0;
            if (!int.TryParse(countBox.Text.Replace("번", ""), out encryptCount))
            {
                MessageBox.Show("비정상 값이 감지됨", "오류");
                Application.Exit();
            }

            String folderName = "./sources/" + FolderInput.Text;
            DirectoryInfo folderInfo = new DirectoryInfo(folderName);

            if (folderInfo.Parent.Name != "sources" || !folderInfo.Exists)
            {
                MessageBox.Show("존재하지 않는 폴더입니다\nsources폴더를 확인하세요", "알림");
                return;
            }
            printLog(folderInfo.Name + "폴더 여는중...");


        }

        private void printLog(String str)
        {
            log.AppendText("\n" + str);
            log.ScrollToCaret();
        }
    }
}
