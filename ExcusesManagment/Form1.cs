using System;
using System.IO;
using System.Windows.Forms;
using LibraryClassTest;

namespace ExcusesManagment
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        private string selectedFolder = "";

        
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        private void folder_Click_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save_Click.Enabled = true;
                open_Click.Enabled = true;
                random_Click.Enabled = true;
            }
        }

        private void save_Click_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(description.Text) || String.IsNullOrWhiteSpace(results.Text))
            {
                MessageBox.Show("Okres wymowke i  rezultat", "Nie mozna zapisac pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Piliki tekstowe (.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = description.Text;

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymowka zapisana", "Udało się",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void open_Click_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                openFileDialog1.FileName = description.Text;

                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);

                }
            }

        }
        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuowac?\r\n ", "Ostrzezenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    return true;
                }

            return false;
         
            }

            return true;
        }

        private void random_Click_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;

                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }

                this.Text = "Program do zarzadzania wymowkami";
            }

            else
            {
                this.Text = "Program do zarzadzania wymowkami*";
            }

            this.formChanged = changed;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(description.Text))
            {
                currentExcuse.Description = description.Text;
            }

            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(results.Text))
            {
                currentExcuse.Results = results.Text;
            }

            UpdateForm(true);

        }

        private void LastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);

        }
    }
}
