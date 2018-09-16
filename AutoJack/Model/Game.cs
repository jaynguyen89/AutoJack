using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Model {

    public class Game {
        const int DECKSIZE = 52;
        public bool ShouldWarn { get; set; }
        public int TurnWho { get; set; }

        public Player Player { get; set; }
        public Machine Machine { get; set; }

        internal List<Card> Deck { get; set; }
        public string Winner { get; set; }

        public string Logs { get; set; }

        public Game(Player Player, Machine Machine) {
            this.Player = Player;
            this.Machine = Machine;
            ShouldWarn = false;
            TurnWho = -1;
            Winner = String.Empty;
        }

        internal int GetHandSumFor(List<Card> Hand) {
            int HandSum = 0;
            foreach (Card Card in Hand)
                HandSum += Card.GetCardValue();

            return HandSum;
        }

        internal bool CheckIdenticalHand(string Who, string HandName) {
            if (Who == "Player" && HandName == "Hand1") {
                if (Player.Hand1.Count != 2)
                    return false;

                if (Player.Hand1.ElementAt(0).GetCardValue() == Player.Hand1.ElementAt(1).GetCardValue())
                    return true;
            }

            if (Who == "Player" && HandName == "Hand2") {
                if (Player.Hand2.Count != 2)
                    return false;

                if (Player.Hand2.ElementAt(0).GetCardValue() == Player.Hand2.ElementAt(1).GetCardValue())
                    return true;
            }

            if (Who == "Machine" && HandName == "Hand1") {
                if (Machine.Hand1.Count != 2)
                    return false;

                if (Machine.Hand1.ElementAt(0).GetCardValue() == Machine.Hand1.ElementAt(1).GetCardValue())
                    return true;
            }

            if (Who == "Machine" && HandName == "Hand2") {
                if (Machine.Hand2.Count != 2)
                    return false;

                if (Machine.Hand2.ElementAt(0).GetCardValue() == Machine.Hand2.ElementAt(1).GetCardValue())
                    return true;
            }

            return false;
        }
    }
}
