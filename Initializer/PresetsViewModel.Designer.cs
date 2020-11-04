namespace Initializer
{
    partial class PresetsViewModel
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetsViewModel));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDirPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogDirPath = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListPresetFiles = new System.Windows.Forms.CheckedListBox();
            this.listPresets = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(51, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDirPath
            // 
            this.textBoxDirPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDirPath.Location = new System.Drawing.Point(51, 107);
            this.textBoxDirPath.Name = "textBoxDirPath";
            this.textBoxDirPath.ReadOnly = true;
            this.textBoxDirPath.Size = new System.Drawing.Size(739, 29);
            this.textBoxDirPath.TabIndex = 2;
            this.textBoxDirPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(51, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выбрать папку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListPresetFiles
            // 
            this.checkedListPresetFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListPresetFiles.FormattingEnabled = true;
            this.checkedListPresetFiles.Location = new System.Drawing.Point(458, 200);
            this.checkedListPresetFiles.Name = "checkedListPresetFiles";
            this.checkedListPresetFiles.Size = new System.Drawing.Size(332, 340);
            this.checkedListPresetFiles.TabIndex = 5;
            this.checkedListPresetFiles.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // listPresets
            // 
            this.listPresets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPresets.FormattingEnabled = true;
            this.listPresets.ItemHeight = 20;
            this.listPresets.Location = new System.Drawing.Point(51, 200);
            this.listPresets.Name = "listPresets";
            this.listPresets.Size = new System.Drawing.Size(220, 244);
            this.listPresets.TabIndex = 6;
            this.listPresets.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(277, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "Выбрать предустановку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 646);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listPresets);
            this.Controls.Add(this.checkedListPresetFiles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxDirPath);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDirPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDirPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListPresetFiles;
        private System.Windows.Forms.ListBox listPresets;
        private System.Windows.Forms.Button button3;
    }
}

