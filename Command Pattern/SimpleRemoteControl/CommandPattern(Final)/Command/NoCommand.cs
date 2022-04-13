using CommandPattern_Final_.Command.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
   public class NoCommand : ICommand
    {
        public void Excute()
        {
        }

        public void Undo()
        {
        }
    }
}
