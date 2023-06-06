using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            // Roll one higher than the other player
            int myRoll = other.Roll() + 1;
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
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
