using System;

namespace DuckSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks =
            {
                new Duck("Daffy",8),
                new Duck("Dewey",2),
                new Duck("Howard",7),
                new Duck("Louie",2),
                new Duck("Donald",10),
                new Duck("Huey",2)

            };
            Console.WriteLine("Before Sorting");
            Display(ducks);
            Array.Sort(ducks);
            Console.WriteLine("\nAfter Sorting");
            Display(ducks);
        }
        public static void Display(Duck[] _ducks)
        {
            foreach (var duck in _ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
