using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Model {

    public class Machine {
        public int Bet { get; set; }
        public int Insurance { get; set; }
        internal List<Card> Hand1 { get; set; }
        internal List<Card> Hand2 { get; set; }
        public bool Hand1Flipped { get; set; }
        public bool Hand2Flipped { get; set; }

        public Machine() {
            Bet = 0;
            Insurance = 0;
            Hand1 = new List<Card>();
            Hand2 = new List<Card>();
            Hand1Flipped = false;
            Hand2Flipped = false;
        }

        internal void AddHand1(Card Card) {
            Hand1.Add(Card);
        }

        internal void AddHand2(Card Card) {
            Hand2.Add(Card);
        }
    }
}
