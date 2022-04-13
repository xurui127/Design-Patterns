using State_Machines_102.States;
using State_Machines_102.States.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace State_Machines_102
{
    public class GumBallMachine
    {
        public IState soldOutState { get; }
        public IState noQuarterState { get; }
        public IState hasQuarterState { get; }
        public IState soldState { get; }

       public IState state { get; private set; }
       public  int count { get; private set; }

        public GumBallMachine(int numGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);

            this.count = numGumballs;
            if (numGumballs>0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }
        public void InsertQuarter()
        {
            state.InsertQuarter();
        }
        public void EjectQuarter()
        {
            state.EjectQuarter();
        }
        public void TurnCrank()
        {
            state.TurnCrank();
        }
        public void SetState(IState _state)
        {
            this.state = _state;
        }
        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot ... ");
            if (count>0)
            {
                count -= 1;
            }
        }
        public void Refill(int _count)
        {
            count += _count;
            Console.WriteLine($"The gumball machine was just refilled; It's new count is : {count.ToString()}");
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\n Gumball, Inc.");
            result.Append("\nInventory: " + count.ToString() + " gumall");
            if (count!=1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + state + "\n");

            return result.ToString();
        }
    }
}
