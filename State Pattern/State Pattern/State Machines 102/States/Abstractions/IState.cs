using System;
using System.Collections.Generic;
using System.Text;

namespace State_Machines_102.States.Abstractions
{
   public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Refill();
    }
}
