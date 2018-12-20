using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RakutenLib;
using System.IO;

namespace RakutenCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMakeCSV_Click(object sender, EventArgs e)
        {
            string filePath = textBoxFIlePath.Text;
            if (File.Exists(filePath) == false)
            {
                MessageBox.Show("ファイルが存在しません。");
                return;
            }
            List<int> codeList = new List<int>();
            using (var sr = new StreamReader(filePath) )
            {
                while(sr.Peek() >= 0)
                {
                    if(int.TryParse(sr.ReadLine(), out var code))
                    {
                        codeList.Add(code);
                    }                    
                }                
            }
            RakutenLib.RakutenCSV.OutPutRakutenCSV(codeList, textBoxOutPutPath.Text);
        }

        /*******************************************************
         * テキストボックスにドラッグ&ドロップした時の処理
        *******************************************************/
        public void textBoxFileName_DragEnter(object sender, DragEventArgs e)
        {
            //ファイルがドラッグされている場合、カーソルを変更する
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        public void textBoxFileName_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップされたファイルの一覧を取得
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileName.Length <= 0)
            {
                return;
            }

            // ドロップ先がTextBoxであるかチェック
            System.Windows.Forms.TextBox txtTarget = sender as System.Windows.Forms.TextBox;
            if (txtTarget == null)
            {
                return;
            }

            //TextBoxの内容をファイル名に変更
            txtTarget.Text = fileName[0];
        }
    }
}
