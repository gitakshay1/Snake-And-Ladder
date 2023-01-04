using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    public class Player
    {
        int Position1 = 0, Player1;
        public void RollDice()
        {
            Random random= new Random();
            Player1=random.Next(1,7);
            int check1=random.Next(0,3);
            switch(check1)
            {
                case 0:
                    break;
                case 1:
                    Position1 += Player1;
                    break;
                case 2:
                    Position1 -= Player1;
                    break;
            }
        }
    }
}
