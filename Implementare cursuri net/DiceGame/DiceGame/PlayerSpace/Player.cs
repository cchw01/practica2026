using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.PlayerSpace
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string  Name { get; set; }
        public int Wins { get; set; }

        public Player(string name, int wins=0)
        {
            Name = name;
            Wins = wins;
        }
        public void AddWin()
        {
            Wins++;
        }
    }
}
