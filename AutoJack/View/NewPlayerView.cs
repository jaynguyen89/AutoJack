using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.Model;
using AutoJack.Controller;

namespace AutoJack.View {

    public partial class NewUserView : Form {
        private Engine Engine = new Engine();

        public NewUserView() {
            InitializeComponent();

            OkButton.Click += new EventHandler(CreateNewUser);
            BackButton.Click += new EventHandler(CancelCreate);
            NameInput.KeyPress += new KeyPressEventHandler(EnterKeyPressed);
        }

        private void CreateNewUser(object sender, EventArgs e) {
            String UserName = NameInput.Text;

            if ("Your Name...".Contains(UserName))
                MessageBox.Show("Please enter your name to continue.");
            else {
                List<User> Users = Engine.GetSavedUsers();
                int.TryParse(Users.ElementAt(Users.Count - 1).Id, out int id);

                User NewUser = new User(
                        (id + 1).ToString(),
                        UserName
                    );

                Users.Add(NewUser);
                Engine.WriteUsersJSON(Users);

                this.Close();
                GameController GameController = new GameController(NewUser);
                GameController.StartGame();
            }
        }

        private void EnterKeyPressed(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                OkButton.PerformClick();
            }
        }

        private void CancelCreate(object sender, EventArgs e) {
            this.Close();
            SelectController SelectController = new SelectController();
            SelectController.AllowSelectUser();
        }
    }
}
