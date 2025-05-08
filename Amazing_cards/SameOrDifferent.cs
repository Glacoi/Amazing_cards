using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazing_cards
{
    public class SameOrDifferent : Game
    {
        public SameOrDifferent() : base()
        {
            string[] twoSuits = { "Hearts", "Spades" };
            deck = new Deck(twoSuits);
        }

        public override void StartGame()
        {
            deck.Shuffle();

            Console.WriteLine(@"
 ___________________     
|                   |    
|        A          |    
|                   |    
|___________________|    
");
            Console.WriteLine("Same or Different?");
            PlayRound();
        }

        public override void PlayRound()
        {
            int totalRounds = 10;
            Console.WriteLine("Drawing the first card...");
            Card previousCard = deck.DrawCard();
            if (previousCard == null)
            {
                Console.WriteLine("Deck is empty!");
                EndGame();
                return;
            }
            Console.WriteLine($"The card is: {previousCard.GetSuit()}");

            for (int round = 1; round <= totalRounds; round++)
            {
                if (!deck.HasMoreCards())
                {
                    Console.WriteLine("Deck is empty before completing all rounds!");
                    break;
                }
                Console.Write($"Round {round}/{totalRounds} - Will the next card be the same suit or different? (Enter 'same' or 'different'): ");
                string guess = Console.ReadLine().Trim().ToLower();

                Card currentCard = deck.DrawCard();
                if (currentCard == null)
                    break;

                Console.WriteLine($"The next card is: {currentCard.GetSuit()}");
                bool isSame = previousCard.GetSuit() == currentCard.GetSuit();
                if ((guess == "same" && isSame) || (guess == "different" && !isSame))
                {
                    Console.WriteLine("Correct guess!");
                    player.IncrementScore();
                }
                else
                {
                    Console.WriteLine("Wrong guess!");
                }
                previousCard = currentCard;
            }
            EndGame();
        }

        public override void EndGame()
        {
            int finalScore = player.GetScore();
            Console.WriteLine("Final Score: " + finalScore);

            int threshold = 10;
            if (finalScore >= threshold)
            {
                Console.WriteLine("Congratulations! You've won Same or Different!");
            }
            else
            {
                Console.WriteLine("Better luck next time in Same or Different.");
            }
            Console.WriteLine("Thank you for playing Same or Different!");
        }
    }
}
