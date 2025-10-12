//Author: Sifa Zhang
//Studeng ID: 1606796
//Date: 2025/10/13

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
        /// <summary>
        /// properties
        /// </summary>
        public string Name { get; set; }
        public int Score { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public ScoreEntry(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    /// <summary>
    /// public data class
    /// </summary>
    internal static class PublicDatas
    {
        public static int maxLevel = 5;
        public static int currentLevel = 1;
        public static string currentUserName = "";
        public static int currentScore = 0;
        public static Ranking ranking = new Ranking();

        public static List<ScoreEntry> topUsers = new List<ScoreEntry>();
        public static string filePath = Application.StartupPath + "\\topUsers.csv";
        public static int topUsersCount = 10;

        /// <summary>
        /// add a level
        /// </summary>
        public static void AddLevel()
        {
            if (currentLevel < maxLevel)
            {
                currentLevel++;
            }
        }

        /// <summary>
        /// load top users from file
        /// </summary>
        public static void LoadTopUsersFromFile()
        {
            try
            {
                if (topUsers.Count == 0)
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
            catch (IOException ioEx)
            {
                MessageBox.Show($"File error: {ioEx.Message}", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// update scores and save to file if needed
        /// </summary>
        public static void UpdateScores()
        {
            try
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

                if (saveNeeded)
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
            catch (IOException ioEx)
            {
                MessageBox.Show($"File error: {ioEx.Message}", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException rangeEx)
            {
                MessageBox.Show($"Indexing error: {rangeEx.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// get my top score and ranking
        /// </summary>
        /// <param name="ranking"></param>
        /// <returns></returns>
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
