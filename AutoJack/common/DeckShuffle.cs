using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoJack.common {

    public partial class DeckShuffle : Form {

        public DeckShuffle() {
            InitializeComponent();

            OkButton.Click += new EventHandler(CloseWindow);
        }

        private void CloseWindow(object sender, EventArgs e) {
            this.Close();
        }
    }
}
