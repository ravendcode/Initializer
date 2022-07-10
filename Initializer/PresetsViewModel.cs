using Initializer.Data;
using Initializer.Errors;
using Initializer.Models;
using Initializer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private IConfigReader _configReader;
        private IAudioService _audioService;

        private List<Preset> _presets = new List<Preset>();
        private string _projectDir = "";
        //private string _presetName = "";
        private string _assetsDir = "";

        public PresetsViewModel(IConfigReader configReader, IAudioService audioService)
        {
            InitializeComponent();

            _configReader = configReader;
            _audioService = audioService;

            LoadPresets();
            LoadListPresets();
            LoadCheckedListPresetFiles(0);
        }

        private void LoadPresets()
        {
            try
            {
                _presets = _configReader.GetPresets().ToList();
            }
            catch (ConfigFileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(1);
            }
            catch (ConfigFileSerializationException e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(1);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (_projectDir != "")
            {
                DirectoryInfo dirInfo = new DirectoryInfo(_assetsDir);

                foreach (string item in checkedListPresetFiles.CheckedItems)
                {
                    if (item == ".editorconfig")
                    {
                        string editorconfig = @"resources\files\.editorconfig";
                        string sourceFile = Path.Combine(Environment.CurrentDirectory, editorconfig);
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
                MessageBox.Show("Успешно выполнено!");
            }
            else
            {
                _audioService.PlayError();
                MessageBox.Show("Выберите папку!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDirPath.ShowDialog();
            _projectDir = folderBrowserDialogDirPath.SelectedPath;
            _assetsDir = _projectDir + "\\" + _presets[listPresets.SelectedIndex].AssetsDir;
            textBoxDirPath.Text = _projectDir;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _assetsDir = _projectDir + "\\" + _presets[listPresets.SelectedIndex].AssetsDir;
            LoadCheckedListPresetFiles(listPresets.SelectedIndex);
        }
    }
}
