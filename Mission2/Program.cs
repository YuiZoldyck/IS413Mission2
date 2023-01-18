using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numThrows = 0;
            DiceRoller dr = new DiceRoller();

            //Print out the UI part
            Console.Write("Welcome to the dice throwing simulator!\n\n");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            numThrows = Int32.Parse(Console.ReadLine());

            //Calls DiceRoller class to roll
            dr.DiceSimulator(numThrows);

            Console.Write("\nDICE ROLLING SIMULATION RESULTS\n");
            Console.Write("Each \"*\" represents 1% of the total number of rolls.\n");
            Console.Write("Total number of rolls = " + Convert.ToString(numThrows) + "\n\n");

            //Calls DiceRoller class to print the asterisks
            dr.PrintResults(numThrows);

            Console.Write("\nThank you for using the dice throwing simulator.\tGoodbye!");
            
        }
    }
}
