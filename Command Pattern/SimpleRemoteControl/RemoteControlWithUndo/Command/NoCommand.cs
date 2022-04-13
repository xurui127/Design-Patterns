using RemoteControlWithUndo.Command.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControlWithUndo.Command
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
