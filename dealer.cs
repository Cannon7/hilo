using System;
using System.Threading;


namespace Hilo;

public class Dealer
{
//main function


public void playgame()
{
    Points answer_points = new Points(); //brings card class from Points.cs
    Card getcard = new Card(); // Brings in Card class from cards.cs
    bool play_again = true;
    do
    {
        int player_card = getcard.draw_card();
        int vs_card = getcard.draw_card();
        int score = 300;
        
        Console.WriteLine("The card is: " + player_card); // number to be displayed after card class is complete
        Console.WriteLine("Higher or lower? [h/l] ");
        string guess = Console.ReadLine();
        string answer = ""; // Currently will be used in line ~ 53 (which is commented out)
        
        // <summary>
        // The following if statements will take the guess from the player and determine if their guess is 
        // right or wrong. It will then assign it the string "right" or "wrong" to then be put through the 
        // points file.
        //</summary>
        
        if (guess == "h") { 
            if (player_card > vs_card) 
            { answer = "right";}
            else 
            { answer = "wrong";} 
        }
        
        else if (guess == "l") {
            if (player_card < vs_card)
             { answer = "right";}
            else 
            {answer = "wrong";}
        }
        else {
            Console.WriteLine("Sorry that input was not recognized. Please die slowly :)");
        }


        
        // Points.answer_points(score, answer); 
        Console.WriteLine("Next card was: "); // also needed from card class
        if (score <= 0)
        {
            break;
        }
        Console.WriteLine("Your score is: "  ); // enter from score function
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