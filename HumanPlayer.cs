using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.WriteLine($"{Name}, enter your roll: ");
            int myRoll = Convert.ToInt32(Console.ReadLine());

            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} roll a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            // Determines the winner
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} win!");
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