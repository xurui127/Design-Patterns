using State_Machines_102.States.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace State_Machines_102.States
{
    public class NoQuarterState : IState
    {
        GumBallMachine gumBallMachine;

        public NoQuarterState(GumBallMachine _gumBallMachine)
        {
            gumBallMachine = _gumBallMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumBallMachine.SetState(gumBallMachine.hasQuarterState);
        }
        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
        public void Refill()
        {
            
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, But there's no quarter");
        }
        public override string ToString()
        {
            return "Waiting for quarter";
        }
    }
}
