using System;

namespace NumberGuessingGame
{
   class Program
   {
      static void Main(string[] args)
      {

         Console.WriteLine("WELCOME TO CALEB NUMBER GUESSING GAME");

         //THIS IS A BRIEF INTRO TO THE GAME INSTRUCTIONS
         Console.WriteLine("There are 3 levels to this game : EASY, MEDIUM, HARD");
         Console.WriteLine("At level EASY you get a chance to guess the number between 1 - 10, with a trial of 6 guesses");
         Console.WriteLine("At level MEDIUM you get a chance to guess the number between 1 - 20, with a trial of 4 guesses");
         Console.WriteLine("At level HARD you get a chance to guess the number between 1 - 50, with a trial of 3 guesses");
         Console.WriteLine("To select level EASY: Enter 1");
         Console.WriteLine("To select level MEDIUM: Enter 2");
         Console.WriteLine("To select level HARD: Enter 3");

         Console.Write("Please select a level: ");
         String levelNumber = Console.ReadLine();
         int easy = 1;
         int medium = 2;
         int hard = 3;


         if (int.Parse(levelNumber) == easy)
         {

            Console.WriteLine("WELCOME TO LEVEL EASY!!!");
            Console.WriteLine("I'm thinking of a number between 1 and 10. What is it? ");

            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int easyGuess;
            int easyNumberOfGuesses = 6;
            bool easyGameover = false;
            int easyCount;

            //LOOP FOR EASY LEVEL
            while (easyGameover == false)
            {

               easyGuess = Convert.ToInt32(Console.ReadLine());
               easyCount = easyNumberOfGuesses-- - 1;

               if (easyGuess != randomNumber && easyNumberOfGuesses == 0)
               {

                  Console.WriteLine("GAME OVER!!!");
                  easyGameover = true;

               }
               else if (easyGuess == randomNumber)
               {

                  Console.WriteLine("YOU GOT IT RIGHT!!!");
                  easyGameover = true;

               }
               else if (easyGuess != randomNumber)
               {

                  Console.WriteLine("That was wrong!!!");
                  Console.WriteLine("You have " + easyCount + " guesses left");

               }

            }

            Console.ReadLine();

         }
         else if (int.Parse(levelNumber) == medium)
         {

            Console.WriteLine("WELCOME TO LEVEL MEDIUM!!!");
            Console.WriteLine("I'm thinking of a number between 1 and 20. What is it? ");

            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            int mediumGuess;
            int mediumNumberOfGuesses = 4;
            bool mediumGameover = false;
            int mediumCount;

            //LOOP FOR MEDIUM LEVEL
            while (mediumGameover == false)
            {

               mediumGuess = Convert.ToInt32(Console.ReadLine());
               mediumCount = mediumNumberOfGuesses-- - 1;

               if (mediumGuess != randomNumber && mediumNumberOfGuesses == 0)
               {

                  Console.WriteLine("GAME OVER!!!");
                  mediumGameover = true;

               }
               else if (mediumGuess == randomNumber)
               {

                  Console.WriteLine("YOU GOT IT RIGHT!!!");
                  mediumGameover = true;

               }
               else if (mediumGuess != randomNumber)
               {

                  Console.WriteLine("That was wrong!!!");
                  Console.WriteLine("You have " + mediumCount-- + " guesses left");

               }

            }

            Console.ReadLine();


         }
         else if (int.Parse(levelNumber) == hard)
         {

            Console.WriteLine("WELCOME TO LEVEL HARD!!!");
            Console.WriteLine("I'm thinking of a number between 1 and 50. What is it? ");

            Random random = new Random();
            int randomNumber = random.Next(1, 51);
            int hardGuess;
            int hardNumberOfGuesses = 3;
            bool hardGameover = false;
            int hardCount;

            //LOOP FOR HARD LEVEL
            while (hardGameover == false)
            {

               hardGuess = Convert.ToInt32(Console.ReadLine());
               hardCount = hardNumberOfGuesses-- - 1;

               if (hardGuess != randomNumber && hardNumberOfGuesses == 0)
               {

                  Console.WriteLine("GAME OVER!!!");
                  hardGameover = true;

               }
               else if (hardGuess == randomNumber)
               {

                  Console.WriteLine("YOU GOT IT RIGHT!!!");
                  hardGameover = true;

               }
               else if (hardGuess != randomNumber)
               {

                  Console.WriteLine("That was wrong!!!");
                  Console.WriteLine("You have " + hardCount + " guesses left");

               }

            }

            Console.ReadLine();

         }
         else
         {

            //THIS IS A BRIEF INTRO TO THE GAME INSTRUCTIONS
            Console.WriteLine("There are 3 levels to this game : EASY, MEDIUM, HARD");
            Console.WriteLine("At level EASY you get a chance to guess the number between 1 - 10, with a trial of 6 guesses");
            Console.WriteLine("At level MEDIUM you get a chance to guess the number between 1 - 20, with a trial of 4 guesses");
            Console.WriteLine("At level HARD you get a chance to guess the number between 1 - 50, with a trial of 3 guesses");
            Console.WriteLine("To select level EASY: Enter 1");
            Console.WriteLine("To select level MEDIUM: Enter 2");
            Console.WriteLine("To select level HARD: Enter 3");

         }




      }
   }
}
