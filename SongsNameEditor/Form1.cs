using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongsNameEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font(
                      "Microsoft Sans Serif",
                      14F,
                      System.Drawing.FontStyle.Regular,
                      System.Drawing.GraphicsUnit.Point,
                      ((byte)(0)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font(
                      "Microsoft Sans Serif",
                      14F,
                      System.Drawing.FontStyle.Regular,
                      System.Drawing.GraphicsUnit.Point,
                      ((byte)(0)));
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPathBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShuffleSongNames(object sender, EventArgs e)
        {
            try
            {
                var allFiles = GetAllFiles();

                List<int> randomOrder = Enumerable.Range(1, allFiles.Count).ToList();
                randomOrder = randomOrder.OrderBy(a => Guid.NewGuid()).ToList();

                var numberOfDigits = Math.Max(2, Math.Ceiling(Math.Log10(randomOrder.Count)));
                int i = 0;
                foreach (var filePath in allFiles)
                {
                    var fileName = Path.GetFileName(filePath);
                    string num = randomOrder[i++].ToString();

                    while (num.Length < numberOfDigits)
                        num = "0" + num;

                    System.IO.File.Move(filePath, Path.GetDirectoryName(filePath) + "\\" + num + ". " + fileName);
                }

            }
            catch
            {
                return;
            }

            System.Windows.Forms.MessageBox.Show("Successful");
        }

        private List<String> GetAllFiles()
        {
            string folderPath = "";

            if (!string.IsNullOrWhiteSpace(folderPathBox.Text))
            {
                folderPath = folderPathBox.Text;
            }

            try
            {
                string[] files = Directory.GetFiles(folderPath);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Wrong folder path");
                throw new Exception();
            }

            List<String> extensions = new List<String>();

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        extensions.Add(c.Text);
                    }
                }
            }

            if (CustomExtensionTextBox.Text.Length != 0)
            {
                if (CustomExtensionTextBox.Text[0] != '.')
                {
                    extensions.Add("." + CustomExtensionTextBox.Text);
                }
                else
                {
                    extensions.Add(CustomExtensionTextBox.Text);
                }
            }
            List<String> fileNames = new List<String>();

            foreach(var extension in extensions)
            {
                fileNames.AddRange(System.IO.Directory.GetFiles(folderPath, "*" + extension).ToList());
            }

            return fileNames;
        }

        private void DeleteNumbersFromSongs(object sender, EventArgs e)
        {
            try
            {
                var allFiles = GetAllFiles();

                foreach (var filePath in allFiles)
                {
                    var fileName = Path.GetFileName(filePath);
                    string pattern = @"^[0-9]+[ .]*";   // or @"^\d+";
                    string newName = Regex.Replace(fileName, pattern, "");

                    System.IO.File.Move(filePath, Path.GetDirectoryName(filePath) + "\\" + newName);
                }

            }
            catch
            {
                return;
            }

            System.Windows.Forms.MessageBox.Show("Successful");
        }
    }
}
