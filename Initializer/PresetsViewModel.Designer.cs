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
            this.createBtn = new System.Windows.Forms.Button();
            this.textBoxDirPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogDirPath = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.checkedListPresetFiles = new System.Windows.Forms.CheckedListBox();
            this.listPresets = new System.Windows.Forms.ListBox();
            this.langComboBox = new System.Windows.Forms.ComboBox();
            this.openInExplorerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createBtn.Location = new System.Drawing.Point(51, 545);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(246, 52);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Создать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
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
            // selectFolderBtn
            // 
            this.selectFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFolderBtn.Location = new System.Drawing.Point(51, 43);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(220, 37);
            this.selectFolderBtn.TabIndex = 3;
            this.selectFolderBtn.Text = "Выбрать папку";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // checkedListPresetFiles
            // 
            this.checkedListPresetFiles.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListPresetFiles.FormattingEnabled = true;
            this.checkedListPresetFiles.Location = new System.Drawing.Point(346, 161);
            this.checkedListPresetFiles.Name = "checkedListPresetFiles";
            this.checkedListPresetFiles.Size = new System.Drawing.Size(444, 436);
            this.checkedListPresetFiles.TabIndex = 5;
            this.checkedListPresetFiles.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // listPresets
            // 
            this.listPresets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPresets.FormattingEnabled = true;
            this.listPresets.ItemHeight = 20;
            this.listPresets.Location = new System.Drawing.Point(51, 247);
            this.listPresets.Name = "listPresets";
            this.listPresets.Size = new System.Drawing.Size(246, 264);
            this.listPresets.TabIndex = 6;
            this.listPresets.SelectedIndexChanged += new System.EventHandler(this.listPresetsBox_SelectedIndexChanged);
            // 
            // langComboBox
            // 
            this.langComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.langComboBox.Location = new System.Drawing.Point(719, 43);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(71, 25);
            this.langComboBox.TabIndex = 8;
            this.langComboBox.SelectedIndexChanged += new System.EventHandler(this.langComboBox_SelectedIndexChanged);
            // 
            // openInExplorerButton
            // 
            this.openInExplorerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openInExplorerButton.Location = new System.Drawing.Point(51, 161);
            this.openInExplorerButton.Name = "openInExplorerButton";
            this.openInExplorerButton.Size = new System.Drawing.Size(246, 61);
            this.openInExplorerButton.TabIndex = 9;
            this.openInExplorerButton.Text = "Открыть в проводнике";
            this.openInExplorerButton.UseVisualStyleBackColor = true;
            this.openInExplorerButton.Click += new System.EventHandler(this.openInExplorerButton_Click);
            // 
            // PresetsViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 646);
            this.Controls.Add(this.openInExplorerButton);
            this.Controls.Add(this.langComboBox);
            this.Controls.Add(this.listPresets);
            this.Controls.Add(this.checkedListPresetFiles);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.textBoxDirPath);
            this.Controls.Add(this.createBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PresetsViewModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox textBoxDirPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDirPath;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.CheckedListBox checkedListPresetFiles;
        private System.Windows.Forms.ListBox listPresets;
        private System.Windows.Forms.ComboBox langComboBox;
        private System.Windows.Forms.Button openInExplorerButton;
    }
}

