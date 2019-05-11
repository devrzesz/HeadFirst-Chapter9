using System.IO;
using System;
using System.Text;

namespace Temporary
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 15;
            string stringValue = "coscos";
            byte[] byteArray = new byte[] { 34, 21, 33 };
            float floatValue = 123.2F;
            char charValye = 'c';

            Console.ReadKey();

            using (FileStream fs = File.Create(@"C:\Users\a.rzeszowski\Desktop\text files\duopa.txt"))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(intValue + "\r\n");
                writer.Write(stringValue + "\r\n");
                writer.Write(byteArray + "\r\n");
                writer.Write(floatValue + "\r\n");
                writer.Write(charValye + "\r\n");

            }

            Console.ReadKey();

        }

    }
}
