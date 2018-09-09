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
            GetJsonPath();
            List<Player> Players = new List<Player>();
            using (StreamReader s = new StreamReader(GetJsonPath())) {
                string json = s.ReadToEnd();
                Players = JsonConvert.DeserializeObject<List<Player>>(json);
            }

            return Players;
        }

        public void WritePlayersJSON(List<Player> Players) {
            using (StreamWriter s = new StreamWriter(GetJsonPath())) {
                JsonSerializer Serializer = new JsonSerializer();

                Serializer.Serialize(s, Players);
            }
        }

        public Player GetPlayerById(int Id) {
            List<Player> Players = GetSavedPlayers();

            foreach (Player player in Players)
                if (player.Id == Id.ToString())
                    return player;

            return null;
        }

        public void Update(Player Player) {
            List<Player> Players = GetSavedPlayers();

            for (var i = 0; i < Players.Count; i++)
                if (Players[i].Id == Player.Id) {
                    Players[i] = Player;
                    break;
                }

            WritePlayersJSON(Players);
        }

        public void Delete(Player Player) {
            List<Player> Players = GetSavedPlayers();

            for (var i = 0; i < Players.Count; i++)
                if (Players[i].Id == Player.Id) {
                    Players.RemoveAt(i);
                    break;
                }

            WritePlayersJSON(Players);
        }

        private string GetJsonPath() {
            string CurrentPath = Directory.GetCurrentDirectory();

            string[] tokens = CurrentPath.Split('\\');
            string AppFolder = String.Empty;
            for (int i = 0; i < tokens.Length - 2; i++)
                AppFolder += tokens[i] + @"\";

            return AppFolder + @"resources\saves\players.json";
        }
    }
}
