using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        List <string> listOfTaunts = new List<string>
        {
        "Hey you suck",
        "Just do better",
        "better luck new time",
        "waste of my time"
        };
        
        public override int Roll()
        {
               Random rnd = new Random();
        int randomNum = rnd.Next(0,4);
            Console.WriteLine(listOfTaunts[randomNum]);

            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

          public override void Play(Player other )
        {
         

            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }


        

    }
}