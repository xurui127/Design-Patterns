using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command.Abstraction
{
   public interface ICommand
    {
       void Excute();
        void Undo();
    }
}
