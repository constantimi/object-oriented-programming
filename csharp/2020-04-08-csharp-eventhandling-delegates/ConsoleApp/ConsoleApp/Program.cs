using ConsoleApp.basic;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerStats ps1 = new PlayerStats("peps1", 20, 10, 60);
            PlayerStats ps2 = new PlayerStats("peps2", 50, 60, 20);
            PlayerStats ps3 = new PlayerStats("peps3", 10, 10, 24);
            PlayerStats ps4 = new PlayerStats("peps4", 40, 60, 90);
            PlayerStats ps5 = new PlayerStats("peps5", 30, 10, 80);

            PlayerStats[] playerStats = { ps1, ps2, ps3, ps4, ps5 };

            DisplayPlayerName ds = new DisplayPlayerName();
            ds.OnGameOver(playerStats);
        }
    }
}
