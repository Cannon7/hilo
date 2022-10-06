using System;
using System.Threading;


namespace Hilo;


public class Dealer
{
//main function


public void playgame() 
{
    Card getcard = new Card();
    bool play_again = true;
    do
    {
        int returned_num = getcard.draw_card();
        
        Console.WriteLine("The card is: " + returned_num); // number to be displayed after card class is complete
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