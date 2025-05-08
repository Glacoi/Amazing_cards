/*
* Amazing_cards
* Trent Hitchcock
* 3/17/25
* credit: help from my brother Tyler
*/
namespace Amazing_cards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Amazing Card Games!");
            Console.WriteLine(@"
     *****     *****
   **     ** **     **
  **        *        **
  **                 **
   **               **
     **           **
       **       **
         **   **
           **
");

            Console.WriteLine("Choose a game to play:");
            Console.WriteLine("1. Same or Different?");
            Console.WriteLine("2. Higher or Lower?");
            Console.WriteLine("3. Highest Match");
            Console.WriteLine("Enter your choice (1-3): ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SameOrDifferent sameOrDifferent = new SameOrDifferent();
                    sameOrDifferent.StartGame();
                    break;
                case 2:
                    HigherOrLower higherOrLower = new HigherOrLower();
                    higherOrLower.StartGame();
                    break;
                case 3:
                    HighestMatchGame highestMatchGame = new HighestMatchGame();
                    highestMatchGame.StartGame();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting...");
                    break;
            }
        }
    }
}
