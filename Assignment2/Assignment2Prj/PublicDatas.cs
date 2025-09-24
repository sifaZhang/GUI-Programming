using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    public class ScoreEntry
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public ScoreEntry(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    internal static class PublicDatas
    {
        public static string currentUserName = "";
        public static int currentScore = 0;
        public static Ranking ranking = new Ranking();

        public static List<ScoreEntry> topUsers = new List<ScoreEntry>();
        public static string filePath = Application.StartupPath + "\\topUsers.csv";
        public static int topUsersCount = 10;

        public static void LoadTopUsersFromFile()
        {
            if(topUsers.Count == 0)
            {
                if (System.IO.File.Exists(filePath))
                {
                    var lines = System.IO.File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                        {
                            topUsers.Add(new ScoreEntry(parts[0], score));
                        }
                    }
                }

                // Sort and keep only top 5
                topUsers = topUsers.OrderByDescending(entry => entry.Score).Take(topUsersCount).ToList();
            }
        }

        public static void UpdateScores()
        {
            bool saveNeeded = true;
            if (topUsers.Count >= topUsersCount)
            {
                ScoreEntry scoreEntry = topUsers[topUsersCount - 1];

                if (currentScore <= scoreEntry.Score)
                {
                    saveNeeded = false;
                }
            }
            
            if(saveNeeded)
            {
                topUsers.Add(new ScoreEntry(currentUserName, currentScore));
                topUsers = topUsers.OrderByDescending(entry => entry.Score).Take(topUsersCount).ToList();

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var entry in topUsers)
                    {
                        writer.WriteLine($"{entry.Name},{entry.Score}");
                    }
                }
            }
        }

        public static int GetMyTopScore(out int ranking)
        {
            ranking = -1;
            if (currentUserName != "")
            {
                for (int i = 0; i < topUsers.Count; i++)
                {
                    if (topUsers[i].Name == currentUserName)
                    {                         
                        ranking = i + 1;
                        return topUsers[i].Score;
                    }
                }
            }

            return -1;
        }
    }
}
