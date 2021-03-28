using System;
using System.IO;
using System.IO.Compression;
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
            printLog("sources에 플러그인 소스폴더를 넣으세요");
            printLog("프로그램 실행 전 sources폴더에 들어간 소스폴더들은 자동완성을 지원합니다");
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

            this.encrypt(folderName + "/", encryptCount);
            printLog("");
            printLog("암호화가 완료되었습니다");
            printLog("encrypted 폴더에서 확인하세요.");
        }

        private void encrypt(String FolderPath, int encryptCount)
        {
            int encryptCountFor = encryptCount + 1;

            DirectoryInfo folderInfo = new DirectoryInfo(FolderPath);
            DirectoryInfo completeDirectory = new DirectoryInfo(FolderPath.Replace("./sources/", "./encrypted/"));
            if (!completeDirectory.Exists)
            {
                completeDirectory.Create();
            }

            foreach(FileInfo file in folderInfo.GetFiles())
            {
                if(file.Extension == ".php")
                {
                    String code = file.OpenText().ReadToEnd().Replace("<?php", "").Replace("?>", "");

                    int count;
                    for(count = 1; count < encryptCountFor; count++)
                    {
                        byte[] buffer = UTF8Encoding.UTF8.GetBytes(code);
                        MemoryStream rawDataStream = new MemoryStream();
                        DeflateStream gzipOut = new DeflateStream(rawDataStream, CompressionMode.Compress);

                        gzipOut.Write(buffer, 0, buffer.Length);
                        gzipOut.Close();

                        byte[] compressed = rawDataStream.ToArray();
              

                        code = "eval(gzinflate(base64_decode(\"" + Convert.ToBase64String(compressed) + "\")));";
                        printLog(FolderPath + file.Name + "파일 " + count + "번째 암호화중");
                    }
                    
                    File.WriteAllText(FolderPath.Replace("./sources/", "./encrypted/") + file.Name, "<?php\n" + code);

                }
                else
                {
                    File.Copy(FolderPath + file.Name, FolderPath.Replace("./sources/", "./encrypted/") + file.Name);
                }
            }
            foreach(DirectoryInfo directory in folderInfo.GetDirectories())
            {
                this.encrypt(FolderPath + directory.Name + "/", encryptCount);
            }
        }



        private void printLog(String str)
        {
            log.AppendText("\n" + str);
            log.ScrollToCaret();
        }
    }
}
