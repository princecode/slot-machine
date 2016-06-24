﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class Program
    {
        /*
         * Welcome message
         * Directions
         * Choose a machine
         * Place a bet
         * Pull lever
         * Randomly rolls around and gives you 
         * Machine tells you if you won or not
         */
        static void Main(string[] args)
        {
            SlotMachine myMachine = new SlotMachine(); // 3 slots, 5 icons per slot

            Console.WriteLine("\n\nWelcome to ¢heapE slots!\n");

            Console.WriteLine("This is a simple penny slot machine. Place your wager and win BIG!!!\n\n");

            while (true)
            {
                // place a bet
                Console.WriteLine("Please enter your wager in pennies.");

                // You could get this using:
                // int userBet = Convert.ToInt32(Console.ReadLine());
                // myMachine.CurrentBet = userBet;
                myMachine.CurrentBet = Convert.ToInt32(Console.ReadLine());

                // pull the lever
                Console.WriteLine("Press enter to pull the lever");
                Console.ReadKey(); // TODO Later: make this actually look for ENTER
                myMachine.PullLever();

                // display the results
                int[] tempResults = myMachine.GetResults();
                for (int i = 0; i < tempResults.Length; i++)
                {
                    Console.Write(tempResults[i] + " ");
                }

                // payout
                Console.WriteLine("You won {0} pennies!", myMachine.GetPayout());
            }

        }
    }
}
