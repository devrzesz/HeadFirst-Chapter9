using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka !");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");

            foreach (byte b in eurekaBytes)
            {
                Console.Write($"{b} ");
            }

            Console.WriteLine();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");

            foreach (byte b in eurekaBytes)
            {
                Console.Write($"{b:x2} ");
            }

            Console.WriteLine();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "שלום", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");

            foreach (byte b in eurekaBytes)
            {
                Console.Write($"{b:x2} ");
            }

            Console.WriteLine();
        }

        private void BinaryWrite()
        {
            FileStream stream = new FileStream();
        }
        
    }
}
