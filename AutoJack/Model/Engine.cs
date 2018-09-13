using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using AutoJack.common;

namespace AutoJack.Model {

    class Engine {

        public List<User> GetSavedUsers() {
            List<User> Users = new List<User>();
            using (StreamReader s = new StreamReader(Utility.GetBasePath() + @"resources\saves\users.json")) {
                string json = s.ReadToEnd();
                Users = JsonConvert.DeserializeObject<List<User>>(json);
            }

            return Users;
        }

        public void WriteUsersJSON(List<User> Users) {
            using (StreamWriter s = new StreamWriter(Utility.GetBasePath() + @"resources\saves\users.json")) {
                JsonSerializer Serializer = new JsonSerializer();

                Serializer.Serialize(s, Users);
            }
        }

        public User GetUserById(int Id) {
            List<User> Users = GetSavedUsers();

            foreach (User User in Users)
                if (User.Id == Id.ToString())
                    return User;

            return null;
        }

        public void Update(User User) {
            List<User> Users = GetSavedUsers();

            for (var i = 0; i < Users.Count; i++)
                if (Users[i].Id == User.Id) {
                    Users[i] = User;
                    break;
                }

            WriteUsersJSON(Users);
        }

        public void Delete(User User) {
            List<User> Users = GetSavedUsers();

            for (var i = 0; i < Users.Count; i++)
                if (Users[i].Id == User.Id) {
                    Users.RemoveAt(i);
                    break;
                }

            WriteUsersJSON(Users);
        }
    }
}
