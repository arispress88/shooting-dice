using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int maxRoll = DiceSize * NumDice; // Get the max possible roll for the player

            int lowerBound = maxRoll / 2 + 1; // Calculates the lower bound of the upper half

            return new Random().Next(lowerBound, maxRoll + 1); // Generate a random roll in the upper half
        }
    }
}