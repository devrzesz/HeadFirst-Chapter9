using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SerializeCards
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private Deck RandomDeck(int Number)
        {
            Deck myDeck = new Deck();

            for (int i = 0; i < Number; i++)
            {
                myDeck.Add(new Cards((Suits)random.Next(4), (Values)random.Next(13)));
            }

            return myDeck;

        }

        private void DealCards(Deck deckToDeal, string Title)
        {
            Console.WriteLine(Title);
            while (deckToDeal.Count > 0)
            {
                Cards nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }

            Console.WriteLine("==================================");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);

            using (Stream output = File.Create("Zestaw1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, deckToWrite);
            }

            DealCards(deckToWrite, "To co zapisałem w pliku: ");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Deck deckToRead;

            using (Stream input = File.OpenRead("Zestaw1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                deckToRead = (Deck)bf.Deserialize(input);
                DealCards(deckToRead, "To co odczytałem z pliku: ");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Zestaw2.dat")) 
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i < 10; i++)
                {
                    Deck deckToWrite = new Deck();
                    deckToWrite = RandomDeck(5 + i);
                    bf.Serialize(output, deckToWrite);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Zestaw2.dat"))
            {
                Deck deckToRead;
                BinaryFormatter bf = new BinaryFormatter();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"To jest zestaw numer {i+1}.");

                    deckToRead = (Deck)bf.Deserialize(input);
                    DealCards(deckToRead, "To co odczytałem z pliku: ");

                }
            }
        }
    }
}
