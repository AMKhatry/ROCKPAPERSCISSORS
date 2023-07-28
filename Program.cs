
namespace ROCKPAPERSCISSORS
{
    class Programm
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;


            bool playAgain = true;
            
            while(playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose between ROCK, PAPER and SCISSORS:  ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);


                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK.");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!!\n\n");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Player LOSES!!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER.");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player LOSES!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("DRAW!!\n\n");

                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                scorePlayer++;

                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS.");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player LOSES!!\n\n");
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            break;
                    }

                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player WON!");
                    }

                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("CPU WON!");
                    }

                    else
                    {

                    }
                }
            }      

            Console.WriteLine("Do you want to play again? (y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playAgain = true;
                Console.Clear();
            }
            else if (loop == "n")
            {
                playAgain = false;
            }
            else
            {
                
            }
        }
    }
}