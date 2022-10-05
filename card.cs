using System;

namespace Hilo
{
    public class Card{
        public int draw_card()
        {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 13);
        
        return number;
        
        }

        

        
    }
    
}