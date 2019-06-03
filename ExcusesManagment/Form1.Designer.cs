namespace ExcusesManagment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.fileDate = new System.Windows.Forms.TextBox();
            this.folder_Click = new System.Windows.Forms.Button();
            this.save_Click = new System.Windows.Forms.Button();
            this.open_Click = new System.Windows.Forms.Button();
            this.random_Click = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wymówka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wyniki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ostatnio użyte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data pliku";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(118, 22);
            this.description.Margin = new System.Windows.Forms.Padding(2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(194, 20);
            this.description.TabIndex = 4;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(118, 51);
            this.results.Margin = new System.Windows.Forms.Padding(2);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(194, 20);
            this.results.TabIndex = 5;
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // fileDate
            // 
            this.fileDate.Location = new System.Drawing.Point(118, 108);
            this.fileDate.Margin = new System.Windows.Forms.Padding(2);
            this.fileDate.Name = "fileDate";
            this.fileDate.Size = new System.Drawing.Size(194, 20);
            this.fileDate.TabIndex = 7;
            // 
            // folder_Click
            // 
            this.folder_Click.Location = new System.Drawing.Point(16, 155);
            this.folder_Click.Margin = new System.Windows.Forms.Padding(2);
            this.folder_Click.Name = "folder_Click";
            this.folder_Click.Size = new System.Drawing.Size(56, 27);
            this.folder_Click.TabIndex = 8;
            this.folder_Click.Text = "Folder";
            this.folder_Click.UseVisualStyleBackColor = true;
            this.folder_Click.Click += new System.EventHandler(this.folder_Click_Click);
            // 
            // save_Click
            // 
            this.save_Click.Enabled = false;
            this.save_Click.Location = new System.Drawing.Point(84, 155);
            this.save_Click.Margin = new System.Windows.Forms.Padding(2);
            this.save_Click.Name = "save_Click";
            this.save_Click.Size = new System.Drawing.Size(56, 27);
            this.save_Click.TabIndex = 9;
            this.save_Click.Text = "Zapisz";
            this.save_Click.UseVisualStyleBackColor = true;
            this.save_Click.Click += new System.EventHandler(this.save_Click_Click);
            // 
            // open_Click
            // 
            this.open_Click.Enabled = false;
            this.open_Click.Location = new System.Drawing.Point(152, 155);
            this.open_Click.Margin = new System.Windows.Forms.Padding(2);
            this.open_Click.Name = "open_Click";
            this.open_Click.Size = new System.Drawing.Size(56, 27);
            this.open_Click.TabIndex = 10;
            this.open_Click.Text = "Otworz";
            this.open_Click.UseVisualStyleBackColor = true;
            this.open_Click.Click += new System.EventHandler(this.open_Click_Click);
            // 
            // random_Click
            // 
            this.random_Click.Enabled = false;
            this.random_Click.Location = new System.Drawing.Point(213, 155);
            this.random_Click.Margin = new System.Windows.Forms.Padding(2);
            this.random_Click.Name = "random_Click";
            this.random_Click.Size = new System.Drawing.Size(99, 27);
            this.random_Click.TabIndex = 11;
            this.random_Click.Text = "Losowa wymowka";
            this.random_Click.UseVisualStyleBackColor = true;
            this.random_Click.Click += new System.EventHandler(this.random_Click_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(118, 79);
            this.lastUsed.Margin = new System.Windows.Forms.Padding(2);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(194, 20);
            this.lastUsed.TabIndex = 12;
            this.lastUsed.ValueChanged += new System.EventHandler(this.LastUsed_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 220);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.random_Click);
            this.Controls.Add(this.open_Click);
            this.Controls.Add(this.save_Click);
            this.Controls.Add(this.folder_Click);
            this.Controls.Add(this.fileDate);
            this.Controls.Add(this.results);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 247);
            this.MinimumSize = new System.Drawing.Size(343, 247);
            this.Name = "Form1";
            this.Text = "Program do zarzadzania wymowkami !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.TextBox fileDate;
        private System.Windows.Forms.Button folder_Click;
        private System.Windows.Forms.Button save_Click;
        private System.Windows.Forms.Button open_Click;
        private System.Windows.Forms.Button random_Click;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker lastUsed;
    }
}

