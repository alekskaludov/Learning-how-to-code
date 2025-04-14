namespace csapp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool playagain = true;
            while (playagain)
            {
                int secretnumber = rand.Next(1,101);
                int guess;
                int attempts = 0;
                Console.WriteLine("Guess the number between 1 and 100");
                do
                {
                    Console.WriteLine("Enter your guess");
                    bool isNumber = int.TryParse(Console.ReadLine(), out guess);

                    if (!isNumber)
                    {
                        Console.WriteLine("Wrong answer. Please enter again");
                        continue;
                    }
                    attempts++;
                    if (guess > secretnumber)
                    {
                        Console.WriteLine("The correct number is smaller ");
                    }
                    else if (guess < secretnumber)
                    {
                        Console.WriteLine("The correct number is larger");
                    }
                    else 
                    {
                        Console.WriteLine($"Congrats! You guessed the correct number in {attempts} attempts");
                    }
                } while (guess != secretnumber);
                Console.WriteLine("Do you want to play again? (yes/no)");
                string response = Console.ReadLine().ToLower();
                playagain = response == "yes";
                Console.Clear();
            }
            Console.WriteLine("Thank you for playing");
        }
    }
}
