namespace rock___paper___scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool PlayAgain = true;
            String player;
            String computer;
            String answer;

            while (PlayAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine(" Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }
                Console.WriteLine("player: " + player);
                Console.WriteLine("computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a win for the computer! ");
                        }
                        else
                        {
                            Console.WriteLine("It's a win for the human! ");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a win for the computer! ");
                        }
                        else
                        {
                            Console.WriteLine("It's a win for the human! ");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a win for the computer! ");
                        }
                        else
                        {
                            Console.WriteLine("It's a win for the human! ");
                        }
                        break;

                }
                Console.WriteLine("would you like to play again? (Y/N) ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                }
            }
            Console.WriteLine("don't play it again! ");
            Console.ReadKey();
        }
    }
}
