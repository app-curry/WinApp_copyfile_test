namespace WinApp_copyfile_test
{
    partial class Form_Selector
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
            this.button_copyfile = new System.Windows.Forms.Button();
            this.button_copydirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_copyfile
            // 
            this.button_copyfile.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_copyfile.Location = new System.Drawing.Point(12, 12);
            this.button_copyfile.Name = "button_copyfile";
            this.button_copyfile.Size = new System.Drawing.Size(180, 50);
            this.button_copyfile.TabIndex = 39;
            this.button_copyfile.Text = "ファイルのコピー";
            this.button_copyfile.UseVisualStyleBackColor = true;
            // 
            // button_copydirectory
            // 
            this.button_copydirectory.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_copydirectory.Location = new System.Drawing.Point(12, 86);
            this.button_copydirectory.Name = "button_copydirectory";
            this.button_copydirectory.Size = new System.Drawing.Size(180, 50);
            this.button_copydirectory.TabIndex = 40;
            this.button_copydirectory.Text = "ディレクトリのコピー";
            this.button_copydirectory.UseVisualStyleBackColor = true;
            // 
            // Form_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 219);
            this.Controls.Add(this.button_copydirectory);
            this.Controls.Add(this.button_copyfile);
            this.Name = "Form_Selector";
            this.Text = "Form_Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_copyfile;
        private System.Windows.Forms.Button button_copydirectory;
    }
}