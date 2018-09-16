using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.Controller;

namespace AutoJack.common {
    public partial class SelectHand : Form {
        GameController GameController;

        public SelectHand(GameController GameController) {
            InitializeComponent();

            this.GameController = GameController;
            LeftHandPhoto.Click += new EventHandler(LeftPhotoClickEvent);
            RiteHandPhoto.Click += new EventHandler(RightPhotoClickEvent);

            OkButton.Click += new EventHandler(OkButtonClicked);
            CancelButton.Click += new EventHandler(CancelBtnClicked);
        }

        private void LeftPhotoClickEvent(object sender, EventArgs e) {
            LeftRadio.Checked = true;
        }

        private void RightPhotoClickEvent(object sender, EventArgs e) {
            RightRadio.Checked = true;
        }

        private void OkButtonClicked(object sender, EventArgs e) {
            if (LeftRadio.Checked)
                GameController.Callback.DrawToSelectedHand("Hand1", GameController);

            if (RightRadio.Checked)
                GameController.Callback.DrawToSelectedHand("Hand2", GameController);

            this.Close();
        }

        private void CancelBtnClicked(object sender, EventArgs e) {
            this.Close();
        }
    }
}
