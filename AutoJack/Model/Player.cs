using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Model {
    public class Player : User {
        public int Bet { get; set; }
        public int Insurance { get; set; }
        internal List<Card> Hand1 { get; set; }
        internal List<Card> Hand2 { get; set; }
        public bool Hand1Flipped { get; set; }
        public bool Hand2Flipped { get; set; }

        public Player() { }

        public Player(
                string id,
                string UserName,
                int Balance,
                int WinStreak,
                int WinCount,
                int LoseCount,
                int Games,
                int Owing,
                double AvgBet,
                int MaxBet,
                int MinBet,
                string LastPlay,
                int CurrentStreak
            ) :
            base(
                    id, UserName, Balance,
                    WinStreak, WinCount,
                    LoseCount, Games, Owing,
                    AvgBet, MaxBet, MinBet,
                    LastPlay, CurrentStreak
                ) {
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
