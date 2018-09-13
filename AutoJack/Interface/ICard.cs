using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Interface {

    enum Suit { Hearts, Spades, Clubs, Diamonds };
    enum Pip { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    interface ICard {
        Suit Suit { get; }
        Pip Pip { get; }
        bool Set { get; set; }

        int GetCardValue();
    }
}
