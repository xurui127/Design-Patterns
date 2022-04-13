using System;

namespace State_Machines_102
{
    class Program
    {
        static void Main(string[] args)
        {
            GumBallMachine gumBallMachine = new GumBallMachine(2);

            Console.WriteLine(gumBallMachine) ;

            gumBallMachine.InsertQuarter();
            gumBallMachine.TurnCrank();
            Console.WriteLine(gumBallMachine) ;

            gumBallMachine.InsertQuarter();
            gumBallMachine.TurnCrank();
            gumBallMachine.InsertQuarter();
            gumBallMachine.TurnCrank();

            gumBallMachine.Refill(5);
            gumBallMachine.InsertQuarter();
            gumBallMachine.TurnCrank();
            Console.WriteLine(gumBallMachine);
        }
    }
}
