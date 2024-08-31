namespace WinApp_copyfile_test
{
    partial class Form_CopyFile
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_todir = new System.Windows.Forms.Label();
            this.label_source = new System.Windows.Forms.Label();
            this.progressBar_filecopy = new System.Windows.Forms.ProgressBar();
            this.label_filesize = new System.Windows.Forms.Label();
            this.textBox_todir = new System.Windows.Forms.TextBox();
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.button_execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_cancel.Location = new System.Drawing.Point(118, 157);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 50);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "中止";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_todir
            // 
            this.label_todir.AutoSize = true;
            this.label_todir.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_todir.Location = new System.Drawing.Point(12, 80);
            this.label_todir.Name = "label_todir";
            this.label_todir.Size = new System.Drawing.Size(177, 21);
            this.label_todir.TabIndex = 23;
            this.label_todir.Text = "コピー先ディレクトリ：";
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_source.Location = new System.Drawing.Point(12, 9);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(161, 21);
            this.label_source.TabIndex = 22;
            this.label_source.Text = "コピーするファイル：";
            // 
            // progressBar_filecopy
            // 
            this.progressBar_filecopy.Location = new System.Drawing.Point(12, 279);
            this.progressBar_filecopy.Name = "progressBar_filecopy";
            this.progressBar_filecopy.Size = new System.Drawing.Size(305, 46);
            this.progressBar_filecopy.TabIndex = 21;
            // 
            // label_filesize
            // 
            this.label_filesize.AutoSize = true;
            this.label_filesize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_filesize.Location = new System.Drawing.Point(12, 232);
            this.label_filesize.Name = "label_filesize";
            this.label_filesize.Size = new System.Drawing.Size(134, 21);
            this.label_filesize.TabIndex = 20;
            this.label_filesize.Text = "ファイルのサイズ";
            // 
            // textBox_todir
            // 
            this.textBox_todir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_todir.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_todir.Location = new System.Drawing.Point(12, 104);
            this.textBox_todir.Name = "textBox_todir";
            this.textBox_todir.Size = new System.Drawing.Size(720, 28);
            this.textBox_todir.TabIndex = 1;
            // 
            // textBox_source
            // 
            this.textBox_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_source.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_source.Location = new System.Drawing.Point(12, 33);
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(720, 28);
            this.textBox_source.TabIndex = 0;
            // 
            // button_execute
            // 
            this.button_execute.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_execute.Location = new System.Drawing.Point(12, 157);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(100, 50);
            this.button_execute.TabIndex = 2;
            this.button_execute.Text = "実行";
            this.button_execute.UseVisualStyleBackColor = true;
            // 
            // Form_CopyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 361);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_todir);
            this.Controls.Add(this.label_source);
            this.Controls.Add(this.progressBar_filecopy);
            this.Controls.Add(this.label_filesize);
            this.Controls.Add(this.textBox_todir);
            this.Controls.Add(this.textBox_source);
            this.Controls.Add(this.button_execute);
            this.Name = "Form_CopyFile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_todir;
        private System.Windows.Forms.Label label_source;
        private System.Windows.Forms.ProgressBar progressBar_filecopy;
        private System.Windows.Forms.Label label_filesize;
        private System.Windows.Forms.TextBox textBox_todir;
        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.Button button_execute;
    }
}

