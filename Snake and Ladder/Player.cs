using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    public class Player
    {
        int Position1=0 ,Position2=0 ,Position , Dice,Num_Dice_Roll_Plyr1=0, Num_Dice_Roll_Plyr2=0, Turn=0,player=0,
            Num_Dice_Roll;
        public void RollDice()
        {
            Random random= new Random();
            while(Position<100)
            {
                Dice = random.Next(1, 7);
                int check1 = random.Next(0, 3);
                if(Turn==0)
                {
                    Position = Position1;
                    player = 1;
                }
                else
                {
                    Position = Position2;
                    player = 2;
                }
                switch (check1)
                {
                    case 0:
                        break;
                    case 1:
                        Position += Dice;
                        if(Position>100)
                        {
                            Position -= Dice;
                        }
                        break;
                    case 2:
                        Position -= Dice;
                        if (Position < 0)
                        {
                            Position =0;
                        }
                        break;
                }
                if(player==1)
                {
                    Position1= Position;
                    Num_Dice_Roll_Plyr1++;
                    if (check1 != 1)
                    {
                        Turn = 1;
                    }
                    Num_Dice_Roll = Num_Dice_Roll_Plyr1;
                }
                else
                {
                    Position2 = Position;
                    Num_Dice_Roll_Plyr2++;
                    if (check1!= 1)
                    {
                        Turn = 0;
                    }
                    Num_Dice_Roll= Num_Dice_Roll_Plyr2;
                }
                
                Console.WriteLine("Player1 at " + Position1+" And Player2 at "+Position2);
            }
            Console.WriteLine("\nPlayer"+player+" won At Position" + Position+"\nNumber of Dice rolls to win"+Num_Dice_Roll);
        }
    }
}
