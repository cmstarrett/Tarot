﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch;
            do
            {
                Console.WriteLine("*** Tarot Cards and their meanings");
                // need to add some code to have the program do something

                // Menu to display to the user
                Console.WriteLine("1. Any Card at Random."); // call ShowRandomCard
                Console.WriteLine("2. A Random Major Arcana card."); // call ShowRandomMajor
                Console.WriteLine("3. A Random Minor Arcana Card."); // Call ShowRaondomMinor
                Console.WriteLine("4. A specific card from the Tarot.");// CallShowCardPicked 
                Console.WriteLine("5. Display the information for all 78 cards in order."); // Call AllCards
                Console.WriteLine("6. Exit the program");


                // call based on the input by the user 

                caseSwitch = Convert.ToInt32(Console.ReadLine()); 
                if (caseSwitch != 6)
                {
                    PickCard card = new PickCard();

                    switch (caseSwitch)
                    {
                        case 1:
                            card.ShowRandomCard();
                            break;
                        case 2:
                            card.ShowRandomMajor();
                            break;
                        case 3:
                            card.ShowRandomMinor();
                            break;
                        case 4:
                            card.ShowCardPicked();
                            break;
                        case 5:
                            card.AllCards();
                            break;
                        default:
                            Console.WriteLine("Please select a number between 1 and 6. Press Enter to select again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Have a Great day!");

                }
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();

            }

            while (caseSwitch != 6);
        }

    }
}
