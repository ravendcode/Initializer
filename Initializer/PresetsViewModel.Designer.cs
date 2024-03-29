﻿namespace Initializer
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
            this.openInExplorerBtn = new System.Windows.Forms.Button();
            this.addProjectNameFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createBtn.Location = new System.Drawing.Point(51, 547);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(246, 52);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Создать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // textBoxDirPath
            // 
            this.textBoxDirPath.Enabled = false;
            this.textBoxDirPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDirPath.Location = new System.Drawing.Point(51, 94);
            this.textBoxDirPath.Name = "textBoxDirPath";
            this.textBoxDirPath.ReadOnly = true;
            this.textBoxDirPath.Size = new System.Drawing.Size(739, 29);
            this.textBoxDirPath.TabIndex = 2;
            this.textBoxDirPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFolderBtn.Location = new System.Drawing.Point(51, 40);
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
            this.checkedListPresetFiles.Location = new System.Drawing.Point(346, 163);
            this.checkedListPresetFiles.Name = "checkedListPresetFiles";
            this.checkedListPresetFiles.Size = new System.Drawing.Size(444, 436);
            this.checkedListPresetFiles.TabIndex = 5;
            this.checkedListPresetFiles.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // listPresets
            // 
            this.listPresets.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPresets.FormattingEnabled = true;
            this.listPresets.ItemHeight = 22;
            this.listPresets.Location = new System.Drawing.Point(51, 243);
            this.listPresets.Name = "listPresets";
            this.listPresets.Size = new System.Drawing.Size(246, 268);
            this.listPresets.TabIndex = 6;
            this.listPresets.SelectedIndexChanged += new System.EventHandler(this.listPresetsBox_SelectedIndexChanged);
            // 
            // langComboBox
            // 
            this.langComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.langComboBox.Location = new System.Drawing.Point(719, 40);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(71, 25);
            this.langComboBox.TabIndex = 8;
            this.langComboBox.SelectedIndexChanged += new System.EventHandler(this.langComboBox_SelectedIndexChanged);
            // 
            // openInExplorerBtn
            // 
            this.openInExplorerBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openInExplorerBtn.Location = new System.Drawing.Point(51, 163);
            this.openInExplorerBtn.Name = "openInExplorerBtn";
            this.openInExplorerBtn.Size = new System.Drawing.Size(246, 61);
            this.openInExplorerBtn.TabIndex = 9;
            this.openInExplorerBtn.Text = "Открыть в проводнике";
            this.openInExplorerBtn.UseVisualStyleBackColor = true;
            this.openInExplorerBtn.Click += new System.EventHandler(this.openInExplorerBtn_Click);
            // 
            // addProjectNameFolderCheckBox
            // 
            this.addProjectNameFolderCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProjectNameFolderCheckBox.AutoSize = true;
            this.addProjectNameFolderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProjectNameFolderCheckBox.Location = new System.Drawing.Point(51, 129);
            this.addProjectNameFolderCheckBox.Name = "addProjectNameFolderCheckBox";
            this.addProjectNameFolderCheckBox.Size = new System.Drawing.Size(369, 28);
            this.addProjectNameFolderCheckBox.TabIndex = 10;
            this.addProjectNameFolderCheckBox.Text = "Добавить папку с названием проекта";
            this.addProjectNameFolderCheckBox.UseVisualStyleBackColor = true;
            this.addProjectNameFolderCheckBox.CheckedChanged += new System.EventHandler(this.addProjectNameFolderCheckBox_CheckedChanged);
            // 
            // PresetsViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 646);
            this.Controls.Add(this.addProjectNameFolderCheckBox);
            this.Controls.Add(this.openInExplorerBtn);
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
            this.Load += new System.EventHandler(this.PresetsViewModel_Load);
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
        private System.Windows.Forms.Button openInExplorerBtn;
        private System.Windows.Forms.CheckBox addProjectNameFolderCheckBox;
    }
}

