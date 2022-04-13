using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.SubClasses
{
   public class Screen
    {
        private string description;

        public Screen(string _description)
        {
            description = _description;
        }
        public void Up()
        {
            Console.WriteLine($"{description} Up");
        }
        public void Down()
        {
            Console.WriteLine($"{description} Down");
        }
        public override string ToString()
        {
            return description;
        }

    }
}
