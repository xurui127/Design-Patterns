using State_Machines_102.States.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace State_Machines_102.States
{
    public class SoldState : IState
    {
        GumBallMachine gumBallMachine;
        public SoldState(GumBallMachine _gumBallMachine)
        {
            gumBallMachine = _gumBallMachine;
        }
        public void Dispense()
        {
            gumBallMachine.ReleaseBall();
            if (gumBallMachine.count > 0)
            {
                gumBallMachine.SetState(gumBallMachine.noQuarterState);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                gumBallMachine.SetState(gumBallMachine.soldOutState);
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void Refill()
        {
           
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }
        public override string ToString()
        {
            return "Dispensing a gumball";
        }
    }
}
