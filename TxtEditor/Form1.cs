using System;
using System.IO;
using System.Windows.Forms;

namespace TxtEditor
{
    public partial class Form1 : Form
    {
        string currentPath, currentFolder;
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderToOpen = new FolderBrowserDialog();
            DialogResult wynik = folderToOpen.ShowDialog();

            if (wynik == DialogResult.OK)
            {
                open.Visible = true;
                currentPath = folderToOpen.SelectedPath;
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = currentFolder;
            saveFile.Filter = "Wszystkie plik *|.*|";
            DialogResult wynik = saveFile.ShowDialog();

            if (wynik == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName)
                {
                }
            }
            
            Update(false);

        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = currentPath;
            openFileDialog.Title = "Wybierz dobrze";
           

            DialogResult wynik = openFileDialog.ShowDialog();
            currentPath = openFileDialog.FileName;
            currentFolder = openFileDialog.InitialDirectory;

            if (wynik == DialogResult.OK)
            {
                textBox1.Text = "";
                using (StreamReader sr = new StreamReader(currentPath))
                {
                    while (!sr.EndOfStream)
                    {
                        textBox1.Text += sr.ReadLine() + "\r\n";
                    }
                }

            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Update(true);
        }

        private void Update(bool changed)
        {
            if (changed && currentPath.Contains(".txt"))
            {
                save.Visible = true;
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }
    }
}
