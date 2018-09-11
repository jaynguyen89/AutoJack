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
using AutoJack.Model;

namespace AutoJack.View {
    public partial class EngineView : Form {

        public EngineView() {
            InitializeComponent();

            SelectUser.Click += new EventHandler(SelectUserEvent);
            ExitButton.Click += new EventHandler(QuitApp);
        }

        private void SelectUserEvent(object sender, System.EventArgs e) {
            EngineController EngineController = new EngineController();
            EngineController.GetSavedUsers();
        }

        private void QuitApp(object sender, System.EventArgs e) {
            this.Close();
        }
    }
}
