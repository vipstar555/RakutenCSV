namespace RakutenCSV
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFIlePath = new System.Windows.Forms.TextBox();
            this.buttonMakeCSV = new System.Windows.Forms.Button();
            this.textBoxOutPutPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFIlePath
            // 
            this.textBoxFIlePath.AllowDrop = true;
            this.textBoxFIlePath.Location = new System.Drawing.Point(93, 12);
            this.textBoxFIlePath.Name = "textBoxFIlePath";
            this.textBoxFIlePath.Size = new System.Drawing.Size(334, 19);
            this.textBoxFIlePath.TabIndex = 0;
            this.textBoxFIlePath.Text = "D:\\デスクトップ\\aaa.txt";
            this.textBoxFIlePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragDrop);
            this.textBoxFIlePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragEnter);
            // 
            // buttonMakeCSV
            // 
            this.buttonMakeCSV.Location = new System.Drawing.Point(433, 10);
            this.buttonMakeCSV.Name = "buttonMakeCSV";
            this.buttonMakeCSV.Size = new System.Drawing.Size(75, 46);
            this.buttonMakeCSV.TabIndex = 1;
            this.buttonMakeCSV.Text = "作成";
            this.buttonMakeCSV.UseVisualStyleBackColor = true;
            this.buttonMakeCSV.Click += new System.EventHandler(this.buttonMakeCSV_Click);
            // 
            // textBoxOutPutPath
            // 
            this.textBoxOutPutPath.AllowDrop = true;
            this.textBoxOutPutPath.Location = new System.Drawing.Point(93, 37);
            this.textBoxOutPutPath.Name = "textBoxOutPutPath";
            this.textBoxOutPutPath.Size = new System.Drawing.Size(334, 19);
            this.textBoxOutPutPath.TabIndex = 2;
            this.textBoxOutPutPath.Text = "D:\\マイ ドキュメント\\MarketSpeedCSV.csv";
            this.textBoxOutPutPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragDrop);
            this.textBoxOutPutPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "コードリストパス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "出力先パス";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 69);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutPutPath);
            this.Controls.Add(this.buttonMakeCSV);
            this.Controls.Add(this.textBoxFIlePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIlePath;
        private System.Windows.Forms.Button buttonMakeCSV;
        private System.Windows.Forms.TextBox textBoxOutPutPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

