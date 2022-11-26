using Initializer.Data;
using Initializer.Errors;
using Initializer.Models;
using Initializer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initializer
{
    public partial class PresetsViewModel : Form
    {
        private readonly IConfigReaderWriter _configReaderWriter;
        private readonly IAudioService _audioService;

        private Config _config;
        private List<Preset> _presets = new List<Preset>();

        private string _projectDir = "";

        //private string _presetName = "";
        private string _assetsDir = "";

        private bool _firstLoadConfig = true;

        public PresetsViewModel(IConfigReaderWriter configReaderWriter, IAudioService audioService)
        {
            InitializeComponent();

            _configReaderWriter = configReaderWriter;
            _audioService = audioService;

            LoadLanguages();
            LoadConfig();
            LoadPresets();
            LoadListPresets();
            LoadCheckedListPresetFiles(0);
            openInExplorerBtn.Enabled = false;
            createBtn.Enabled = false;
        }

        private void LoadLanguages()
        {
            langComboBox.Items.Add("En");
            langComboBox.Items.Add("Ru");
            langComboBox.SelectedIndex = 0;
        }

        private void LoadConfig()
        {
            try
            {
                _config = _configReaderWriter.GetConfig();
                langComboBox.SelectedIndex = _config.Lang.ToLower() == "en" ? 0 : 1;
                addProjectNameFolderCheckBox.Checked = _config.AddProjectNameFolder;
            }
            catch (ConfigFileNotFoundException e)
            {
                _audioService.PlayError();
                MessageBox.Show(e.Message);
                Environment.Exit(1);
            }
            catch (ConfigFileSerializationException e)
            {
                _audioService.PlayError();
                MessageBox.Show(e.Message);
                Environment.Exit(1);
            }
        }

        private void LoadPresets()
        {
            _presets = _config.Presets.ToList();
        }

        private void LoadListPresets()
        {
            for (int i = 0; i < _presets.Count; i++)
            {
                listPresets.Items.Insert(i, _presets[i].Name);
            }

            listPresets.SetSelected(0, true);
        }

        private void LoadCheckedListPresetFiles(int selectedPreset)
        {
            checkedListPresetFiles.Items.Clear();
            for (int i = 0; i < _presets[selectedPreset].Files.Count; i++)
            {
                checkedListPresetFiles.Items.Add(_presets[selectedPreset].Files[i].Dirname);
                if (_presets[selectedPreset].Files[i].IsSelected)
                {
                    checkedListPresetFiles.SetItemChecked(i, true);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogDirPath.ShowDialog() == DialogResult.OK)
            {
                _projectDir = folderBrowserDialogDirPath.SelectedPath;
                GenerateAssetsDir();
                textBoxDirPath.Text = _projectDir;
                openInExplorerBtn.Enabled = true;
                createBtn.Enabled = true;
            }
        }

        private void listPresetsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _assetsDir = _projectDir + "\\" + _presets[listPresets.SelectedIndex].AssetsDir;
            LoadCheckedListPresetFiles(listPresets.SelectedIndex);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (_projectDir != "")
            {
                DirectoryInfo dirInfo = new DirectoryInfo(_assetsDir);

                foreach (string item in checkedListPresetFiles.CheckedItems)
                {
                    if (item == ".editorconfig")
                    {
                        const string editorConfig = @"resources\files\.editorconfig";
                        string sourceFile = Path.Combine(Environment.CurrentDirectory, editorConfig);
                        string destinationFile = _projectDir + "\\.editorconfig";
                        try
                        {
                            File.Copy(sourceFile, destinationFile, true);
                        }
                        catch (IOException copyError)
                        {
                            throw new CopyFileFromResourceException(copyError.Message);
                        }
                        continue;
                    }

                    dirInfo.CreateSubdirectory(item);

                    if (item == "ScriptTemplates")
                    {
                        string newBehaviourScript = @"resources\files\81-C# Script-NewBehaviourScript.cs.txt";
                        string sourceFile = Path.Combine(Environment.CurrentDirectory, newBehaviourScript);
                        string destinationFile = _assetsDir + "\\ScriptTemplates\\81-C# Script-NewBehaviourScript.cs.txt";
                        try
                        {
                            File.Copy(sourceFile, destinationFile, true);
                        }
                        catch (IOException copyError)
                        {
                            throw new CopyFileFromResourceException(copyError.Message);
                        }
                        continue;
                    }

                    //                    if (item == "ScriptTemplates")
                    //                    {
                    //                        using (FileStream fs = File.Create(_assetsDir + "\\ScriptTemplates\\81-C# Script-NewBehaviourScript.cs.txt"))
                    //                        {
                    //                            //byte[] info = new UTF8Encoding(true).GetBytes("-nowarn:0649\n");
                    //                            byte[] info = new UTF8Encoding(true).GetBytes(
                    //@"using System.Collections;
                    //using System.Collections.Generic;
                    //using UnityEngine;

                    //    #ROOTNAMESPACEBEGIN#
                    //public class #SCRIPTNAME# : MonoBehaviour
                    //{
                    //    private void Start()
                    //    {
                    //        #NOTRIM#
                    //    }

                    //    private void Update()
                    //    {
                    //        #NOTRIM#
                    //    }
                    //}
                    //#ROOTNAMESPACEEND#
                    //");
                    //                            fs.Write(info, 0, info.Length);
                    //                        }
                    //                    }
                }

                _audioService.PlaySuccess();
                MessageBox.Show(LangService.Translate("success"));
            }
        }

        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LangService.Lang = langComboBox.SelectedItem.ToString();
            selectFolderBtn.Text = LangService.Translate("select_folder_btn");
            createBtn.Text = LangService.Translate("create_btn");
            openInExplorerBtn.Text = LangService.Translate("open_in_explorer");
            addProjectNameFolderCheckBox.Text = LangService.Translate("add_project_name_folder");

            if (_firstLoadConfig)
            {
                _firstLoadConfig = false;
            }
            else
            {
                _config.Lang = langComboBox.SelectedItem.ToString();
                _configReaderWriter.SaveConfig(_config);
            }
        }

        private void openInExplorerBtn_Click(object sender, EventArgs e)
        {
            if (_projectDir != "")
            {
                Process.Start(_projectDir);
            }
        }

        private void PresetsViewModel_Load(object sender, EventArgs e)
        {

        }

        private void addProjectNameFolderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _config.AddProjectNameFolder = addProjectNameFolderCheckBox.Checked;
            _configReaderWriter.SaveConfig(_config);
            if (!string.IsNullOrEmpty(_assetsDir))
            {
                GenerateAssetsDir();
            }
        }

        private void GenerateAssetsDir()
        {
            if (addProjectNameFolderCheckBox.Checked)
            {
                _assetsDir = _projectDir + "\\" + _presets[listPresets.SelectedIndex].AssetsDir + "\\" +
                    Path.GetFileName(_projectDir);
            }
            else
            {
                _assetsDir = _projectDir + "\\" + _presets[listPresets.SelectedIndex].AssetsDir;
            }
        }
    }
}
