using System;
using System.Numerics;

namespace Game10003
{
    class Score
    {
        int currentScore;


        public void Setup()
        {
            ResetScore();
        }
        //Reducing the player's score
        public void ReduceScore()
        {
            currentScore -= 1;
            Console.WriteLine(currentScore);
        }

        //Increasing the player's score
        public void IncreaseScore()
        {
            currentScore += 1;
            Console.WriteLine(currentScore);
        }
        //resetting the player's score
        void ResetScore()
        {
            currentScore = 0;
        }
    }
}
