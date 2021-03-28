
using System.IO;
using System.Windows.Forms;

namespace PMPluEncrypter
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FolderInput = new System.Windows.Forms.ComboBox();
            this.FolderInputDescription = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.ComboBox();
            this.CountDescription = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.MaximizeBox = false;
            this.SuspendLayout();

            // 
            // FolderInput
            // 
            this.FolderInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.FolderInput.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FolderInput.FormattingEnabled = true;
            this.FolderInput.Location = new System.Drawing.Point(33, 56);
            this.FolderInput.Name = "FolderInput";
            this.FolderInput.Size = new System.Drawing.Size(466, 45);
            this.FolderInput.TabIndex = 6;
            this.FolderInput.Click += new System.EventHandler(this.refreshFolderList);
            
            // 
            // FolderInputDescription
            // 
            this.FolderInputDescription.AutoSize = true;
            this.FolderInputDescription.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FolderInputDescription.Location = new System.Drawing.Point(98, 35);
            this.FolderInputDescription.Name = "FolderInputDescription";
            this.FolderInputDescription.Size = new System.Drawing.Size(332, 17);
            this.FolderInputDescription.TabIndex = 2;
            this.FolderInputDescription.Text = "플러그인 소스파일이 들어있는 폴더 이름을 입력하세요";
            // 
            // countBox
            // 
            this.countBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countBox.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.countBox.FormattingEnabled = true;
            /*this.countBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});*/

            int count;

            for(count = 1; count < 101; count++)
            {
                this.countBox.Items.Add(count + "번");
            }

            this.countBox.SelectedIndex = 0;
            this.countBox.Location = new System.Drawing.Point(505, 56);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(85, 29);
            this.countBox.TabIndex = 4;
            // 
            // CountDescription
            // 
            this.CountDescription.AutoSize = true;
            this.CountDescription.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CountDescription.Location = new System.Drawing.Point(508, 35);
            this.CountDescription.Name = "CountDescription";
            this.CountDescription.Size = new System.Drawing.Size(78, 17);
            this.CountDescription.TabIndex = 5;
            this.CountDescription.Text = "암호화 횟수";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.submit.Location = new System.Drawing.Point(596, 35);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(211, 51);
            this.submit.TabIndex = 0;
            this.submit.Text = "암호화 시작";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.log.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(33, 104);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(774, 273);
            this.log.TabIndex = 3;
            this.log.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(849, 399);
            this.Controls.Add(this.FolderInput);
            this.Controls.Add(this.FolderInputDescription);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.CountDescription);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.log);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PMMP 플러그인 암호화 툴";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label FolderInputDescription;
        private ComboBox countBox;
        private System.Windows.Forms.RichTextBox log;
        private Label CountDescription;
        private ComboBox FolderInput;
    }
}

