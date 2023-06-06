using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> taunts;

        public CreativeSmackTalkingPlayer(List<string> taunts)
        {
            this.taunts = taunts;
        }
        public override void Play(Player other)
        {
            Random random = new Random();

            string selectedTaunt = taunts[random.Next(taunts.Count)];

            Console.WriteLine($"{Name} says: {selectedTaunt}");

            base.Play(other);
        }
    }
}