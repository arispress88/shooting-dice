using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            // Smack Talking player
            SmackTalkingPlayer smackTalkingPlayer = new SmackTalkingPlayer("I'm the best! You can't beat me!");
            smackTalkingPlayer.Name = "Charles";

            smackTalkingPlayer.Play(smackTalkingPlayer);

            Console.WriteLine("-------------------");

            //One higher player
            OneHigherPlayer oneHigherPlayer = new OneHigherPlayer();
            oneHigherPlayer.Name = "High Roller";

            oneHigherPlayer.Play(player1);

            Console.WriteLine("-------------------");

            // Creative smack talker
            List<string> taunts = new List<string>()
            {
                "You're mid at dice!",
                "I'm the champ!",
                "You can't see me!",
                "You never stood a chance!"
            };

            CreativeSmackTalkingPlayer creativePlayer = new CreativeSmackTalkingPlayer(taunts);
            creativePlayer.Name = "Hatey McHater";

            creativePlayer.Play(player1);

            Console.WriteLine("-------------------");

            
            // Human player
            HumanPlayer humanPlayer = new HumanPlayer();
            humanPlayer.Name = "You";

            humanPlayer.Play(player1);

            Console.WriteLine("-------------------");

            //Sore loser
            SoreLoserPlayer soreLoserPlayer = new SoreLoserPlayer();
            soreLoserPlayer.Name = "Salty Bro";

            try
            {
                soreLoserPlayer.Play(player1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------");

            UpperHalfPlayer upperHalfPlayer = new UpperHalfPlayer();
            upperHalfPlayer.Name = "Uppity Dude";

            upperHalfPlayer.Play(player1);

            Console.WriteLine("-------------------");

            //Sore loser upper half player
            SoreLoserUpperHalfPlayer soreLoserUpperHalfPlayer = new SoreLoserUpperHalfPlayer();
            soreLoserUpperHalfPlayer.Name = "Mr. Big Mad";

            try
            {
                soreLoserUpperHalfPlayer.Play(player1);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            

            Console.WriteLine("-------------------");



            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackTalkingPlayer, oneHigherPlayer, creativePlayer, humanPlayer, soreLoserPlayer, upperHalfPlayer, soreLoserUpperHalfPlayer
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}