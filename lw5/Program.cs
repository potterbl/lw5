using System;
using System.Collections.Generic;

namespace lw5
{
    interface ILab8DictionaryPart
    {
        Dictionary<string, TeamResult> Stats { get; }
        void AddGame(string firstTeamName, int firstTeamGoals, string secondTeamName, int secondTeamGoals);
    }

    class TeamResult
    {
        public int NumberOfGames { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }
        public int SumOfPoints { get; set; }
    }

    class FootballStats : ILab8DictionaryPart
    {
        private Dictionary<string, TeamResult> stats = new Dictionary<string, TeamResult>();

        public Dictionary<string, TeamResult> Stats
        {
            get { return stats; }
        }

        public void AddGame(string firstTeamName, int firstTeamGoals, string secondTeamName, int secondTeamGoals)
        {
            if (!stats.ContainsKey(firstTeamName))
            {
                stats[firstTeamName] = new TeamResult();
            }
            if (!stats.ContainsKey(secondTeamName))
            {
                stats[secondTeamName] = new TeamResult();
            }

            TeamResult firstTeamResult = stats[firstTeamName];
            TeamResult secondTeamResult = stats[secondTeamName];

            firstTeamResult.NumberOfGames++;
            secondTeamResult.NumberOfGames++;

            if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamResult.Wins++;
                firstTeamResult.SumOfPoints += 3;
                secondTeamResult.Loses++;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                secondTeamResult.Wins++;
                secondTeamResult.SumOfPoints += 3;
                firstTeamResult.Loses++;
            }
            else
            {
                firstTeamResult.Draws++;
                secondTeamResult.Draws++;
                firstTeamResult.SumOfPoints++;
                secondTeamResult.SumOfPoints++;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILab8DictionaryPart footballStats = new FootballStats();

            while (true)
            {
                Console.WriteLine("Оберіть опцію:");
                Console.WriteLine("1. Додати результат гри");
                Console.WriteLine("2. Вивести статистику команд");
                Console.WriteLine("3. Вийти");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Назва першої команди: ");
                        string firstTeamName = Console.ReadLine();
                        Console.Write("Голі першої команди: ");
                        int firstTeamGoals = int.Parse(Console.ReadLine());
                        Console.Write("Назва другої команди: ");
                        string secondTeamName = Console.ReadLine();
                        Console.Write("Голі другої команди: ");
                        int secondTeamGoals = int.Parse(Console.ReadLine());

                        footballStats.AddGame(firstTeamName, firstTeamGoals, secondTeamName, secondTeamGoals);
                        break;

                    case "2":
                        Console.WriteLine("Статистика команд:");
                        foreach (var team in footballStats.Stats)
                        {
                            Console.WriteLine($"{team.Key}: Усього ігор {team.Value.NumberOfGames}, Перемог {team.Value.Wins}, " +
                                              $"Нічиїх {team.Value.Draws}, Поразок {team.Value.Loses}, Всього очків {team.Value.SumOfPoints}");
                        }
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}