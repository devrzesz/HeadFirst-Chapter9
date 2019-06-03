using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeCards
{
    [Serializable]
    class Deck
    {
        Random random = new Random();
        public List<Cards> deck;

        public Cards Peek(int cardNumber)
        {
            return deck[cardNumber];
        }

        public Cards Deal()
        {
            return Deal(0);
        }


        public bool ContainsValue(Values value)
        {
            foreach (Cards card in deck)
            {
                if (card.Value == value)
                {
                    return true;
                }
            }
            return false;

        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Cards[] { });
            for (int i = deck.Count -1; i >= 0 ; i--)
            {
                if (deck[i].Value == value)
                {
                    deckToReturn.Add(deck[i]);
                }
            }
            return deckToReturn;
        }

        public bool HasBook(Values value)
        {
            int numberOfCards = 0;
            foreach(Cards card in deck)
            {
                if(card.Value == value)
                {
                    numberOfCards++;
                }
            }

            if (numberOfCards == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Deck()
        {
            deck = new List<Cards>();
            //AddCardsToDeck();
        }

        public Deck(IEnumerable<Cards> initialCards)
        {
            deck = new List<Cards>(initialCards);
        }

        public void Add(Cards cardToAdd)
        {
            deck.Add(cardToAdd);
        }


        private void AddCardsToDeck()
        {
            for (int suit = 0; suit < 4; suit++)
                for (int value = 0; value < 13; value++)
                    deck.Add(new Cards((Suits)suit,(Values)value));
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[deck.Count];
            for (int i = 0; i < deck.Count; i++)
                CardNames[i] = deck[i].Name;
            return CardNames;
        }

        public string[] GetCardNames2()
        {
            string[] CardNames = new string[deck.Count];
            for (int i = 0; i < deck.Count; i++)
                CardNames[i] = deck[i].Name;
            return CardNames;
        }

        public int Count { get => deck.Count;}

     
        public override string ToString()
        {
            return $"Deck has {deck.Count} cards.";
        }

        public void Sort()
        {
            deck.Sort(new CardComparer_ByValue());
        }

 

        public void Move(Deck deckToMove, int indexToMove)
        {
            MessageBox.Show(indexToMove.ToString());
            deckToMove.deck.Add(this.deck[indexToMove]);
            this.deck.RemoveAt(indexToMove);
        }

        public Cards Deal(int selectedIndex) 
        {
            Cards CardToDeal = deck[selectedIndex];
            deck.RemoveAt(selectedIndex);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Cards> newList = new List<Cards>();
            while (deck.Count>0)
            {
                int cardToMove = random.Next(deck.Count);
                newList.Add(deck[cardToMove]);
                deck.RemoveAt(cardToMove);
            }

            deck = newList;
        }
    }
}
