using System;

namespace hilo
{
    public class Card{
        public void draw_card()
        {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 13);
        
        return number;

        }

        

        
    }
    
}