namespace WinApp_copyfile_test
{
    partial class Form_CopyDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_sourcedir = new System.Windows.Forms.Label();
            this.textBox_sourcedir = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_todir = new System.Windows.Forms.Label();
            this.progressBar_filecopy = new System.Windows.Forms.ProgressBar();
            this.label_filesize = new System.Windows.Forms.Label();
            this.textBox_todir = new System.Windows.Forms.TextBox();
            this.button_execute = new System.Windows.Forms.Button();
            this.label_filename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_sourcedir
            // 
            this.label_sourcedir.AutoSize = true;
            this.label_sourcedir.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_sourcedir.Location = new System.Drawing.Point(12, 9);
            this.label_sourcedir.Name = "label_sourcedir";
            this.label_sourcedir.Size = new System.Drawing.Size(190, 21);
            this.label_sourcedir.TabIndex = 36;
            this.label_sourcedir.Text = "コピーするディレクトリ：";
            // 
            // textBox_sourcedir
            // 
            this.textBox_sourcedir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sourcedir.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_sourcedir.Location = new System.Drawing.Point(12, 33);
            this.textBox_sourcedir.Name = "textBox_sourcedir";
            this.textBox_sourcedir.Size = new System.Drawing.Size(720, 28);
            this.textBox_sourcedir.TabIndex = 35;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_cancel.Location = new System.Drawing.Point(118, 157);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 50);
            this.button_cancel.TabIndex = 30;
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
            this.label_todir.TabIndex = 34;
            this.label_todir.Text = "コピー先ディレクトリ：";
            // 
            // progressBar_filecopy
            // 
            this.progressBar_filecopy.Location = new System.Drawing.Point(12, 323);
            this.progressBar_filecopy.Name = "progressBar_filecopy";
            this.progressBar_filecopy.Size = new System.Drawing.Size(305, 46);
            this.progressBar_filecopy.TabIndex = 32;
            // 
            // label_filesize
            // 
            this.label_filesize.AutoSize = true;
            this.label_filesize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_filesize.Location = new System.Drawing.Point(12, 279);
            this.label_filesize.Name = "label_filesize";
            this.label_filesize.Size = new System.Drawing.Size(134, 21);
            this.label_filesize.TabIndex = 31;
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
            this.textBox_todir.TabIndex = 28;
            // 
            // button_execute
            // 
            this.button_execute.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_execute.Location = new System.Drawing.Point(12, 157);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(100, 50);
            this.button_execute.TabIndex = 38;
            this.button_execute.Text = "実行";
            this.button_execute.UseVisualStyleBackColor = true;
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_filename.Location = new System.Drawing.Point(12, 238);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(89, 21);
            this.label_filename.TabIndex = 39;
            this.label_filename.Text = "ファイル名";
            // 
            // Form_CopyDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 399);
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.button_execute);
            this.Controls.Add(this.label_sourcedir);
            this.Controls.Add(this.textBox_sourcedir);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_todir);
            this.Controls.Add(this.progressBar_filecopy);
            this.Controls.Add(this.label_filesize);
            this.Controls.Add(this.textBox_todir);
            this.Name = "Form_CopyDirectory";
            this.Text = "Form_CopyDirectory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_sourcedir;
        private System.Windows.Forms.TextBox textBox_sourcedir;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_todir;
        private System.Windows.Forms.ProgressBar progressBar_filecopy;
        private System.Windows.Forms.Label label_filesize;
        private System.Windows.Forms.TextBox textBox_todir;
        private System.Windows.Forms.Button button_execute;
        private System.Windows.Forms.Label label_filename;
    }
}