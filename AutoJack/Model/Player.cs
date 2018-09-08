using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Model {

    public class Player {

        public Player(string id, string PlayerName) {
            this.Id = id;
            Name = PlayerName;
            Balance = Winstreak = WinCount = LoseCount = Owing = 0;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Winstreak { get; set; }
        public int WinCount { get; set; }
        public int LoseCount { get; set; }
        public int Games { get; set; }
        public int Owing { get; set; }
        public double AverageBet { get; set; }
        public int MaxBet { get; set; }
        public int MinBet { get; set; }
        public string LastPlay { get; set; }
        public int CurrentStreak { get; set; }
    }
}
