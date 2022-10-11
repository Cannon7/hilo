using System;
using System.Threading;


namespace Hilo;

public class Dealer
{
//main function


public void playgame()
{
    Points points = new Points(); //brings points class from Points.cs
    Card getcard = new Card(); // Brings in Card class from cards.cs
    int score = 300;
    string play_again = "true";
    while (play_again == "true")
    {
        int player_card = getcard.draw_card();
        int vs_card = getcard.draw_card();
        string answer = "right";
        Console.WriteLine("The card is: " + player_card); // number to be displayed after card class is complete
        Console.WriteLine("Higher or lower? [h/l] ");
        string guess = Console.ReadLine();
        
        // <summary>
        // The following if statements will take the guess from the player and determine if their guess is 
        // right or wrong. It will then assign it the string "right" or "wrong" to then be put through the 
        // points file.
        //</summary>
        
        if (guess == "h") { 
            if (player_card > vs_card) 
            { 
                answer = "right";
                score = points.answer_points(score, answer);
            }
            else 
            { 
                answer = "wrong";
                score = points.answer_points(score, answer);
            } 
        }
        
        else if (guess == "l") {
            if (player_card < vs_card)
            { 
                answer = "right";
                score = points.answer_points(score, answer);
            }
            else 
            {
                answer = "wrong";
                score = points.answer_points(score, answer);
            }
        }
        else {
            Console.WriteLine("Sorry that input was not recognized. Please die slowly :)");
        }

        //something needs to go here but I am still figuring it out.
        Console.WriteLine("Next card was: " + vs_card); // also needed from card class
        if (score >= 1000)
        {
            run_again();
        }
        else if (score <= 0)
        {
            run_again();
        }
        Console.WriteLine("Your score is: " + score); // enter from score function
        void run_again()
        {
            Console.WriteLine("Play again? [y/n] ");     
            string continue_game = Console.ReadLine();
            if (continue_game == "n")
            {
                play_again = "false";
            }
            else if (continue_game == "y")
            {
                score = 300;
            }
        }
                   
    }
    
    
}

}