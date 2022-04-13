using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControlWithUndo.Command.Abstractions
{
    public interface ICommand
    {

        public void Excute();
        public void Undo();

    }
}
