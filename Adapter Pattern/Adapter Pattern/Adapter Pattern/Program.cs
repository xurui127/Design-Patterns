using Adapter_Pattern.Adapter.Modle.Ducks;
using Adapter_Pattern.Adapter.Modle.Ducks.Abstraction;
using Adapter_Pattern.Adapters;
using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();
            ITurkey turkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);


            Console.WriteLine("The Turkey says ...");
            turkey.Gobble();
            turkey.Fly();
            Console.WriteLine("\n The Duck says ...");
            TestDuck(duck);

            Console.WriteLine("\n The TurkeyAdapter says ..."); ;
            TestDuck(turkeyAdapter);

            ITurkey duckAdapter = new DuckAdapter(duck);
            Console.WriteLine( "==============");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The DuckAdapter says....");
                duckAdapter.Gobble();
                duckAdapter.Fly();
            }

           
        }
        public static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
