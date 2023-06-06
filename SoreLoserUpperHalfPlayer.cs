using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Get the maximum possible roll
            int maxRoll = DiceSize * NumDice;

            // Calculate the lower bound of the upper half
            int lowerBound = maxRoll / 2 + 1;

            // Generate a random roll in the upper range
            return new Random().Next(lowerBound, maxRoll + 1);
        }

        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} wins!");
            }
            else if (myRoll < otherRoll)
            {
                throw new Exception($"{Name} is a sore loser and throws an exception!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}