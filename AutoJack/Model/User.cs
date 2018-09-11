using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Model {

    public class User {

        public User() { }

        public User(string id, string UserName) {
            Id = id;
            Name = UserName;
            Balance = Winstreak = WinCount = LoseCount = Owing = 0;
        }

        public User(
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
            ) {
                Id = id;
                Name = UserName;
                this.Balance = Balance;
                this.Winstreak = WinStreak;
                this.WinCount = WinCount;
                this.LoseCount = LoseCount;
                this.Games = Games;
                this.Owing = Owing;
                AverageBet = AvgBet;
                this.MaxBet = MaxBet;
                this.MinBet = MinBet;
                this.LastPlay = LastPlay;
                this.CurrentStreak = CurrentStreak;
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
