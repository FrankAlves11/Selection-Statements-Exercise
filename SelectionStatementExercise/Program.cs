using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite number between 1 and 11?");
            var userInput = int.Parse(Console.ReadLine());
            int favoriteNumber = 11;

            if (favoriteNumber < userInput)
            {
                Console.WriteLine("Your guess was too high!");
            }

            else if (favoriteNumber > userInput)
            {
                Console.WriteLine("Your number was too low!");
            }

            else
            {
                Console.WriteLine("Congratulations you are victorious!");
            }



        }
    }
}    
