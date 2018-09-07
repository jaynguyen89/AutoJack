using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace AutoJack.Model {

    class Engine {

        public List<Player> GetSavedPlayers() {
            List<Player> Players = new List<Player>();
            using (StreamReader s = new StreamReader(@"D:\MyProjects\AutoJack\AutoJack\resources\saves\players.json")) {
                string json = s.ReadToEnd();
                Players = JsonConvert.DeserializeObject<List<Player>>(json);
            }

            return Players;
        }

        public void WritePlayersJSON(List<Player> Players) {
            using (StreamWriter s = new StreamWriter(@"D:\MyProjects\AutoJack\AutoJack\resources\saves\players.json")) {
                JsonSerializer Serializer = new JsonSerializer();

                Serializer.Serialize(s, Players);
            }
        }

        private string GetJsonPath() {
            string path = String.Empty;

            return path;
        }
    }
}
