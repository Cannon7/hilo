using System;
using System.Threading;


namespace hilo;

public class Dealer
{
//main function


public void play_game(int number)
{

    bool play_again = true;
    do
    {
        int score;
        score = 300;
        Console.WriteLine("The card is: " + number); // number to be displayed after card class is complete
        Console.WriteLine("Higher or lower? [h/l] ");
        Console.ReadLine();
        Console.WriteLine("Next card was: "); // also needed from card class
        if (score <= 0)
        {
            break;
        }
        Console.WriteLine("Your score is: "); // enter from score function
        Console.WriteLine("Play again? [y/n] ");     
        string continue_game = Console.ReadLine();
            if (continue_game == "y")
            {
                play_again = true;
            }
            else if (continue_game == "n")
            {
                play_again = false;
            }
                   
    } while (play_again == true);
    
    
}

}