namespace RockPaperScissors;
using System;
class Program
{
    
    public static string PlayGame()
    {
        Console.WriteLine("----------");
        int playerChoice = 0;
        string playerDescription = "";
        string computerDescription = "";
        Random random = new Random();

        Console.WriteLine("Choose your weapon:");
        Console.WriteLine("1 - Rock");
        Console.WriteLine("2 - Paper");
        Console.WriteLine("3 - Scissors");

        playerChoice = int.Parse(Console.ReadLine());

        switch(playerChoice){
            case 1:
            playerDescription = "Rock";
            break;
            case 2: 
            playerDescription = "Paper";
            break;
            case 3:
            playerDescription = "Scissors";
            break;
        }
        
        int computerChoice = random.Next(1, 4);
        switch(computerChoice){
            case 1:
            computerDescription = "Rock";
            break;
            
            case 2:
            computerDescription = "Paper";
            break;

            case 3:
            computerDescription = "Scissors";
            break;
        }
        Console.WriteLine("----------");
        Console.WriteLine(playerDescription + " Vs. " + computerDescription);
        
        if(playerChoice == 1 && computerChoice == 2){
            Console.WriteLine("You Lose.");
            return "Lose";
        }
        else if(playerChoice == 1 && computerChoice == 3){
            Console.WriteLine("You Win!");
            return "Win";
        }
        else if(playerChoice == 2 && computerChoice == 1){
            Console.WriteLine("You win!");
            return "Win";
        }
        else if(playerChoice == 2 && computerChoice == 3){
            Console.WriteLine("You Lose.");
            return "Lose";
        }
        else if(playerChoice == 3 && computerChoice == 1){
            Console.WriteLine("You Lose.");
            return "Lose";
        }
        else if(playerChoice == 3 && computerChoice == 2){
            Console.WriteLine("You Win!");
            return "Win";
        }
        else{
            Console.WriteLine("Tie.");
            return "Tie";
        }

    }

    

    public static void PrintStats(List<string> x){
        int wins = 0;
        int losses = 0;
        int ties = 0;

        for(int i = 0; i < x.Count; i++){
            if(x[i] == "Win"){
                wins += 1;
            }
            else if(x[i] == "Lose"){
                losses += 1;
            }
            else if(x[i] == "Tie"){
                ties += 1;
            }
        }


        Console.WriteLine("You have:");
        Console.WriteLine(wins + " wins");
        Console.WriteLine(losses + " losses");
        Console.WriteLine(ties + " ties");
    }
    
    static void Main(string[] args)
    {
        bool isPlaying = true;
        List<string> Results = new List<string> {};

        Console.WriteLine("Welcome to Rock Paper Scissors!\nWhat do you want to do?\n");        

        while(isPlaying){

            Console.WriteLine("----------");
            Console.WriteLine("1 - Play\n2 - See wins, ties and losses\n3 - Quit");

            string menuOption = Console.ReadLine();

            switch(menuOption){
            case "1": // Play                
                Console.WriteLine("Let's play Rock Paper Scissors!");
                string result = PlayGame();
                Results.Add(result);
                break;

            case "2": // print scores
                PrintStats(Results);
                break;

            case "3": // Quit
                isPlaying = false;
                break;

            default:
                Console.WriteLine("I don't understand. Enter 1, 2, or 3.");
                break;
            }
            

        }     
        
        
    }
}
