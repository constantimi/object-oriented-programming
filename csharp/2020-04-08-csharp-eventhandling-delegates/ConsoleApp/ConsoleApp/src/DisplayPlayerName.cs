using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.basic
{
    class DisplayPlayerName
    {
        public DisplayPlayerName(){
            
        }

        public delegate int ScoreDelegate(PlayerStats stats);
        public void OnGameOver(PlayerStats[] allPlayerStats)
        {
            string playerNameMostKills = GetPlayerNameTopScore(allPlayerStats, ScoreByKillcount);
            string playerNameMostFlagsCaptured = GetPlayerNameTopScore(allPlayerStats, ScoreByFlagCaptures);

            Console.WriteLine($"Player name with most kills: {playerNameMostKills}");
            Console.WriteLine($"Player name with most flags captured: {playerNameMostFlagsCaptured}");

            // It is possible to change the methods on the ScoreDelegate place with lambda expressions
            // so, you don't need to use ScoreByKillcount and ScoreByFlagCaptures

            string playerNameMostKillsLambda = GetPlayerNameTopScore(allPlayerStats, stats=>stats.Kills);
            string playerNameMostFlagsCapturedLambda = GetPlayerNameTopScore(allPlayerStats, stats=>stats.FlagsCaptured);

        }


        // If the functionality of many methods is almost the same
        // You can consider using delegates
        public int ScoreByKillcount(PlayerStats stats)
        {
            return stats.Kills;
        }
        public int ScoreByFlagCaptures(PlayerStats stats)
        {
            return stats.FlagsCaptured;
        }

        // GetPlayerNameTopScore is the base method for the logic
        public string GetPlayerNameTopScore(PlayerStats[] allPlayerStats, ScoreDelegate scoreCalculator)
        {
            string name = "";
            int bestScore = 0;

            foreach (PlayerStats stats in allPlayerStats)
            {
                int score = scoreCalculator(stats);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stats.Name;
                }
            }

            return name;
        }

        
    }
}
