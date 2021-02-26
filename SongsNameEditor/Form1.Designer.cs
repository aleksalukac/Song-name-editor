
namespace SongsNameEditor
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mp3CheckBox = new System.Windows.Forms.CheckBox();
            this.m4aCheckBox = new System.Windows.Forms.CheckBox();
            this.flacCheckBox = new System.Windows.Forms.CheckBox();
            this.mp4CheckBox = new System.Windows.Forms.CheckBox();
            this.wavCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomExtensionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShuffleSongs = new System.Windows.Forms.Button();
            this.DeleteNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderPathBox
            // 
            this.folderPathBox.Location = new System.Drawing.Point(33, 38);
            this.folderPathBox.Name = "folderPathBox";
            this.folderPathBox.Size = new System.Drawing.Size(372, 20);
            this.folderPathBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mp3CheckBox
            // 
            this.mp3CheckBox.AutoSize = true;
            this.mp3CheckBox.Location = new System.Drawing.Point(33, 118);
            this.mp3CheckBox.Name = "mp3CheckBox";
            this.mp3CheckBox.Size = new System.Drawing.Size(49, 17);
            this.mp3CheckBox.TabIndex = 2;
            this.mp3CheckBox.Text = ".mp3";
            this.mp3CheckBox.UseVisualStyleBackColor = true;
            this.mp3CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // m4aCheckBox
            // 
            this.m4aCheckBox.AutoSize = true;
            this.m4aCheckBox.Location = new System.Drawing.Point(88, 118);
            this.m4aCheckBox.Name = "m4aCheckBox";
            this.m4aCheckBox.Size = new System.Drawing.Size(49, 17);
            this.m4aCheckBox.TabIndex = 3;
            this.m4aCheckBox.Text = ".m4a";
            this.m4aCheckBox.UseVisualStyleBackColor = true;
            // 
            // flacCheckBox
            // 
            this.flacCheckBox.AutoSize = true;
            this.flacCheckBox.Location = new System.Drawing.Point(143, 118);
            this.flacCheckBox.Name = "flacCheckBox";
            this.flacCheckBox.Size = new System.Drawing.Size(46, 17);
            this.flacCheckBox.TabIndex = 4;
            this.flacCheckBox.Text = ".flac";
            this.flacCheckBox.UseVisualStyleBackColor = true;
            // 
            // mp4CheckBox
            // 
            this.mp4CheckBox.AutoSize = true;
            this.mp4CheckBox.Location = new System.Drawing.Point(195, 118);
            this.mp4CheckBox.Name = "mp4CheckBox";
            this.mp4CheckBox.Size = new System.Drawing.Size(49, 17);
            this.mp4CheckBox.TabIndex = 5;
            this.mp4CheckBox.Text = ".mp4";
            this.mp4CheckBox.UseVisualStyleBackColor = true;
            // 
            // wavCheckBox
            // 
            this.wavCheckBox.AutoSize = true;
            this.wavCheckBox.Location = new System.Drawing.Point(250, 118);
            this.wavCheckBox.Name = "wavCheckBox";
            this.wavCheckBox.Size = new System.Drawing.Size(49, 17);
            this.wavCheckBox.TabIndex = 6;
            this.wavCheckBox.Text = ".wav";
            this.wavCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose extensions to modify:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomExtensionTextBox
            // 
            this.CustomExtensionTextBox.Location = new System.Drawing.Point(127, 148);
            this.CustomExtensionTextBox.Name = "CustomExtensionTextBox";
            this.CustomExtensionTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomExtensionTextBox.TabIndex = 8;
            this.CustomExtensionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Or add custom:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShuffleSongs
            // 
            this.ShuffleSongs.Location = new System.Drawing.Point(32, 193);
            this.ShuffleSongs.Name = "ShuffleSongs";
            this.ShuffleSongs.Size = new System.Drawing.Size(94, 38);
            this.ShuffleSongs.TabIndex = 10;
            this.ShuffleSongs.Text = "Shuffle songs";
            this.ShuffleSongs.UseVisualStyleBackColor = true;
            this.ShuffleSongs.Click += new System.EventHandler(this.ShuffleSongNames);
            // 
            // DeleteNumbers
            // 
            this.DeleteNumbers.Location = new System.Drawing.Point(311, 193);
            this.DeleteNumbers.Name = "DeleteNumbers";
            this.DeleteNumbers.Size = new System.Drawing.Size(94, 38);
            this.DeleteNumbers.TabIndex = 11;
            this.DeleteNumbers.Text = "Delete song numbers";
            this.DeleteNumbers.UseVisualStyleBackColor = true;
            this.DeleteNumbers.Click += new System.EventHandler(this.DeleteNumbersFromSongs);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 271);
            this.Controls.Add(this.DeleteNumbers);
            this.Controls.Add(this.ShuffleSongs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomExtensionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wavCheckBox);
            this.Controls.Add(this.mp4CheckBox);
            this.Controls.Add(this.flacCheckBox);
            this.Controls.Add(this.m4aCheckBox);
            this.Controls.Add(this.mp3CheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.folderPathBox);
            this.Name = "Form1";
            this.Text = "Modify audio files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox folderPathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox mp3CheckBox;
        private System.Windows.Forms.CheckBox m4aCheckBox;
        private System.Windows.Forms.CheckBox flacCheckBox;
        private System.Windows.Forms.CheckBox mp4CheckBox;
        private System.Windows.Forms.CheckBox wavCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomExtensionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShuffleSongs;
        private System.Windows.Forms.Button DeleteNumbers;
    }
}

