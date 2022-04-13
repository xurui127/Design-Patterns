using CommandPattern_Final_.Command.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
    class MacroCommand : ICommand
    {
        ICommand[] commands;
        public MacroCommand(ICommand[] _commands)
        {
            commands = _commands;
        }
        public void Excute()
        {
            foreach (var command in commands)
            {
                command.Excute();
            }
        }

        public void Undo()
        {
            for (int i = commands.Length-1;i>=0 ; i--)
            {
                commands[i].Undo();
            }
        }
    }
}
