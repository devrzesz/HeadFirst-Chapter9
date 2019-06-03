using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentsNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string opponent in opponentsNames)
            {
                players.Add(new Player(opponent, random, textBoxOnForm));
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 1; i < 5; i++)
            {
                foreach (Player player in players)
                {
                    player.TakeCard(stock.Deal());
                }
            }
        }

        internal bool PlayOneRound(int selectedIndex)
        {
            throw new NotImplementedException();
        }

        internal string GetWinnerName()
        {
            throw new NotImplementedException();
        }

        internal string DescribeBooks()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<string> GetPlayesCardNames()
        {
            throw new NotImplementedException();
        }
    }
}
