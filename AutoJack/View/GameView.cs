﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.Model;

namespace AutoJack.View {

    public partial class GameView : Form {
        public Player Player { get; set; }

        public GameView() {
            InitializeComponent();
        }
    }
}
