using State_Machines_102.States.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace State_Machines_102.States
{
    public class HasQuarterState : IState
    {
        private GumBallMachine gumBallMachine;

        public HasQuarterState(GumBallMachine _gumBallMachine)
        {
            gumBallMachine = _gumBallMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }
        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumBallMachine.SetState(gumBallMachine.noQuarterState);
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned ...");
            gumBallMachine.SetState(gumBallMachine.soldState);
        }
        public void Refill()
        {
            
        }
        public override string ToString()
        {
            return "Waiting for turn of crank";
        }
    }
}
