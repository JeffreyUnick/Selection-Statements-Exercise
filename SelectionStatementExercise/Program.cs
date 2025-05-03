using System.Collections.Specialized;

namespace SelectionStatementExercise;

    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICE 1 : THE GUESS FAVNUMBER PROGRAM
            Console.WriteLine("HEYYYYY WHAT'S UP HOMIE !!!! Welcome to <<GUESS THE NUMBER>> !!!" +
                              ". A game where you need to guess my favorite number\n" +
                              "Let's get started!! What is my favorite number ?\n" +
                              "Little tip it's between 1 and 999. And it's a whole number.");
            PlayGuessingGame();
            Console.WriteLine("Would you like to play again ? Yes/No");
            string answer = Console.ReadLine()?.Trim().ToLower();
            if (answer == "y" || answer == "yes")
            {
                Console.WriteLine("Cool, would you like to increase the difficulty level by chance!? Yes/No ");
                string moreDifficult = Console.ReadLine()?.Trim().ToLower();
                if (moreDifficult == "y" || moreDifficult == "yes")
                {
                    Console.WriteLine("Awesome !!! Now the number you need to guess is between 1 and 1999. Good luck friend !");
                    PlayGuessingGameMax();
                }
                else
                {
                    PlayGuessingGame();
                }
            }
            else
            {
                Console.WriteLine("Thank you for playing! Bye bye.");
            }
            
        }
        static void PlayGuessingGame()
        {
            Random rand = new Random();
            int favoriteNum = rand.Next(1, 1000);
            int proposedNum = 0;
            int attempts = 0;

            while (proposedNum != favoriteNum)
            {
                Console.WriteLine("Enter your guess: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out proposedNum))
                {
                    attempts++;
                    
                    if (1 > proposedNum || proposedNum > 999)
                    {
                        Console.WriteLine("Your number got to be between 1 and 999.");
                    }

                    else if (proposedNum > favoriteNum)
                    {
                        Console.WriteLine("Nope your number is too big !");
                    }
                    else if (favoriteNum > proposedNum)
                    {
                        Console.WriteLine("No the number you entered is lesser than my favorite number.");
                    }
                    else
                    {
                        Console.WriteLine($"CONGRATULATIONS, You guessed it !! {favoriteNum} is my favorite number." +
                                          $"It took you {attempts} attempts to get it right. " +
                                          $"You've earned the rank {GetPlayerRank(attempts)} Good job !!\n ");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

            }
        }
        
        
        static void PlayGuessingGameMax()
        {
            Random rand = new Random();
            int favoriteNum = rand.Next(1, 2000);
            int proposedNum = 0;
            int attempts = 0;

            while (proposedNum != favoriteNum)
            {
                Console.WriteLine("Enter your guess: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out proposedNum))
                {
                    attempts++;
                    if (1 > proposedNum || proposedNum > 1999)
                    {
                        Console.WriteLine("Your number got to be between 1 and 999.");
                    }

                    else if (proposedNum > favoriteNum)
                    {
                        Console.WriteLine("Nope your number is too big !");
                    }
                    else if (favoriteNum > proposedNum)
                    {
                        Console.WriteLine("No the number you entered is lesser than my favorite number.");
                    }
                    else
                    {
                        Console.WriteLine($"CONGRATULATIONS, You guessed it !! {favoriteNum} is my favorite number." +
                                          $"It took you {attempts} attempts to get it right." +
                                          $"You've earned the rank {GetPlayerRank(attempts)} Good job !!\n ");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

            }
            
        }

        static string GetPlayerRank(int attempts)
        {
            if (attempts == 1)
                return "Ultimate Psychic Creature";
            else if (attempts == 2)
                return "God like";
            else if (attempts <= 4)
                return "Legend of the game";
            else if (attempts <= 6)
                return "Pro Player";
            else if (attempts <= 9)
                return "Intermediate";
            else if (attempts <= 13)
                return "Casual Player";
            else if (attempts <= 17)
                return "Beginner";
            else if (attempts <= 21)
                return "Struggler";
            else if (attempts <= 26)
                return "Noob";
            else if (attempts <= 32)
                return "Turtle not Ninja";
            else
                return "Blindfolded Monkey";
        }
    }
