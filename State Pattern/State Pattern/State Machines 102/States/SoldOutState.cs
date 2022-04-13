using State_Machines_102.States.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace State_Machines_102.States
{
    public class SoldOutState : IState
    {
        GumBallMachine gumBallMachine;

        public SoldOutState(GumBallMachine _gumBallMachine)
        {
            gumBallMachine = _gumBallMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void Refill()
        {
            gumBallMachine.SetState(gumBallMachine.noQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
        public override string ToString()
        {
            return "Sold out";
        }
    }
}
