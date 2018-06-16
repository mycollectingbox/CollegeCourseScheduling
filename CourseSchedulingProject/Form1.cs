using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CourseSchedulingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 選擇要匯入的'課程資訊'檔案
        private void PickButton_Click(object sender, EventArgs e)
        {
            ChooseFileDialogProcess("Excel xlsx files (*.xlsx)|*.xlsx", CourseDataPath_Textbox);
        }

        // 開始排課
        private void Start_Buttin_Click(object sender, EventArgs e)
        {
            CheckExcelFile();
        }


        /* Common utility function */
    
        private void ChooseFileDialogProcess(string filterstring, TextBox displayTextBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = filterstring,
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
            };

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                displayTextBox.Text = openFileDialog.FileName;
            }
        }

        private void CheckExcelFile()
        {
            try
            {
                // 我們欲蒐集的資料欄位
                List<string> columnsWeNeed = new List<string>()
                {
                    "課程代碼",
                    "課程名稱",
                    "必選修",
                    "課程類型",
                    "授課教師",
                    "班級",
                    "總堂數"
                };
                CourseDataReader.GetExcelContent(CourseDataPath_Textbox.Text, "Sheet1", columnsWeNeed, "課程資訊表");
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
