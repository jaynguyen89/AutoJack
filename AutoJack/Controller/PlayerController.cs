using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;
using AutoJack.Model;

namespace AutoJack.Controller {

    class UserController {

        public void AllowCreateUser() {
            NewUserView NewUserView = new NewUserView();
            NewUserView.Show();
        }

        public void DisplayUserDetails(int Id) {
            Engine Engine = new Engine();
            User User = Engine.GetUserById(Id);

            UserDetailsView UserDetailsView = new UserDetailsView(User);
            UserDetailsView.Show();
        }
    }
}
