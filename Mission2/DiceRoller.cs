using System;
namespace Mission2
{
    public class DiceRoller
    {

        int[] diceRolls = new int [13];

        //construtor to initialize the array
        public DiceRoller()
        {
            for(int i = 0; i < 13; i++)
            {
                diceRolls[i] = 0;
            }
        }

        public void DiceSimulator(int rolls)
        {
            //for the number of rolls entered
            //    generate a new number between 2 to 12
            //    select case
            //    depending on what nnumber it is update the number within that array spot
            while (rolls > 0)
            {
                Random r = new Random();
                int dice = r.Next(2, 13);
                switch(dice)
                {
                    case 2:
                        diceRolls[2]++;
                        break;
                    case 3:
                        diceRolls[3]++;
                        break;
                    case 4:
                        diceRolls[4]++;
                        break;
                    case 5:
                        diceRolls[5]++;
                        break;
                    case 6:
                        diceRolls[6]++;
                        break;
                    case 7:
                        diceRolls[7]++;
                        break;
                    case 8:
                        diceRolls[8]++;
                        break;
                    case 9:
                        diceRolls[9]++;
                        break;
                    case 10:
                        diceRolls[10]++;
                        break;
                    case 11:
                        diceRolls[11]++;
                        break;
                    case 12:
                        diceRolls[12]++;
                        break;
                }
                rolls--;

            }
        }

        //will print out the asterisks
        public void PrintResults(int rolls)
        {
            for (int i = 2; i < 13; i++)
            {
                //calculates the percentage 
                decimal per = (decimal) diceRolls[i] / (decimal) rolls * (decimal) 100;

                Console.Write(Convert.ToString(i) + ": ");
                //for loop through that percentage to print 
                for(int j = 0; j < per; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
