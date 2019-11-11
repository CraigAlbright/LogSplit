using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LogSplitter.Properties;

namespace LogSplitter
{
    public partial class SplitForm : Form
    {
        private Stream _stream;
        private StreamWriter _splitStream;
        private int _chunkSize;
        private string _rootPath;
        private string _sourceFileName;
        private string _destinationPath;
        private string _splitFileName;
        private string _splitText;
        private string _splitExtension;
        private int _splitNumber = 0;
        public SplitForm()
        {
            InitializeComponent();
            SplitDefaultRadioButton.Checked = true;
        }

        private void OpenSourceFileDialogButtonClicked(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                var result = ofd.ShowDialog();
                if (result != DialogResult.OK) return;
                if (!ofd.CheckFileExists) return;
                _stream = ofd.OpenFile();
                SourcePathText.Text = ofd.FileName;
                _destinationPath = _rootPath = string.Concat(Path.GetDirectoryName(ofd.FileName),"\\");
                _sourceFileName = ofd.FileName;
                DestinationPathText.Text = _destinationPath;
                if (ofd.SafeFileName == null) return;
                var fileParts = ofd.SafeFileName.Split('.');
                if (fileParts.Length <= 1) return;
                _splitFileName = $"{fileParts[0]}";
                _splitExtension = fileParts[fileParts.Length - 1];
            }
        }

        private void SplitFileButtonClicked(object sender, EventArgs e)
        {
            if (_stream == null)
            {
                if (!string.IsNullOrEmpty(_sourceFileName) && File.Exists(_sourceFileName))
                    _stream = File.Open(_sourceFileName,FileMode.Open);
                if (_stream == null)
                {
                    MessageBox.Show(Resources.FileDoesntExist, Resources.FileDoesntExistCaption, MessageBoxButtons.OK);
                    return;
                }
            }
            if (int.TryParse(SplitSizeSpinEdit.Text, out _chunkSize))
            {
                using (var reader = new StreamReader(_stream))
                {
                    while (!reader.EndOfStream)
                    {
                        //is our split stream null and the length of the stream bigger than our split chunk size?
                        if (_splitStream != null && _splitStream.BaseStream.Length / 1048576 >= _chunkSize)
                        {
                            if (_splitStream != null)
                            {
                                _splitStream.Flush();
                                _splitStream.Close();
                                _splitStream.Dispose();
                            }

                            if (SplitDefaultRadioButton.Checked)
                                _splitText = string.Concat("split", _splitNumber++);
                            if (NumberSplitRadioButton.Checked)
                                _splitText = _splitNumber++.ToString();
                            if (TimeStampRadioButton.Checked)
                                _splitText = DateTime.Now.ToFileTimeUtc().ToString();
                            if (CustomRadioButton.Checked)
                                _splitText = string.Concat(CustomSplitTextBox.Text, _splitNumber++);
                            //new file!!
                            _splitStream =
                                new StreamWriter(
                                    new FileStream(
                                        string.Concat(_destinationPath, _splitFileName, _splitText, ".",
                                            _splitExtension), FileMode.OpenOrCreate), Encoding.UTF8);
                        }

                        if (_splitStream == null)
                        {
                            if (SplitDefaultRadioButton.Checked)
                                _splitText = string.Concat("split", _splitNumber++);
                            if (NumberSplitRadioButton.Checked)
                                _splitText = _splitNumber++.ToString();
                            if (TimeStampRadioButton.Checked)
                                _splitText = DateTime.Now.ToFileTimeUtc().ToString();
                            if (CustomRadioButton.Checked)
                                _splitText = string.Concat(CustomSplitTextBox.Text, _splitNumber++);

                            //new file!!
                            _splitStream =
                                new StreamWriter(
                                    new FileStream(
                                        string.Concat(_destinationPath, _splitFileName, _splitText, ".",
                                            _splitExtension), FileMode.OpenOrCreate), Encoding.UTF8);
                        }

                        var line = reader.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            _splitStream.WriteLine(line);
                        }

                    }
                }
                MessageBox.Show(string.Format(Resources.SplitIsDone, _splitNumber, _destinationPath), Resources.DoneZo, MessageBoxButtons.OK);
            }
            //release our handles and reset our globals
            if (_splitStream == null) return;
            _stream = null;
            _splitNumber = 0;
            _splitStream.Flush();
            _splitStream.Close();
            _splitStream.Dispose();
            _splitStream = null;
        }

        private void OpenDestinationFileDialogButtonClicked(object sender, EventArgs e)
        {
            using (var fileDialog = new FolderBrowserDialog {ShowNewFolderButton = true})
            {
                var result = fileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _destinationPath = DestinationPathText.Text = fileDialog.SelectedPath;
                }
            }
        }

        private void SplitDefaultRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    CustomSplitTextBox.Enabled = false;
                }
            }
        }

        private void NumberSplitRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    CustomSplitTextBox.Enabled = false;
                }
            }
        }

        private void TimeStampRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    CustomSplitTextBox.Enabled = false;
                }
            }
        }

        private void CustomRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    CustomSplitTextBox.Enabled = true;
                }
            }
        }
    }
}
