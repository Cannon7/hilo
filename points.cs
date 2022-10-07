using System;

namespace Hilo
{
    public class Points{

        public int answer_points(int set_points, string answer)
        {
            if (answer == "right")
                {
                    set_points += 100;
                }
            else {
                set_points -= 75;
            }
            
            return set_points;
        }   


        

        
    }
    
}