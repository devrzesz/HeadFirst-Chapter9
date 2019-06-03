using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    class Player
    {
        private string name;
        public string Name { get { return name } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;


        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            textBoxOnForm.Text += $"/r/n{name} dołączył do gry.";
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;

                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                    {
                        howMany++
                    }
                    if (howMany == 4)
                    {
                        books.Add(value);
                    }

                    for (int card = cards.Count - 1; card >= 0; card--)
                    {
                        cards.Deal(card);
                    }
                }

            }

            return books;
        }

        public Values GetRandomValue()
        {
            // Ta metoda pobiera losową wartość, ale musi s i ę ona znajdować w zestawie.
        }

        public Deck DoYoHaveAny(Values value)
        {
            // To tu ta j przeciwnik sprawdza, czy masz ka rty o o k re ślo n e j w a rto śc i.
            // Wartości wyciągane są za pomocą metody Deck.PullOutValu es(). Dodaj do k o n tro lk i
            // TextBox napis „ Janek ma 3 s z ó s t k i" - u żyj nowej s ta ty c z n e j metody C a rd .P lu ra l().
        }

        public AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            //Tu j e s t przeciążona wersja AskForACard() - wybierz z zestawu losową wartość
            // p rzy użyciu GetRandomValue() i zażądaj j e j za pomocą AskForACard().
        }
        public AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            // Zażądaj o k re ślo n e j wartości od innych graczy.Na początku dodaj do pola tekstowego wiersz
            //o p o s ta c i: „ Janek pyta, czy k to ś ma damę". Następnie p rz e jd ź przez l i s t ę graczy przekazanych
            //do metody w p o s ta c i parametrów i sp y ta j każdego z n ich , czy ma daną wartość, przy użyciu
            //metody DoYouHaveAny().Przekaże ona zestaw ka rt -dodaj j e do bieżącego zestawu.
            //Sprawdź, i l e ka rt zo s ta ło dodanych. J e ż e l i nie było żadnej, to p o c ią g n ij
            //jedną kartę z kupki(ona także zo s ta ła przekazana w p o s ta c i parametru). Na końcu
            //powinieneś dodać do k o n tro lk i TextBox w iersz o p o s ta c i: „ Janek pobrał kartę z ku pk i".
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Cards card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Cards Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }


    }
}
