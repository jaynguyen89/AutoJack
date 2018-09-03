﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoJack.Model {

    class Player {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Winstreak { get; set; }
        public int WinCount { get; set; }
        public int LoseCount { get; set; }
        public int GameCount { get; set; }
        public int Owing { get; set; }
    }
}