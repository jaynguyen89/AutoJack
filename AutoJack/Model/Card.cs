using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.Interface;

namespace AutoJack.Model {

    class Card : ICard {
        public Suit Suit { get; set; }
        public Pip Pip { get; set; }
        public bool Set { get; set; }

        public Card() { }

        public Card(Suit Suit, Pip Pip) {
            this.Suit = Suit;
            this.Pip = Pip;
            Set = true;
        }

        public int GetCardValue() {
            return (Pip == Pip.Ace) ? 1 : (
                (Pip == Pip.Two) ? 2 : (
                (Pip == Pip.Three) ? 3 : (
                (Pip == Pip.Four) ? 4 : (
                (Pip == Pip.Five) ? 5 : (
                (Pip == Pip.Six) ? 6 : (
                (Pip == Pip.Seven) ? 7 : (
                (Pip == Pip.Eight) ? 8 : (
                (Pip == Pip.Nine) ? 9 : 10))))))));
        }
    }
}
