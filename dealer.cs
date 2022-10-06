using System;
using System.Threading;


namespace Hilo;


public class Dealer
{
//main function


public void playgame() 
{

    bool play_again = true;
    do
    {
        
        Console.WriteLine("The card is: "); // number to be displayed after card class is complete
        Console.WriteLine("Higher or lower? [h/l] ");
        Console.ReadLine();
        Console.WriteLine("Next card was: "); // also needed from card class
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