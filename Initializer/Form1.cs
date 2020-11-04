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
    public partial class Form1 : Form
    {
        private IConfigReader _configReader;
        private IAudioService _audioService;

        private List<Preset> _presets = new List<Preset>();
        private string _assetsDir = "";

        public Form1(IConfigReader configReader, IAudioService audioService)
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
                Environment.Exit(0);
            }
            catch (ConfigSerializationException e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
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
            if (_assetsDir != "")
            {
                DirectoryInfo dirInfo = new DirectoryInfo(_assetsDir);

                foreach (string item in checkedListPresetFiles.CheckedItems)
                {
                    if (item != "csc.rsp")
                    {
                        dirInfo.CreateSubdirectory(item);
                    }
                    else
                    {
                        using (FileStream fs = File.Create(_assetsDir + "\\csc.rsp"))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes("-nowarn:0649\n");
                            fs.Write(info, 0, info.Length);
                        }
                    }
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
            folderBrowserDialog1.ShowDialog();
            _assetsDir = folderBrowserDialog1.SelectedPath;
            textBox1.Text = _assetsDir;
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
            LoadCheckedListPresetFiles(listPresets.SelectedIndex);
        }
    }
}
