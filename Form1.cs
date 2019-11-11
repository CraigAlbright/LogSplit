using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogSplitter
{
    public partial class Form1 : Form
    {
        private Stream _stream;
        private StreamWriter _splitStream;
        private int _chunkSize;
        private string _rootPath;
        private string _destinationPath;
        private string _splitFileName;
        private string _splitText;
        private string _splitExtension;
        private int _splitNumber = 0;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                var result = ofd.ShowDialog();
                if (result != DialogResult.OK) return;
                if (!ofd.CheckFileExists) return;
                _stream = ofd.OpenFile();
                textBox1.Text = ofd.FileName;
                _destinationPath = _rootPath = string.Concat(Path.GetDirectoryName(ofd.FileName),"\\");
                textBox3.Text = _destinationPath;
                if (ofd.SafeFileName == null) return;
                var fileParts = ofd.SafeFileName.Split('.');
                if (fileParts.Length <= 1) return;
                _splitFileName = $"{fileParts[0]}";
                _splitExtension = fileParts[fileParts.Length - 1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_stream != null)
            {
                if (int.TryParse(spinEdit1.Text, out _chunkSize))
                { 
                    var reader = new StreamReader(_stream);
                    while (!reader.EndOfStream)
                    {
                        if (_splitStream != null && _splitStream.BaseStream.Length / 1048576 >= _chunkSize)
                        {
                            if (_splitStream != null)
                            {
                                _splitStream.Flush();
                                _splitStream.Close();
                                _splitStream.Dispose();
                            }

                            if (radioButton1.Checked)
                                _splitText = string.Concat("split",_splitNumber++);
                            if (radioButton2.Checked)
                                _splitText = _splitNumber++.ToString();
                            if (radioButton3.Checked)
                                _splitText = DateTime.Now.ToFileTimeUtc().ToString();
                            if(radioButton4.Checked)
                                _splitText = string.Concat(textBox2.Text,_splitNumber++);
                            //new file!!
                            _splitStream = new StreamWriter(new FileStream(string.Concat(_destinationPath, _splitFileName,_splitText ,".",_splitExtension), FileMode.OpenOrCreate), Encoding.UTF8);
                        }

                        if (_splitStream == null)
                        {
                            if (radioButton1.Checked)
                                _splitText = string.Concat("split",_splitNumber++);
                            if (radioButton2.Checked)
                                _splitText = _splitNumber++.ToString();
                            if (radioButton3.Checked)
                                _splitText = DateTime.Now.ToFileTimeUtc().ToString();
                            if(radioButton4.Checked)
                                _splitText = string.Concat(textBox2.Text,_splitNumber++);

                            //new file!!
                            _splitStream = new StreamWriter(new FileStream(string.Concat(_destinationPath, _splitFileName,_splitText ,".",_splitExtension), FileMode.OpenOrCreate), Encoding.UTF8);
                        }
                        var line = reader.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            _splitStream.WriteLine(line);
                        }

                    }

                }
                if (_splitStream != null && _splitStream.BaseStream.Length / 1048576 >= _chunkSize)
                {
                    if (_splitStream != null)
                    {
                        _splitStream.Flush();
                        _splitStream.Close();
                        _splitStream.Dispose();
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new FolderBrowserDialog {ShowNewFolderButton = true})
            {
                var result = fileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _destinationPath = textBox3.Text = fileDialog.SelectedPath;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    textBox2.Enabled = false;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    textBox2.Enabled = false;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    textBox2.Enabled = false;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    textBox2.Enabled = true;
                }
            }
        }
    }
}
