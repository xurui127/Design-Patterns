using System;
using System.Collections.Generic;
using System.Text;

namespace State_Machines_101
{
    public class GumballMachine
    {
        private static int soldOut = 0;
        private static int noQuarter = 1;
        private static int hasQuarter = 2;
        private static int sold = 3;

        private int state = soldOut;
        private int count = 0;
        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 1)
            {
                state = noQuarter;
            }
        }

        public void InsertQuarter()
        {
            if (state == hasQuarter)
            {
                Console.WriteLine("You can't insert another quarter");
            }
            else if (state == noQuarter)
            {
                state = hasQuarter;
                Console.WriteLine("You insert a quarter");
            }
            else if (state == soldOut)
            {
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            }
            else if (state == sold)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball");
            }
        }
        public void EjectQuarter()
        {
            if (state == hasQuarter)
            {
                Console.WriteLine("Quarter returned");
                state = noQuarter;
            }
            else if (state == noQuarter)
            {
                Console.WriteLine("You haven't inserted a quarter");
            }
            else if (state == sold)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (state == soldOut)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
            }
        }
        public void TurnCrank()
        {
            if (state == sold)
            {
                Console.WriteLine("turning twice doesn't get you another gumball");
            }
            else if (state == noQuarter)
            {
                Console.WriteLine("You turned but there's no quarter");
            }
            else if (state == hasQuarter)
            {
                Console.WriteLine("You turned...");
                state = sold;
                Dispense();
            }
        }

        public void Dispense()
        {
            if (state == sold)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                count = count - 1;
                if (count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    state = soldOut;

                }
                else
                {
                    state = noQuarter;
                }
            }
            else if (state == noQuarter)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (state == soldOut)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (state == hasQuarter)
            {
                Console.WriteLine("You need to turn the crank");
            }
        }
        public void Refil(int gumBalls)
        {
            count = gumBalls;
            state = noQuarter;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nGumball,Inc.");
            result.Append("\nInventory: " + count + " gumball");
            if (count!=1)
            {
                result.Append("s");
            }
            result.Append("\nMachine is ");
            if (state == soldOut)
            {
                result.Append("Sold Out");

            }
            else if (state == noQuarter)
            {
                result.Append("Waiting for quarter");
            }
            else if (state==hasQuarter)
            {
                result.Append("Waiting for turn of crank");
            }
            else if (state == sold)
            {
                result.Append("delivering a gumball");

            }
            result.Append("\n");

            return result.ToString();
        }
    }
}

