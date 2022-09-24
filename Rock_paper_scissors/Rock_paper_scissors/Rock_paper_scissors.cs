using System;

namespace Rock_paper_scissors
{
    class Rock_paper_scissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose[r]ock, [p]aper, [s]cissors: ");
            string playerMove = Console.ReadLine();


            if (playerMove =="r"|| playerMove=="rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p"|| playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove=="s"||playerMove=="scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);

            string computersMove = string.Empty;
            if (computerRandomNumber==1)
            {
                computersMove = Rock;
            }
            else if (computerRandomNumber==2)
            {
                computersMove = Paper;
            }
            else if (computerRandomNumber==3)
            {
                computersMove = Scissors;
            }
            Console.WriteLine($"The computer chose {computersMove}.");
            if ((playerMove == Rock && computersMove == Scissors)||
                (playerMove == Paper && computersMove==Rock) ||
                (playerMove==Scissors&& computersMove==Paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove==Rock && computersMove==Rock)||
                     (playerMove==Paper && computersMove==Paper)||
                     (playerMove==Scissors && computersMove==Scissors))
            {
                Console.WriteLine("Draw");
            }
            else if ((playerMove==Rock && computersMove==Paper)||
                     (playerMove==Paper && computersMove==Scissors)||
                      (playerMove==Scissors && computersMove==Rock))
            {
                Console.WriteLine("You lose.");
                
            }
        }
    }
}
