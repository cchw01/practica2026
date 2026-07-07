using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.Game
{
    public class Dice
    {
        private readonly int nbOfFaces;
        public Dice(int nbOfFaces)
        {
            this.nbOfFaces = nbOfFaces;
        }

        public int RollTheDice()
        {
            Random random = new Random();
            return random.Next(1, nbOfFaces + 1);
        }
    }
}
