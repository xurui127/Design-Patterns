
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DuckSort
{
    public class Duck : IComparable<Duck>
    {
        private string name;
        private int weight;
        public Duck(string _name, int _weight)
        {
            name = _name;
            weight = _weight;
        }
        public int CompareTo( Duck other) // Template Method
        {
            if (weight<other.weight)
            {
                return -1;
            }
            else if (weight ==other.weight)
            {
                return 0;
            }
            else   //weight > other.weight
            {
                return 1;
            }
        }
        public override string ToString()
        {
            return $"{name} weights {weight.ToString()}";
        }
    }
}
