using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Model {

    public class Game {
        const int DECKSIZE = 52;
        public bool ShouldWarn { get; set; }

        public Player Player { get; set; }
        public Machine Machine { get; set; }

        internal List<Card> Deck { get; set; }

        public Game(Player Player, Machine Machine) {
            this.Player = Player;
            this.Machine = Machine;
            ShouldWarn = false;
        }

        internal int GetHandSumFor(List<Card> Hand) {
            int HandSum = 0;
            foreach (Card Card in Hand)
                HandSum += Card.GetCardValue();

            return HandSum;
        }
    }
}
