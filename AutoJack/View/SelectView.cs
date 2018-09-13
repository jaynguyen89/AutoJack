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

    public partial class SelectView : Form {
        private Engine Engine = new Engine();
        private List<User> Users;

        public SelectView() {
            InitializeComponent();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 30);
            UsersList.SmallImageList = imgList;

            Users = Engine.GetSavedUsers();
            foreach (User User in Users) {
                ListViewItem ListItem = new ListViewItem(new string[] {
                    User.Id,
                    User.Name,
                    User.Balance.ToString(),
                    User.Winstreak.ToString(),
                    User.WinCount.ToString(),
                    User.LoseCount.ToString(),
                    User.Owing.ToString(),
                    User.LastPlay
                });

                UsersList.Items.Add(ListItem);
            }

            OkButton.Click += new EventHandler(UserSelected);
            NewPButton.Click += new EventHandler(NewUser);
            BackButton.Click += new EventHandler(CancelSelect);
            UserDetails.Click += new EventHandler(ShowUserDetails);
            DeleteUser.Click += new EventHandler(DoDeleteUser);
        }

        private void UserSelected(object sender, EventArgs e) {
            int SelectedId = GetSelectedUser();
            this.Visible = false;

            if (SelectedId > 0) {
                User User = Users.ElementAt(SelectedId - 100 - 1);

                this.Close();
                GameController GameController = new GameController(User);
                GameController.StartGame();
            }
            else
                this.Visible = true;
        }

        private void NewUser(object sender, EventArgs e) {
            this.Close();
            UserController UserController = new UserController();
            UserController.AllowCreateUser();
        }

        private void CancelSelect(object sender, EventArgs e) {
            this.Close();
        }

        private void ShowUserDetails(object sender, EventArgs e) {
            int SelectedId = GetSelectedUser();
            this.Visible = false;

            if (SelectedId > 0) {
                this.Close();

                UserController UserController = new UserController();
                UserController.DisplayUserDetails(SelectedId);
            }
            else
                this.Visible = true;
        }

        private void DoDeleteUser(object sender, EventArgs e) {
            

            int SelectedId = GetSelectedUser();
            if (SelectedId > 0) {
                DialogResult result = MessageBox.Show("This player will be deleted permanently. Continue?", "Delete",
                                      MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.OK)) {
                    this.Close();

                    Engine Engine = new Engine();
                    User User = Engine.GetUserById(SelectedId);

                    Engine.Delete(User);
                    SelectController SelectController = new SelectController();
                    SelectController.AllowSelectUser();
                }
            }
        }

        private int GetSelectedUser() {
            string SelectedId = String.Empty;
            bool success = true;

            try {
                SelectedId = UsersList.SelectedItems[0].SubItems[0].Text;
            } catch (ArgumentOutOfRangeException E) {
                success = false;
            }

            if (success) {
                int.TryParse(SelectedId, out int id);
                return id;
            }

            MessageBox.Show("No User was selected.");
            return -1;
        }
    }
}
