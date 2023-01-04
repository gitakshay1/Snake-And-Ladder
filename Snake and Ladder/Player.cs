using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    public class Player
    {
        int Position1 = 0, Player1,Num_Dice_Roll=0;
        public void RollDice()
        {
            Random random= new Random();
            while(Position1<100)
            {
                Player1 = random.Next(1, 7);
                int check1 = random.Next(0, 3);
                switch (check1)
                {
                    case 0:
                        break;
                    case 1:
                        Position1 += Player1;
                        if(Position1>100)
                        {
                            Position1 -= Player1;
                        }
                        break;
                    case 2:
                        Position1 -= Player1;
                        if (Position1 < 0)
                        {
                            Position1 =0;
                        }
                        break;
                }
                Num_Dice_Roll++;
                Console.WriteLine("Player1 postion at" + Position1);
            }
            Console.WriteLine("\nPlayer1 won At Position" + Position1+"\nNumber of Dice rolls to win"+Num_Dice_Roll);
        }
    }
}
