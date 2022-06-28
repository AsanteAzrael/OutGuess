using System;

namespace OutGuess
{
    class Program
    {
        static void Main(string[] args)
        {

            Outguess();


        }


        static void Outguess()
        {
            /*
           In  the game the computer chooses a pseudo-random integer between 1 & 100.
          The player is given seven attempts to type in a  guess.
          If the guess is correct the game will display a congratulatory message and then end.
          If not,then the program will prompt the player to enter another guess until no more attempts are left. */       
             

            //needs to tell user to re -enter an answer
             
            Console.WriteLine("Welcome to Outguess!");
            Console.WriteLine("Press any key to begin:");
           Console.ReadKey();

            Console.WriteLine("I've chosen a secret number between 1 & 10. You have 7 attempts to guess it!");

            Random random = new Random();                         //declare varables
            int randomNumber = random.Next(1, 11);
            int userGuess;
            int attempts = 7;
            bool gameOver = false;  
            //bool to confirm if game is won/lost

          
            //begin guessing attempts
            while (gameOver == false) 
            {
                userGuess = Convert.ToInt32(Console.ReadLine()); //user takes guess
                attempts--;                                      // subtract an attempt


                //use of nested loops     AND v                   for game over/ loses
                if (userGuess != randomNumber && attempts == 0)
                {
                    Console.WriteLine("Game Over. Better Luck next time mate.");
                    gameOver = true;
                }
                else if (userGuess == randomNumber)               //if user wins
                {
                    Console.WriteLine("You had a 7% chance of winning. I am truly Impressed");
                }
                else if (userGuess != randomNumber)
                {
                
                }
                       


            }
             
             
             
             
             
        }





    }
}
