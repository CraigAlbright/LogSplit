using System.Drawing;

namespace LogSplitDotNet
{
    partial class SplitForm
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
            this.SourcePathText = new System.Windows.Forms.TextBox();
            this.OpenSourceFileDialogButton = new System.Windows.Forms.Button();
            this.SplitFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DestinationPathText = new System.Windows.Forms.TextBox();
            this.OpenDestinationFileDialogButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SplitSizeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CustomSplitTextBox = new System.Windows.Forms.TextBox();
            this.SplitOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomRadioButton = new System.Windows.Forms.RadioButton();
            this.TimeStampRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberSplitRadioButton = new System.Windows.Forms.RadioButton();
            this.SplitDefaultRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitSizeSpinEdit.Properties)).BeginInit();
            this.SplitOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourcePathText
            // 
            this.SourcePathText.Location = new System.Drawing.Point(24, 51);
            this.SourcePathText.Name = "SourcePathText";
            this.SourcePathText.Size = new System.Drawing.Size(542, 26);
            this.SourcePathText.TabIndex = 0;
            // 
            // OpenSourceFileDialogButton
            // 
            this.OpenSourceFileDialogButton.Location = new System.Drawing.Point(574, 44);
            this.OpenSourceFileDialogButton.Name = "OpenSourceFileDialogButton";
            this.OpenSourceFileDialogButton.Size = new System.Drawing.Size(36, 41);
            this.OpenSourceFileDialogButton.TabIndex = 1;
            this.OpenSourceFileDialogButton.Text = "...";
            this.OpenSourceFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenSourceFileDialogButton.Click += new System.EventHandler(this.OpenSourceFileDialogButtonClicked);
            // 
            // SplitFileButton
            // 
            this.SplitFileButton.Location = new System.Drawing.Point(590, 186);
            this.SplitFileButton.Name = "SplitFileButton";
            this.SplitFileButton.Size = new System.Drawing.Size(197, 124);
            this.SplitFileButton.TabIndex = 2;
            this.SplitFileButton.Text = "Split It!";
            this.SplitFileButton.UseVisualStyleBackColor = true;
            this.SplitFileButton.Click += new System.EventHandler(this.SplitFileButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Split Size in MB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination File Path";
            // 
            // DestinationPathText
            // 
            this.DestinationPathText.Location = new System.Drawing.Point(25, 122);
            this.DestinationPathText.Name = "DestinationPathText";
            this.DestinationPathText.Size = new System.Drawing.Size(542, 26);
            this.DestinationPathText.TabIndex = 6;
            // 
            // OpenDestinationFileDialogButton
            // 
            this.OpenDestinationFileDialogButton.Location = new System.Drawing.Point(574, 115);
            this.OpenDestinationFileDialogButton.Name = "OpenDestinationFileDialogButton";
            this.OpenDestinationFileDialogButton.Size = new System.Drawing.Size(36, 41);
            this.OpenDestinationFileDialogButton.TabIndex = 8;
            this.OpenDestinationFileDialogButton.Text = "...";
            this.OpenDestinationFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenDestinationFileDialogButton.Click += new System.EventHandler(this.OpenDestinationFileDialogButtonClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = LogSplitDotNet.Properties.Resources.ResourceManager.GetObject("sliced bread") as System.Drawing.Image;
            this.pictureBox1.Location = new System.Drawing.Point(642, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SplitSizeSpinEdit
            // 
            this.SplitSizeSpinEdit.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SplitSizeSpinEdit.Location = new System.Drawing.Point(26, 203);
            this.SplitSizeSpinEdit.Name = "SplitSizeSpinEdit";
            this.SplitSizeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SplitSizeSpinEdit.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SplitSizeSpinEdit.Properties.IsFloatValue = false;
            this.SplitSizeSpinEdit.Properties.Mask.EditMask = "N00";
            this.SplitSizeSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.SplitSizeSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SplitSizeSpinEdit.Size = new System.Drawing.Size(115, 28);
            this.SplitSizeSpinEdit.TabIndex = 10;
            // 
            // CustomSplitTextBox
            // 
            this.CustomSplitTextBox.Location = new System.Drawing.Point(258, 29);
            this.CustomSplitTextBox.Name = "CustomSplitTextBox";
            this.CustomSplitTextBox.Size = new System.Drawing.Size(151, 26);
            this.CustomSplitTextBox.TabIndex = 11;
            // 
            // SplitOptionsGroupBox
            // 
            this.SplitOptionsGroupBox.Controls.Add(this.CustomRadioButton);
            this.SplitOptionsGroupBox.Controls.Add(this.TimeStampRadioButton);
            this.SplitOptionsGroupBox.Controls.Add(this.NumberSplitRadioButton);
            this.SplitOptionsGroupBox.Controls.Add(this.SplitDefaultRadioButton);
            this.SplitOptionsGroupBox.Controls.Add(this.CustomSplitTextBox);
            this.SplitOptionsGroupBox.Location = new System.Drawing.Point(169, 175);
            this.SplitOptionsGroupBox.Name = "SplitOptionsGroupBox";
            this.SplitOptionsGroupBox.Size = new System.Drawing.Size(415, 135);
            this.SplitOptionsGroupBox.TabIndex = 13;
            this.SplitOptionsGroupBox.TabStop = false;
            this.SplitOptionsGroupBox.Text = "split type";
            // 
            // CustomRadioButton
            // 
            this.CustomRadioButton.AutoSize = true;
            this.CustomRadioButton.Location = new System.Drawing.Point(163, 30);
            this.CustomRadioButton.Name = "CustomRadioButton";
            this.CustomRadioButton.Size = new System.Drawing.Size(89, 24);
            this.CustomRadioButton.TabIndex = 15;
            this.CustomRadioButton.TabStop = true;
            this.CustomRadioButton.Text = "Custom";
            this.CustomRadioButton.UseVisualStyleBackColor = true;
            this.CustomRadioButton.CheckedChanged += new System.EventHandler(this.CustomRadioButtonCheckedChanged);
            // 
            // TimeStampRadioButton
            // 
            this.TimeStampRadioButton.AutoSize = true;
            this.TimeStampRadioButton.Location = new System.Drawing.Point(16, 94);
            this.TimeStampRadioButton.Name = "TimeStampRadioButton";
            this.TimeStampRadioButton.Size = new System.Drawing.Size(112, 24);
            this.TimeStampRadioButton.TabIndex = 14;
            this.TimeStampRadioButton.TabStop = true;
            this.TimeStampRadioButton.Text = "time stamp";
            this.TimeStampRadioButton.UseVisualStyleBackColor = true;
            this.TimeStampRadioButton.CheckedChanged += new System.EventHandler(this.TimeStampRadioButtonCheckedChanged);
            // 
            // NumberSplitRadioButton
            // 
            this.NumberSplitRadioButton.AutoSize = true;
            this.NumberSplitRadioButton.Location = new System.Drawing.Point(16, 62);
            this.NumberSplitRadioButton.Name = "NumberSplitRadioButton";
            this.NumberSplitRadioButton.Size = new System.Drawing.Size(88, 24);
            this.NumberSplitRadioButton.TabIndex = 13;
            this.NumberSplitRadioButton.TabStop = true;
            this.NumberSplitRadioButton.Text = "number";
            this.NumberSplitRadioButton.UseVisualStyleBackColor = true;
            this.NumberSplitRadioButton.CheckedChanged += new System.EventHandler(this.NumberSplitRadioButtonCheckedChanged);
            // 
            // SplitDefaultRadioButton
            // 
            this.SplitDefaultRadioButton.AutoSize = true;
            this.SplitDefaultRadioButton.Location = new System.Drawing.Point(16, 30);
            this.SplitDefaultRadioButton.Name = "SplitDefaultRadioButton";
            this.SplitDefaultRadioButton.Size = new System.Drawing.Size(62, 24);
            this.SplitDefaultRadioButton.TabIndex = 12;
            this.SplitDefaultRadioButton.TabStop = true;
            this.SplitDefaultRadioButton.Text = "split";
            this.SplitDefaultRadioButton.UseVisualStyleBackColor = true;
            this.SplitDefaultRadioButton.CheckedChanged += new System.EventHandler(this.SplitDefaultRadioButtonCheckedChanged);
            // 
            // SplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.SplitOptionsGroupBox);
            this.Controls.Add(this.SplitSizeSpinEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenDestinationFileDialogButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DestinationPathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SplitFileButton);
            this.Controls.Add(this.OpenSourceFileDialogButton);
            this.Controls.Add(this.SourcePathText);
            this.Name = "SplitForm";
            this.Text = "Log Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitSizeSpinEdit.Properties)).EndInit();
            this.SplitOptionsGroupBox.ResumeLayout(false);
            this.SplitOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourcePathText;
        private System.Windows.Forms.Button OpenSourceFileDialogButton;
        private System.Windows.Forms.Button SplitFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DestinationPathText;
        private System.Windows.Forms.Button OpenDestinationFileDialogButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SpinEdit SplitSizeSpinEdit;
        private System.Windows.Forms.TextBox CustomSplitTextBox;
        private System.Windows.Forms.GroupBox SplitOptionsGroupBox;
        private System.Windows.Forms.RadioButton CustomRadioButton;
        private System.Windows.Forms.RadioButton TimeStampRadioButton;
        private System.Windows.Forms.RadioButton NumberSplitRadioButton;
        private System.Windows.Forms.RadioButton SplitDefaultRadioButton;

    }
}

