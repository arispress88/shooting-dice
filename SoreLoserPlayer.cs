using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            // Determines the winner
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} wins!");
                throw new Exception($"{Name} is a sore loser!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}