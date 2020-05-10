using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.basic
{
    class PlayerStats
    {
        private string name;
        private int kills;
        private int deaths;
        private int flagsCaptured;

        public PlayerStats(string name, int kills, int deaths, int flagsCaptured)
        {
            this.name = name;
            this.kills = kills;
            this.deaths = deaths;
            this.flagsCaptured = flagsCaptured;
        }

        public string Name { get => name; set => name = value; }
        public int Kills { get => kills; set => kills = value; }
        public int Deaths { get => deaths; set => deaths = value; }
        public int FlagsCaptured { get => flagsCaptured; set => flagsCaptured = value; }
    
    }
}
