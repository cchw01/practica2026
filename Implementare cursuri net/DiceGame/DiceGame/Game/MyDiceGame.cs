using DiceGame.PlayerSpace;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.Game
{
    public class MyDiceGame : IGame
    {
        public List<Player> PlayerList { get; set; }
        const int numberOfDices = 2;
        private readonly List<Dice> diceList;
        readonly Dictionary<Player, int> results;

        public MyDiceGame(List<Player> players)
        {
            this.PlayerList = players;
            results = new Dictionary<Player, int>();
            foreach (Player player in players)
            {
                results.Add(player, 0);
            }
            diceList = new List<Dice>();
            for (int i = 0; i < numberOfDices; i++)
            {
                diceList.Add(new Dice(6));
            }
        }


        public Player PlayGame()
        {
            int maxValue = 0;
            while (results.Count(x => x.Value == maxValue) > 1)
            {
                foreach (Player player in PlayerList)
                {
                    int sum = 0;
                    foreach (Dice dice in diceList)
                    {
                        int rolled = dice.RollTheDice();
                        Console.WriteLine(
                        "Player {0} rolled a {1}",
                        player.Name, rolled);
                        sum += rolled;
                    }
                    Console.WriteLine(
                        "Player {0} rolled a total of {1}",
                        player.Name, sum);
                    results[player] = sum;
                }
                maxValue = results.Max(x => x.Value);
            }
            return results.SingleOrDefault(x => x.Value == maxValue).Key;
        }
    }
}
